## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ADEF70]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB418154F0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D27EE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D27F00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41480DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41536850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41480DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB418BF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C3E3B10008
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
       call      qword ptr [7FFB41D2DE60]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ABEF58]
       mov       ecx,65
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F4FE0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D07F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D07F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41460DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41516850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41460DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41460DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB4189F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B841F30008
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
       call      qword ptr [7FFB41D0DEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ACEF40]
       mov       ecx,65
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41804FE0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D17F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D17F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41470DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41470DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB418AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24234650008
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
       call      qword ptr [7FFB41D1DEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4154F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41AEEF40]
       mov       ecx,65
       mov       rdx,7FFB4194B818
       call      qword ptr [7FFB4154F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41824FE0
       call      qword ptr [7FFB4154F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4154D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4194B818
       call      qword ptr [7FFB4154F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4154D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D37F00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D37F18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41490DE0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41546850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4154F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41490DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41490DB8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DC8
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DD0
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB418CF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20C2EA80008
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
       call      qword ptr [7FFB41D3DEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ACEA78]
       mov       ecx,65
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41804FE0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC348]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC360]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41470DE0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41470DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DD0
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB418AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EBA9250008
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
       call      qword ptr [7FFB41CFDE90]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4150F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41AAEF58]
       mov       ecx,65
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E4FE0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF7F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF7F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41450DE0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41506850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4150F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41450DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41450DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB4188F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2143A600008
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
       call      qword ptr [7FFB41CFDEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ABEF70]
       mov       ecx,65
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5370
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF7F30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF7F48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41460F00
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41516850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41460EF8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41460ED8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460EE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460EE8
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460EF0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460EF0
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFB4189F3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A9004A0008
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
       call      qword ptr [7FFB41CFE5B0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountList()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ADEF88]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB418154F0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41C24E28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41C24E40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41481218
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41481210
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB414811F0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB414811F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481200
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481208
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481208
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       cmp       [r10+8],rcx
       je        short M01_L00
       jmp       short M01_L03
M01_L02:
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L00
       cmp       [r10+18],rcx
       je        short M01_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L06
M01_L04:
       cmp       [r10],rcx
       je        short M01_L00
M01_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L06
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L05
M01_L06:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
       jmp       short M01_L00
M01_L07:
       jmp       qword ptr [7FFB418BF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2DF37960008
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
       call      qword ptr [7FFB41D66580]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       cmp       [rdx],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       jne       short M03_L04
M03_L03:
       xor       edx,edx
       jmp       short M03_L00
M03_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       jmp       short M03_L02
; Total bytes of code 88
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,22E3E000A30
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L43
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L45
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L19
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L21
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,22E28000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,22E28000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,22E3E000A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L27
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L27
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       ebx,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L27
       cmp       r11d,esi
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       r13d,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       je        short M00_L18
M00_L15:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L13
M00_L18:
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FFB41D2C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L22:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L23:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L24
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418B5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418B5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L25:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L29
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L30:
       mov       r8,22E3E000A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D25758]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L12
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L33
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L35:
       mov       rcx,r12
       mov       r11,7FFB41480DC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L46
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D2E5F8]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       test      byte ptr [7FFB41D3B448],1
       je        short M00_L44
M00_L41:
       mov       rcx,22E3E000AB0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,22E3E000A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41536BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22E3E000A30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L44:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L45:
       mov       rcx,rdi
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L46:
       mov       rcx,r12
       mov       r11,7FFB41480DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L47
       mov       rcx,rax
       mov       r11,7FFB41480DD0
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,22E28000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,22E28000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,22E3E000A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D2C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D2C900]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418B5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,22E3E000A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D25758]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CAD8E0]
       vbroadcastsd ymm3,qword ptr [7FFB41CAD900]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CAD8E0]
       vbroadcastsd ymm2,qword ptr [7FFB41CAD900]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41CAD8E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41CAD900]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D2CCF0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,215C2800A30
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L41
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L42
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,215AC800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,215AC800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,215C2800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       esi,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L26
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FFB41480DC0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FFB41D0C8A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418B5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418B5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L28
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,215C2800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D05260]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D0E5C8]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       test      byte ptr [7FFB41D193C8],1
       je        short M00_L43
M00_L40:
       mov       rcx,215C2800AB0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,215C2800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41536BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,215C2800A30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L40
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,215AC800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,215AC800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,215C2800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D0C8A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D0C8B8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418B5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,215C2800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D05260]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C9B980]
       vbroadcastsd ymm3,qword ptr [7FFB41C9B9A0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C9B980]
       vbroadcastsd ymm2,qword ptr [7FFB41C9B9A0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C9B980]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C9B9A0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D0CCA8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,27F2A800A30
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L41
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L42
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,27F14800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,27F14800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,27F2A800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       ebx,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L26
       cmp       r11d,esi
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       r13d,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       r13d,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FFB41490C38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FFB41D1C888]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FFB4154D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418C5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418C5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416E51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L28
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,27F2A800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D15170]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416E51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB41490C30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D1E5B0]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       test      byte ptr [7FFB41D28E08],1
       je        short M00_L43
M00_L40:
       mov       rcx,27F2A800AB0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,27F2A800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41546BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27F2A800A30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFB4154F948]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L40
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB41490C28
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB41490C40
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB41490C40
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,27F14800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,27F14800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,27F2A800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D1C888]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4154D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D1C8A0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418C5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416E51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,27F2A800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D15170]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416E51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CA8D20]
       vbroadcastsd ymm3,qword ptr [7FFB41CA8D40]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CA8D20]
       vbroadcastsd ymm2,qword ptr [7FFB41CA8D40]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41CA8D20]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41CA8D40]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D1CC90]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,22418400A30
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L41
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L42
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,22402400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,22402400170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,22418400A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       ebx,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L26
       cmp       r11d,esi
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       r13d,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       r13d,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FFB41470C38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FFB41D1C930]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418A5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L28
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,22418400A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D15788]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB41470C30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D1E670]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       test      byte ptr [7FFB41D2B488],1
       je        short M00_L43
M00_L40:
       mov       rcx,22418400AB0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,22418400A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41526BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22418400A30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L40
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB41470C28
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB41470C40
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB41470C40
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,22402400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,22402400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,22418400A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D1C930]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D1C948]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,22418400A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D15788]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C9A9C0]
       vbroadcastsd ymm3,qword ptr [7FFB41C9A9E0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C9A9C0]
       vbroadcastsd ymm2,qword ptr [7FFB41C9A9E0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C9A9C0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C9A9E0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D1CD38]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,1C9E2800A30
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1C9CC800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1C9CC800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1C9E2800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       ebx,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L26
       cmp       r11d,esi
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       r13d,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       r13d,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418A5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L28
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,1C9E2800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D15728]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D1E5F8]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L40:
       test      byte ptr [7FFB41D2B468],1
       je        short M00_L43
M00_L41:
       mov       rcx,1C9E2800AB0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1C9E2800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41526BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C9E2800A30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB41470DA8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1C9CC800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1C9CC800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1C9E2800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D1C8D0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1C9E2800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D15728]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C9C2A0]
       vbroadcastsd ymm3,qword ptr [7FFB41C9C2C0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C9C2A0]
       vbroadcastsd ymm2,qword ptr [7FFB41C9C2C0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C9C2A0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C9C2C0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D1CCC0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,29748800A30
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,29732800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,29732800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,29748800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       esi,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L26
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FFB41470C38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418A5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L28
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,29748800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D15740]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB41470C30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D1E610]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L40:
       test      byte ptr [7FFB41D2AF38],1
       je        short M00_L43
M00_L41:
       mov       rcx,29748800AB0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,29748800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41526BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29748800A30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB41470C28
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB41470C40
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB41470C40
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,29732800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,29732800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,29748800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D1C900]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,29748800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D15740]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C99A00]
       vbroadcastsd ymm3,qword ptr [7FFB41C99A20]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C99A00]
       vbroadcastsd ymm2,qword ptr [7FFB41C99A20]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C99A00]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C99A20]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D1CCF0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,15A3D802A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L21
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L23
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,15A3D800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,15A3D800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L24
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L28
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L25
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,15A3D802A38
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L17
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L17
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L17
       mov       esi,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rsi],0
       jne       short M00_L17
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       short M00_L17
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       near ptr M00_L20
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       short M00_L17
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L18]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L18:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L19
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L19:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L20:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L21:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L22:
       mov       rcx,r12
       mov       r11,7FFB41470E28
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L23:
       mov       ecx,2
       call      qword ptr [7FFB41D0C8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L24:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L26
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB418A5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L27
M00_L26:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L27:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L28:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,15A3D802A38
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D06DA8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L17
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L20
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB41470E20
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L22
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D0F3C0]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L40:
       test      byte ptr [7FFB41D3A070],1
       je        short M00_L43
M00_L41:
       mov       rcx,15A3D802B08
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,15A3D802A18
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41526BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15A3D802A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB41470E18
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB41470E30
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB41470E30
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1777
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,15A3D800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,15A3D800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,15A3D802A38
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D0C8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D0C8D0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,15A3D802A38
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D06DA8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 995
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CBFCE0]
       vbroadcastsd ymm3,qword ptr [7FFB41CBFD00]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CBFCE0]
       vbroadcastsd ymm2,qword ptr [7FFB41CBFD00]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41CBFCE0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41CBFD00]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41D0CCD8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       rcx,1FE32000AE8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L21
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L23
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1FE1C000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1FE1C000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L24
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L28
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L25
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1FE32000288
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rbx,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L17
       cmp       [rbx],bl
       mov       esi,r11d
       sar       esi,5
       mov       ebx,[rbx+rsi*4]
       bt        ebx,r11d
       jae       near ptr M00_L17
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L17
       mov       esi,r11d
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+rsi],0
       jne       short M00_L17
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       short M00_L17
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       near ptr M00_L20
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       short M00_L17
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFB416A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L18]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L18:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L19
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L19:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L20:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L21:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L22:
       mov       rcx,r12
       mov       r11,7FFB414510E8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L23:
       mov       ecx,2
       call      qword ptr [7FFB41BF55D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L24:
       call      qword ptr [7FFB4150D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L26
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFB41885F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L27
M00_L26:
       mov       rcx,[r13+40]
       call      qword ptr [7FFB41885C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L27:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L28:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,1FE32000288
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFB41D3DE30]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L17
       jmp       near ptr M00_L12
M00_L30:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L32
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L20
M00_L34:
       mov       rcx,r12
       mov       r11,7FFB414510E0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L22
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FFB41D3F8D0]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,11
       call      qword ptr [7FFB4150F948]
       int       3
M00_L40:
       test      byte ptr [7FFB41DA2720],1
       je        short M00_L43
M00_L41:
       mov       rcx,1FE32000B28
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1FE32000AD8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41506BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FE32000AE8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFB414510D8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FFB414510F0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFB414510F0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1776
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__7_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1FE1C000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1FE1C000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1FE32000288
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41BF55D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4150D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41BF55F0]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB41885C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1FE32000288
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D3DE30]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 995
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41DD0540]
       vbroadcastsd ymm3,qword ptr [7FFB41DD0560]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41DD0540]
       vbroadcastsd ymm2,qword ptr [7FFB41DD0560]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41DD0540]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41DD0560]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
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
       call      qword ptr [7FFB41BF59E0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB41505C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,1B4FEC00A40
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       short M00_L06
       nop       dword ptr [rax]
M00_L02:
       mov       rcx,rdi
       mov       r11,7FFB41460E40
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460E48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460E50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460E58
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L34
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
       nop       dword ptr [rax+rax]
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L06
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L28
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L28
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1B4E8C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1B4E8C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L40
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,1B4FEC00A58
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r12,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L34
       cmp       [r12],r12b
       mov       r13d,ebx
       sar       r13d,5
       mov       r13d,[r12+r13*4]
       bt        r13d,ebx
       jae       near ptr M00_L34
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
M00_L21:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r13,r11d
       movzx     r13d,word ptr [r9+r13*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L34
       mov       [rbp-3C],r15d
       mov       r12d,esi
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+r12],0
       jne       near ptr M00_L38
       cmp       esi,r13d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L39
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B4FEC00A38
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41516BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B4FEC00A40
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FFB4151FA20]
       int       3
M00_L27:
       call      qword ptr [7FFB4151F570]
       int       3
M00_L28:
       mov       ecx,2
       call      qword ptr [7FFB41CFFD20]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L29:
       call      qword ptr [7FFB4151D590]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L30:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L31
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB418A5FE0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB418A5CF8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L32:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L36
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L37:
       mov       r8,1B4FEC00A58
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41CF5C98]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L38:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L34
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L34
M00_L40:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L41]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L41:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L42
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L42:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L43:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L44
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460E58
       call      qword ptr [r11]
M00_L44:
       nop
       add       rsp,38
       ret
; Total bytes of code 1772
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1B4E8C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1B4E8C00170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1B4FEC00A58
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41CFFD20]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4151D590]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41CFFD38]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5CF8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1B4FEC00A58
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41CF5C98]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
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
       call      qword ptr [7FFB4194E058]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C91FA0]
       vbroadcastsd ymm3,qword ptr [7FFB41C91FC0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C91FA0]
       vbroadcastsd ymm2,qword ptr [7FFB41C91FC0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C91FA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C91FC0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,18A25800A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L02:
       mov       rcx,rdi
       mov       r11,7FFB41460D90
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460D98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L35
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L06
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L44
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,18A0F800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,18A0F800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L41
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,18A25800A40
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r12,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L35
       cmp       [r12],r12b
       mov       r13d,ebx
       sar       r13d,5
       mov       r13d,[r12+r13*4]
       bt        r13d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
M00_L21:
       test      eax,eax
       jle       near ptr M00_L38
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r13,r11d
       movzx     r13d,word ptr [r9+r13*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L35
       mov       [rbp-3C],r15d
       mov       r12d,esi
       mov       r15,7FFBA0329AD0
       cmp       byte ptr [r15+r12],0
       jne       near ptr M00_L39
       cmp       esi,r13d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L40
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,18A25800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41516BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18A25800A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FFB4151F948]
       int       3
M00_L27:
       call      qword ptr [7FFB4151F498]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L06
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFB41D0C888]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FFB4151D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB41895F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB41895C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L36]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M00_L36:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L37
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L37:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L38:
       mov       r8,18A25800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D05620]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L35
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L35
M00_L40:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L35
M00_L41:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L42]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M00_L42:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L43
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L43:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L44:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L45
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
M00_L45:
       nop
       add       rsp,38
       ret
; Total bytes of code 1769
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,18A0F800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,18A0F800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,18A25800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D0C888]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4151D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D0C8A0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB41895C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,18A25800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D05620]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
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
       call      qword ptr [7FFB41D0CC90]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C8BB20]
       vbroadcastsd ymm3,qword ptr [7FFB41C8BB40]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C8BB20]
       vbroadcastsd ymm2,qword ptr [7FFB41C8BB40]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C8BB20]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C8BB40]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,23DEA800A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        short M00_L02
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L20
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L11
       jmp       near ptr M00_L28
M00_L02:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       short M00_L01
M00_L03:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L18
       cmp       ebx,eax
       jge       short M00_L04
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L04:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L07
M00_L05:
       mov       [rbp-3C],r15d
M00_L06:
       mov       ebx,0FFFFFFFF
M00_L07:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L08:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L10
M00_L09:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L10:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L24
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L11:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L46
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L12:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L13
       mov       rcx,23DD4800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L13
       mov       rcx,23DD4800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L13:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L14:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L43
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,23DEA800A40
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L16
       mov       [rbp-3C],r15d
M00_L15:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L39
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L15
       mov       r15d,[rbp-3C]
M00_L16:
       test      eax,eax
       jle       near ptr M00_L40
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L05
M00_L17:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L18:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L41
       cmp       esi,r12d
       je        near ptr M00_L03
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L19
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L42
M00_L19:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L06
       mov       r15d,[rbp-3C]
       jmp       short M00_L17
M00_L20:
       mov       rcx,rdi
       mov       r11,7FFB41480C08
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L21:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480C10
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L23
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480C18
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L21
       add       r15d,1
       jo        short M00_L22
       jmp       short M00_L21
M00_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L23:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480C20
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L24:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,23DEA800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41536BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23DEA800A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L27:
       call      qword ptr [7FFB4153F498]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L24
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFB41D2C888]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L30:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB418B5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB418B5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L35:
       mov       r15d,[rbp-3C]
M00_L36:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L38
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L07
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L40:
       mov       r8,23DEA800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D256F8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L06
M00_L41:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L42:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L43:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L45
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L45:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L08
M00_L46:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L10
       jmp       near ptr M00_L09
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480C20
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1786
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,23DD4800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,23DD4800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,23DEA800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D2C888]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D2C8A0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418B5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,23DEA800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D256F8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
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
       call      qword ptr [7FFB41D2CC90]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CA9600]
       vbroadcastsd ymm3,qword ptr [7FFB41CA9620]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CA9600]
       vbroadcastsd ymm2,qword ptr [7FFB41CA9620]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41CA9600]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41CA9620]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,2C2C7C00A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L24
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L16
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L26
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L12
       jmp       near ptr M00_L27
       nop       dword ptr [rax]
M00_L02:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L34
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L34
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L02
M00_L03:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L07
M00_L04:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L05:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L34
       mov       r12d,esi
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L34
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L06
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L34
M00_L06:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L04
M00_L07:
       mov       ebx,0FFFFFFFF
M00_L08:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L09:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L11
M00_L10:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L11:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L20
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L12:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L28
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L28
M00_L13:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L14
       mov       rcx,2C2B1C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L14
       mov       rcx,2C2B1C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L14:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L15:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,2C2C7C00A40
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L03
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFB41490D88
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L17:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41490D90
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41490D98
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L17
       add       r15d,1
       jo        short M00_L18
       jmp       short M00_L17
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41490DA0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L20:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L21:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L22:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L05
       cmp       ebx,eax
       jge       short M00_L23
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L34
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L08
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2C2C7C00A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41546BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C2C7C00A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       ecx,11
       call      qword ptr [7FFB4154F948]
       int       3
M00_L26:
       call      qword ptr [7FFB4154F498]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L20
M00_L28:
       mov       ecx,2
       call      qword ptr [7FFB41D3C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L13
M00_L29:
       call      qword ptr [7FFB4154D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L14
M00_L30:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L31
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB418C5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB418C5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L32:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L15
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L15
M00_L34:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416E51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L36
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L08
M00_L37:
       mov       r8,2C2C7C00A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D35698]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       jmp       near ptr M00_L07
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416E51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L40
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L09
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L11
       jmp       near ptr M00_L10
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41490DA0
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1739
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2C2B1C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2C2B1C00170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,2C2C7C00A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D3C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4154D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D3C900]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418C5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416E51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2C2C7C00A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D35698]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416E51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416E51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
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
       call      qword ptr [7FFB41D3CCF0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CBBDC0]
       vbroadcastsd ymm3,qword ptr [7FFB41CBBDE0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CBBDC0]
       vbroadcastsd ymm2,qword ptr [7FFB41CBBDE0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41CBBDC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41CBBDE0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,1E695800A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L26
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L22
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L13
       jmp       near ptr M00_L28
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41470C20
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L03:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L04:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       short M00_L01
M00_L05:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L20
       cmp       ebx,eax
       jge       short M00_L06
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L06:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L09
M00_L07:
       mov       [rbp-3C],r15d
M00_L08:
       mov       ebx,0FFFFFFFF
M00_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L10:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L12
M00_L11:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L12:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L03
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L13:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L46
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L14:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L15
       mov       rcx,1E67F800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L15
       mov       rcx,1E67F800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L15:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L16:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L43
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,1E695800A40
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L18
       mov       [rbp-3C],r15d
M00_L17:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L39
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L17
       mov       r15d,[rbp-3C]
M00_L18:
       test      eax,eax
       jle       near ptr M00_L40
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L07
M00_L19:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L20:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L41
       cmp       esi,r12d
       je        near ptr M00_L05
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L21
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L42
M00_L21:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L08
       mov       r15d,[rbp-3C]
       jmp       short M00_L19
M00_L22:
       mov       rcx,rdi
       mov       r11,7FFB41470C08
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L23:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41470C10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L02
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41470C18
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L23
       add       r15d,1
       jo        short M00_L24
       jmp       short M00_L23
M00_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L25:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1E695800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41526BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E695800A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       call      qword ptr [7FFB4152F498]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L03
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L30:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L15
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB418A5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L16
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L16
M00_L35:
       mov       r15d,[rbp-3C]
M00_L36:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L38
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L09
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L40:
       mov       r8,1E695800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D15728]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L08
M00_L41:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L42:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L43:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L45
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L45:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L10
M00_L46:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L12
       jmp       near ptr M00_L11
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41470C20
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1794
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1E67F800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1E67F800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1E695800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D1C8D0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1E695800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D15728]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
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
       call      qword ptr [7FFB41D1CCC0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C993C0]
       vbroadcastsd ymm3,qword ptr [7FFB41C993E0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C993C0]
       vbroadcastsd ymm2,qword ptr [7FFB41C993E0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C993C0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C993E0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,21BD7C00A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L24
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L16
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L26
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L12
       jmp       near ptr M00_L27
       nop       dword ptr [rax]
M00_L02:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L34
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L34
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L02
M00_L03:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L07
M00_L04:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L05:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L34
       mov       r12d,esi
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L34
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L06
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L34
M00_L06:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L04
M00_L07:
       mov       ebx,0FFFFFFFF
M00_L08:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L09:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L11
M00_L10:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L11:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L20
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L12:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L28
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L28
M00_L13:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L14
       mov       rcx,21BC1C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L14
       mov       rcx,21BC1C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L14:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L15:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,21BD7C00A40
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L03
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFB41460D88
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L17:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460D90
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460D98
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L17
       add       r15d,1
       jo        short M00_L18
       jmp       short M00_L17
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L20:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L21:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L22:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L05
       cmp       ebx,eax
       jge       short M00_L23
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L34
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L08
M00_L24:
       mov       ecx,11
       call      qword ptr [7FFB4151F948]
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,21BD7C00A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41516BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21BD7C00A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FFB4151F498]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L20
M00_L28:
       mov       ecx,2
       call      qword ptr [7FFB41D0C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L13
M00_L29:
       call      qword ptr [7FFB4151D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L14
M00_L30:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L31
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB41895F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB41895C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L32:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L15
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L15
M00_L34:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L36
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L08
M00_L37:
       mov       r8,21BD7C00A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D05770]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       jmp       near ptr M00_L07
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L40
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L09
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L11
       jmp       near ptr M00_L10
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1739
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,21BC1C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,21BC1C00170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,21BD7C00A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D0C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4151D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D0C900]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB41895C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,21BD7C00A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D05770]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFB416B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
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
       call      qword ptr [7FFB41D0CCF0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C8BDA0]
       vbroadcastsd ymm3,qword ptr [7FFB41C8BDC0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41C8BDA0]
       vbroadcastsd ymm2,qword ptr [7FFB41C8BDC0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41C8BDA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41C8BDC0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,2697F800A28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L29
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L28
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        short M00_L01
       add       r12,10
       jmp       near ptr M00_L08
M00_L01:
       call      qword ptr [7FFB4153F498]
       int       3
M00_L02:
       mov       rcx,rdi
       mov       r11,7FFB41480F10
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480F18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480F20
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480F28
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L08:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L19
       jmp       near ptr M00_L30
M00_L09:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L25
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L25
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L09
M00_L10:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L14
M00_L11:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L12:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L25
       mov       r12d,esi
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L25
       cmp       esi,r15d
       je        near ptr M00_L23
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L13
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L25
M00_L13:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L11
M00_L14:
       mov       ebx,0FFFFFFFF
M00_L15:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L16:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L18
M00_L17:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L18:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L06
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L19:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L31
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L20:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,26969800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,26969800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L32
M00_L21:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L33
M00_L22:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,2697F800A40
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L10
       jmp       near ptr M00_L09
M00_L23:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L12
       cmp       ebx,eax
       jge       short M00_L24
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       short M00_L25
M00_L24:
       mov       ebx,ecx
       jmp       near ptr M00_L15
M00_L25:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L26]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L27
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L27:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2697F800A20
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41536BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2697F800A28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L06
M00_L31:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L33:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L34
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB418B5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB418B5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L35:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L37:
       mov       r8,2697F800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D16E80]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L25
       jmp       near ptr M00_L14
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L40
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L16
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L18
       jmp       near ptr M00_L17
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB41480F28
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1732
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,26969800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,26969800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,2697F800A40
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41D1C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4153D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41D1C900]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418B5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2697F800A40
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D16E80]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 995
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
       call      qword ptr [7FFB41D1CCF0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CD0CC0]
       vbroadcastsd ymm3,qword ptr [7FFB41CD0CE0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41CD0CC0]
       vbroadcastsd ymm2,qword ptr [7FFB41CD0CE0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41CD0CC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41CD0CE0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+278]
       mov       rcx,11A06000AE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L29
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L28
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        short M00_L01
       add       r12,10
       jmp       near ptr M00_L08
M00_L01:
       call      qword ptr [7FFB4152F498]
       int       3
M00_L02:
       mov       rcx,rdi
       mov       r11,7FFB414711C0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB414711C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB414711D0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB414711D8
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
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
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L08:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L19
       jmp       near ptr M00_L30
M00_L09:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L25
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L25
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L09
M00_L10:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L14
M00_L11:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L12:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L25
       mov       r12d,esi
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L25
       cmp       esi,r15d
       je        near ptr M00_L23
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L13
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L25
M00_L13:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L11
M00_L14:
       mov       ebx,0FFFFFFFF
M00_L15:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L16:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L18
M00_L17:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L18:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L06
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L19:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L31
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L20:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,119F0000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,119F0000170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L32
M00_L21:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L33
M00_L22:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,11A06000288
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L10
       jmp       near ptr M00_L09
M00_L23:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L12
       cmp       ebx,eax
       jge       short M00_L24
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       short M00_L25
M00_L24:
       mov       ebx,ecx
       jmp       near ptr M00_L15
M00_L25:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFB416C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L26]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L27
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L27:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,11A06000AD8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB41526BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,11A06000AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L06
M00_L31:
       mov       ecx,2
       call      qword ptr [7FFB41C155D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L33:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L34
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFB418A5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFB418A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L35:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L37:
       mov       r8,11A06000288
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFB41D5E1F0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L25
       jmp       near ptr M00_L14
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M00_L40
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L16
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L18
       jmp       near ptr M00_L17
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFB414711D8
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1732
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,119F0000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,119F0000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,11A06000288
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFBA0329AD0
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFB41C155D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB4152D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFB41C155F0]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFB418A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L21
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,11A06000288
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFB41D5E1F0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFB416C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBA139F800
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBA14739A0],0
       je        short M01_L25
       call      qword ptr [7FFBA1461648]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 995
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
       call      qword ptr [7FFB41C159E0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFBA0F847E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFBA0F9B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA0F9CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFBA0F9A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBA0F84480]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFBA0F9B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFBA0FAAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBA0F9B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFBA0F8E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFBA0F8E978]
       mov       rbx,rax
       call      qword ptr [7FFBA0F9B8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F9BA18]
       mov       rcx,rbx
       call      qword ptr [7FFBA0F83FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFBA0F9C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFBA0F971F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFBA0F9CBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFBA0FAAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBA0F9CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41DF1AC0]
       vbroadcastsd ymm3,qword ptr [7FFB41DF1AE0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB41DF1AC0]
       vbroadcastsd ymm2,qword ptr [7FFB41DF1AE0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB41DF1AC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB41DF1AE0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB418857A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41CF5560]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41CFF300]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFB41CFC930]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41CFE760]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41CFF300]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41CFE700]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41AAEFA0]
       mov       ecx,65
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E4FE0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC078]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC090]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41450D88
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41505728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D14D800AD0
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DA1C88
       call      qword ptr [7FFB41CF56C8]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41505728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D14D800AD0
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41CFF4B0]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF390]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41CFF3A8]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41CFE700]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,1D137800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41CFE748]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41CF5698]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB417DC2B8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41D25650]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D2F2D0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB41D2C900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D2E730]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D2F2D0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41D2E6D0]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41ADEF88]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41815370
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D2C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D2C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41480D88
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,25273000AD0
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DD1C88
       call      qword ptr [7FFB41D257B8]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25273000AD0
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41D2F480]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41D2F360]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D2F378]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41D2E6D0]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,2525D000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41D2E718]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41D25788]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB417CCEE8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41D15578]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D1F2D0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB41D1C900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D1E730]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D1F2D0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41D1E6D0]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41ACEF88]
       mov       ecx,65
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41805098
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D1C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D1C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41470D88
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1DCE9400AD0
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DC1C88
       call      qword ptr [7FFB41D156E0]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DCE9400AD0
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41D1F480]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41D1F360]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D1F378]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41D1E6D0]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,1DCD3400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41D1E718]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41D156B0]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB417BCD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41D05638]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D0F9F0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB41D0C900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D0E718]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D0F9F0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41D0E6B8]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41ABEF70]
       mov       ecx,65
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5030
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D0C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D0C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41460D88
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41515728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,18018800AD0
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DBAC78
       call      qword ptr [7FFB41D057A0]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41515728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18018800AD0
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41D0FB88]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41D0FA68]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D0FA80]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41D0E6B8]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,18002800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41D0E700]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41D05770]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB418B57A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41D25548]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D2F9F0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFB41D2C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D2E718]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D2F9F0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41D2E6B8]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41ADEF58]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41814FE0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D2C0A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D2C0C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41480D88
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,20286400AD0
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DDAC78
       call      qword ptr [7FFB41D256B0]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20286400AD0
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41D2FB88]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41D2FA68]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D2FA80]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41D2E6B8]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,20270400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41D2E700]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41D25680]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB418B57A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41D25608]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D2F9D8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFB41D2C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D2E700]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41D2F9D8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41D2E6A0]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41ADEF40]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41814FE0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D2C150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D2C168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41480D88
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,13913000AD0
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DDAC78
       call      qword ptr [7FFB41D25770]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,13913000AD0
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41D2FB70]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41D2FA50]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D2FA68]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41D2E6A0]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,138FD000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41D2E6E8]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41D25740]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB416EFE28]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41CE6DC0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41DD4780]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB41CEC900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41CEF4E0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41DD4780]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41CEF480]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41AAEF88]
       mov       ecx,65
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E54F0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC0F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB41450F08
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41505728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,15F42800B30
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41DCC7C0
       call      qword ptr [7FFB41CE6F28]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      qword ptr [7FFB41505728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15F42800B30
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41DD4918]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41DD47F8]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41DD4810]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41CEF480]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,15F2C800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41CEF4C8]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41CE6EF8]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 785
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB4170FE88]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB41D5DC68]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41E84CC0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB41C15698]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41D5FA20]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB41E84CC0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB41D5F9C0]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBA0F84038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBA0F85EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBA0F83FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+8]
       mov       rbx,[rcx]
       test      edx,edx
       je        near ptr M03_L12
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M03_L05
       mov       esi,[rax+8]
M03_L00:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L01:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L10
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L04:
       call      qword ptr [7FFB41ACEF88]
       mov       ecx,65
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB418054F0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41C14E88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41C14EA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       rcx,rax
       mov       r11,7FFB414711C8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M03_L00
M03_L06:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,176EF800B48
       mov       rdx,[rdx]
       lea       ecx,[rsi+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L11
       inc       esi
       mov       ecx,esi
       mov       rax,[rdx+rcx*8+10]
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,rsi
       mov       rcx,7FFB41E9E730
       call      qword ptr [7FFB41D5DDD0]
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,176EF800B48
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L11
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L09
M03_L08:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB41E84E40]
M03_L09:
       mov       rax,rdi
       jmp       near ptr M03_L01
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB41E84D20]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFB41E84D38]
       jmp       short M03_L15
M03_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L12:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB41D5F9C0]
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L16
       mov       rdx,176D9800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB41D5FA08]
       jmp       short M03_L15
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB41D5DDA0]
       lea       rax,[M03_L15]
       add       rsp,28
       ret
; Total bytes of code 783
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBA0F9CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41480DC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41536850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41480DA0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB418BF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DA0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB418AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41480DC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41536850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41480DA0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB418BF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DA0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB418AF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4151F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41460DC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41516850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41460DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DB0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB4189F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DA0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB418AF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4150F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4150F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41450EE8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41506850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4150F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41450EE0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41450EC8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450ED0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450ED8
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450ED8
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB4188F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFB41471210
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFB41471208
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB414711F0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFB414711F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41471200
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41471200
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 316
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       cmp       [r10+8],rcx
       je        short M01_L00
       jmp       short M01_L03
M01_L02:
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L00
       cmp       [r10+18],rcx
       je        short M01_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L06
M01_L04:
       cmp       [r10],rcx
       je        short M01_L00
M01_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L06
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L05
M01_L06:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
       jmp       short M01_L00
M01_L07:
       jmp       qword ptr [7FFB418AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4151F948]
       int       3
M00_L03:
       mov       r11,7FFB41460D98
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L03:
       mov       r11,7FFB41480D98
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41480DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L03:
       mov       r11,7FFB41480DA0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4151F948]
       int       3
M00_L03:
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41460DB0
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41460DB0
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L03:
       mov       r11,7FFB41480D98
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41480DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4151F948]
       int       3
M00_L03:
       mov       r11,7FFB41460D98
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41460DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41460DA8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4153F948]
       int       3
M00_L03:
       mov       r11,7FFB41480EB0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB41480EB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480EC0
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB41480EC0
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFB4152F948]
       int       3
M00_L03:
       mov       r11,7FFB414711D0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFB414711D8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFB414711E0
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFB414711E0
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ACEF40]
       mov       ecx,65
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41804FE0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D17F00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D17F18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41470DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41470DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB418AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2866E1D0008
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
       call      qword ptr [7FFB41D1DEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4154F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41AEEA78]
       mov       ecx,65
       mov       rdx,7FFB4194B818
       call      qword ptr [7FFB4154F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41824FE0
       call      qword ptr [7FFB4154F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4154D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4194B818
       call      qword ptr [7FFB4154F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4154D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D1C300]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D1C318]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41490DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41546850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4154F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41490DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41490DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB418CF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,255D7DC0008
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
       call      qword ptr [7FFB41D1DE48]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ACEA78]
       mov       ecx,65
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41804FE0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192B818
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC330]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC348]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41470DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4152F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41470DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41470DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41470DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB418AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F8CD610008
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
       call      qword ptr [7FFB41CFDE78]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4150F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41AAEA60]
       mov       ecx,65
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5048
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190B818
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CDC330]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CDC348]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41450DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41506850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4150F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41450DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41450DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41450DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB4188F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1AFBFC80008
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
       call      qword ptr [7FFB41CDDE78]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ADEF40]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41814FE0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D27F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D27F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41480DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41536850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4153F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41480DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41480DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFB418BF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20FF8A00008
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
       call      qword ptr [7FFB41D2DEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ABEF88]
       mov       ecx,65
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F54F0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4191B818
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D07F30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D07F48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41460DD8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41516850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4151F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41460DD0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41460DB0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DC0
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41460DC8
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB4189F3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28E54B60008
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
       call      qword ptr [7FFB41D0DEA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB4154F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41AEEF88]
       mov       ecx,65
       mov       rdx,7FFB4194B818
       call      qword ptr [7FFB4154F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB418254F0
       call      qword ptr [7FFB4154F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4154D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4194B818
       call      qword ptr [7FFB4154F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4154D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D27F30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D27F48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41490ED0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41546850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB4154F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41490EC8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41490EA8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490EB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490EB8
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490EC0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41490EC0
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 500
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFB418CF3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B6082B0008
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
       call      qword ptr [7FFB41D2E640]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+8]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFB41ADEA78]
       mov       ecx,65
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41814FE0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193B818
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41C24DE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41C24DF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FFB41481228
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFB41481220
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB41481200
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481208
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481210
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481218
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFB41481218
       call      qword ptr [r11]
M00_L10:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       cmp       [r10+8],rcx
       je        short M01_L00
       jmp       short M01_L03
M01_L02:
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L00
       cmp       [r10+18],rcx
       je        short M01_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L06
M01_L04:
       cmp       [r10],rcx
       je        short M01_L00
M01_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L06
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L05
M01_L06:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
       jmp       short M01_L00
M01_L07:
       jmp       qword ptr [7FFB418BF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
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
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,32FED310008
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
       call      qword ptr [7FFB41D7E4C0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       cmp       [rdx],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       jne       short M03_L04
M03_L03:
       xor       edx,edx
       jmp       short M03_L00
M03_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       jmp       short M03_L02
; Total bytes of code 88
```

