## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68580EC8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68580EC0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68580EB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68580E98
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EA8
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EB0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EB0
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 353
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68570B78
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68570B70
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68570B68
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68570B48
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B58
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B60
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B60
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 354
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68570B78
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68570B70
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68570B68
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68570B48
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B58
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B60
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570B60
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 354
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68570C38
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68570C30
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68570C28
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68570C08
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570C10
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570C18
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570C20
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570C20
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 354
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68560B78
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68560B70
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68616850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68560B68
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68560B48
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68560B50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68560B58
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68560B60
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68560B60
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 354
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68570DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68570DB0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68570DA8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68570D88
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570D90
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570D98
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570DA0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68570DA0
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 354
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68580F08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68580F00
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68636850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68580EF8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68580ED8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EE8
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EF0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68580EF0
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 354
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L05
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L04
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       edi,[rcx+10]
M00_L00:
       movsxd    rdi,edi
M00_L01:
       cmp       rdi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FFC68571240
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       r11,7FFC68571238
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L06
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L07
       mov       r11,7FFC68571230
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L07:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFC68571210
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68571218
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-20]
       mov       r11,7FFC68571220
       call      qword ptr [r11]
       add       rdi,1
       jo        short M00_L09
       jmp       short M00_L08
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-20]
       mov       r11,7FFC68571228
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L12
       mov       rcx,[rbp-20]
       mov       r11,7FFC68571228
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 353
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,2AA85C00A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L26
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L24
       inc       edi
       cmp       edi,r14d
       jl        short M00_L02
M00_L03:
       xor       edi,edi
M00_L04:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rbx+14]
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r14d
       mov       [r15+1C],ecx
M00_L06:
       mov       [rbp-30],r15
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L11
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L11
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L11
M00_L07:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L10
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L09
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L08:
       test      r15d,r15d
       je        short M00_L07
       jmp       near ptr M00_L21
M00_L09:
       xor       r15d,r15d
       jmp       short M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L11:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       je        short M00_L12
       mov       r11,7FFC68580B48
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L30
M00_L12:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L13
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L13:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L20
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L15
       jmp       short M00_L16
M00_L14:
       mov       rcx,[rbp-30]
       mov       r11,7FFC68580B50
       call      qword ptr [r11]
       mov       rdx,rax
M00_L15:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L18
M00_L16:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L17
       xor       r15d,r15d
       jmp       short M00_L18
M00_L17:
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L18:
       test      r15d,r15d
       je        near ptr M00_L11
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFC6885C150]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L31
M00_L22:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L23:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L24:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2AA85C00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68636BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AA85C00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FFC68857A20]
       int       3
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2AA85C00A28
       mov       r15,[rcx]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68580B60
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFC68580B40
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L30:
       call      M00_L33
       jmp       near ptr M00_L03
M00_L31:
       mov       r11,7FFC68580B58
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L32:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L34
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L34
       mov       r11,7FFC68580B58
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1003
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DFDB18]
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
       jmp       qword ptr [7FFC68635C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1D080800A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L26
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L24
       inc       edi
       cmp       edi,r14d
       jl        short M00_L02
M00_L03:
       xor       edi,edi
M00_L04:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rbx+14]
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r14d
       mov       [r15+1C],ecx
M00_L06:
       mov       [rbp-30],r15
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L11
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L11
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L11
M00_L07:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L10
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L09
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L08:
       test      r15d,r15d
       je        short M00_L07
       jmp       near ptr M00_L21
M00_L09:
       xor       r15d,r15d
       jmp       short M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L11:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       je        short M00_L12
       mov       r11,7FFC68580B48
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L30
M00_L12:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L13
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L13:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L20
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L15
       jmp       short M00_L16
M00_L14:
       mov       rcx,[rbp-30]
       mov       r11,7FFC68580B50
       call      qword ptr [r11]
       mov       rdx,rax
M00_L15:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L18
M00_L16:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L17
       xor       r15d,r15d
       jmp       short M00_L18
M00_L17:
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L18:
       test      r15d,r15d
       je        near ptr M00_L11
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFC6885C150]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L31
M00_L22:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L23:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L24:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D080800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68636BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D080800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FFC68857A20]
       int       3
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D080800A28
       mov       r15,[rcx]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68580B60
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFC68580B40
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L30:
       call      M00_L33
       jmp       near ptr M00_L03
M00_L31:
       mov       r11,7FFC68580B58
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L32:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L34
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L34
       mov       r11,7FFC68580B58
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1003
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DFD050]
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
       jmp       qword ptr [7FFC68635C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1F1E2800A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L31
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
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
       jne       near ptr M00_L23
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L28
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L27
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L26
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+14]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],edi
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L10
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-30]
       cmp       [rcx],r15
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L07:
       lea       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,rdx
       mov       r8d,[rbx+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L17
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L19
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L18
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L08:
       test      r14d,r14d
       je        short M00_L07
       jmp       near ptr M00_L20
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L08
M00_L10:
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-30]
       cmp       [rcx],r15
       je        short M00_L11
       mov       r11,7FFC68550B48
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L12
       jmp       near ptr M00_L29
M00_L11:
       lea       rbx,[rcx+8]
       mov       rax,[rbx]
       mov       edx,[rbx+10]
       mov       r8,[rbx]
       cmp       edx,[r8+14]
       jne       near ptr M00_L17
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L19
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L18
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L13
       jmp       short M00_L14
M00_L12:
       mov       rcx,[rbp-30]
       mov       r11,7FFC68550B50
       call      qword ptr [r11]
       mov       rdx,rax
M00_L13:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L16
M00_L14:
       mov       rdi,[rdx+30]
       test      rdi,rdi
       jne       short M00_L15
       xor       r14d,r14d
       jmp       short M00_L16
M00_L15:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L16:
       test      r14d,r14d
       je        near ptr M00_L10
       jmp       short M00_L20
M00_L17:
       call      qword ptr [7FFC6882C150]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L29
M00_L20:
       cmp       [rcx],r15
       jne       near ptr M00_L30
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L23:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F1E2800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68606BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F1E2800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFC68827A20]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68605728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F1E2800A28
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFC68550B60
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68550B40
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L29:
       call      M00_L32
       jmp       near ptr M00_L03
M00_L30:
       mov       r11,7FFC68550B58
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L33
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-30]
       cmp       [rcx],r15
       je        short M00_L33
       mov       r11,7FFC68550B58
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 966
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DCD5F0]
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
       jmp       qword ptr [7FFC68605C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1F705C00A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L26
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L24
       inc       edi
       cmp       edi,r14d
       jl        short M00_L02
M00_L03:
       xor       edi,edi
M00_L04:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rbx+14]
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r14d
       mov       [r15+1C],ecx
M00_L06:
       mov       [rbp-30],r15
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L11
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L11
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L11
M00_L07:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L10
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L09
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L08:
       test      r15d,r15d
       je        short M00_L07
       jmp       near ptr M00_L21
M00_L09:
       xor       r15d,r15d
       jmp       short M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L11:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       je        short M00_L12
       mov       r11,7FFC68570DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L30
M00_L12:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L13
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L13:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L20
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L15
       jmp       short M00_L16
M00_L14:
       mov       rcx,[rbp-30]
       mov       r11,7FFC68570DA8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L15:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L18
M00_L16:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L17
       xor       r15d,r15d
       jmp       short M00_L18
M00_L17:
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L18:
       test      r15d,r15d
       je        near ptr M00_L11
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFC6884C150]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L31
M00_L22:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L23:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L24:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F705C00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68626BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F705C00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FFC68847A20]
       int       3
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F705C00A30
       mov       r15,[rcx]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68570DB8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFC68570D98
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L30:
       call      M00_L33
       jmp       near ptr M00_L03
M00_L31:
       mov       r11,7FFC68570DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L32:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L34
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L34
       mov       r11,7FFC68570DB0
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DE7228]
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
       jmp       qword ptr [7FFC68625C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,293F7C02A08
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L26
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L24
       inc       edi
       cmp       edi,r14d
       jl        short M00_L02
M00_L03:
       xor       edi,edi
M00_L04:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rbx+14]
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r14d
       mov       [r15+1C],ecx
M00_L06:
       mov       [rbp-30],r15
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L11
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L11
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L11
M00_L07:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L10
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L09
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L08:
       test      r15d,r15d
       je        short M00_L07
       jmp       near ptr M00_L21
M00_L09:
       xor       r15d,r15d
       jmp       short M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L11:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       je        short M00_L12
       mov       r11,7FFC68560B48
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L30
M00_L12:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L13
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L13:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L20
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L15
       jmp       short M00_L16
M00_L14:
       mov       rcx,[rbp-30]
       mov       r11,7FFC68560B50
       call      qword ptr [r11]
       mov       rdx,rax
M00_L15:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L18
M00_L16:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L17
       xor       r15d,r15d
       jmp       short M00_L18
M00_L17:
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L18:
       test      r15d,r15d
       je        near ptr M00_L11
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFC6883C150]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L31
M00_L22:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L23:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L24:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,293F7C02A00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68616BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,293F7C02A08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FFC68837A20]
       int       3
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68615728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,293F7C02A20
       mov       r15,[rcx]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68560B60
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFC68560B40
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L30:
       call      M00_L33
       jmp       near ptr M00_L03
M00_L31:
       mov       r11,7FFC68560B58
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L32:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L34
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L34
       mov       r11,7FFC68560B58
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1003
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DDDAA0]
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
       jmp       qword ptr [7FFC68615C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,2E45E000A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L26
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L24
       inc       edi
       cmp       edi,r14d
       jl        short M00_L02
M00_L03:
       xor       edi,edi
M00_L04:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rbx+14]
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r14d
       mov       [r15+1C],ecx
M00_L06:
       mov       [rbp-30],r15
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L11
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L11
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L11
M00_L07:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L10
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L09
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L08:
       test      r15d,r15d
       je        short M00_L07
       jmp       near ptr M00_L21
M00_L09:
       xor       r15d,r15d
       jmp       short M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L11:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       je        short M00_L12
       mov       r11,7FFC68560DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L30
M00_L12:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L19
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L13
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L13:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L20
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L15
       jmp       short M00_L16
M00_L14:
       mov       rcx,[rbp-30]
       mov       r11,7FFC68560DA8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L15:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L18
M00_L16:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L17
       xor       r15d,r15d
       jmp       short M00_L18
M00_L17:
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L18:
       test      r15d,r15d
       je        near ptr M00_L11
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFC6883C150]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L31
M00_L22:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L23:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L24:
       mov       edi,1
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2E45E000A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68616BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2E45E000A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FFC68837A20]
       int       3
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2E45E000A30
       mov       r15,[rcx]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68560DB8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFC68560D98
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L06
M00_L30:
       call      M00_L33
       jmp       near ptr M00_L03
M00_L31:
       mov       r11,7FFC68560DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L32:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L34
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L34
       mov       r11,7FFC68560DB0
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DD7228]
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
       jmp       qword ptr [7FFC68615C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,219CBC00A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L20
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L02
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        short M00_L01
       add       r15,10
       jmp       near ptr M00_L21
M00_L01:
       call      qword ptr [7FFC68837A20]
       int       3
M00_L02:
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rbx+14]
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r14d
       mov       [r15+1C],ecx
M00_L03:
       mov       [rbp-30],r15
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-30]
       cmp       [r15],rcx
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L04:
       lea       rbx,[r15+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       short M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rdx,[r15+10]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        short M00_L06
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L05:
       test      r14d,r14d
       je        short M00_L04
       jmp       near ptr M00_L18
M00_L06:
       xor       r14d,r14d
       jmp       short M00_L05
M00_L07:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-30]
       cmp       [r15],rcx
       je        short M00_L09
       mov       rcx,r15
       mov       r11,7FFC68560EF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L30
M00_L09:
       lea       rbx,[r15+8]
       mov       rax,[rbx]
       mov       ecx,[rbx+10]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+14]
       jne       near ptr M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L10
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L30
M00_L10:
       mov       rcx,[rax+8]
       cmp       r8d,[rcx+8]
       jae       short M00_L17
       mov       edx,r8d
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rdx,[r15+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L12
       jmp       short M00_L13
M00_L11:
       mov       rcx,r15
       mov       r11,7FFC68560EF8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L12:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       jmp       short M00_L15
M00_L13:
       mov       rdi,[rdx+30]
       test      rdi,rdi
       jne       short M00_L14
       xor       r14d,r14d
       jmp       short M00_L15
M00_L14:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L15:
       test      r14d,r14d
       je        near ptr M00_L08
       jmp       short M00_L18
M00_L16:
       call      qword ptr [7FFC6883C150]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r15],rcx
       jne       near ptr M00_L31
M00_L19:
       mov       ebx,1
       jmp       short M00_L24
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
M00_L21:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L23
M00_L22:
       mov       rdx,[r15+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L25
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L22
M00_L23:
       xor       ebx,ebx
M00_L24:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L25:
       mov       ebx,1
       jmp       short M00_L24
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,219CBC00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68616BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,219CBC00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,219CBC00AE8
       mov       r15,[rcx]
       jmp       near ptr M00_L03
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFC68560F08
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFC68560EE8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L30:
       call      M00_L33
       jmp       near ptr M00_L23
M00_L31:
       mov       rcx,r15
       mov       r11,7FFC68560F00
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L32:
       xor       ebx,ebx
       jmp       near ptr M00_L24
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L34
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L34
       mov       rcx,rax
       mov       r11,7FFC68560F00
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 962
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68DCCC18]
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
       jmp       qword ptr [7FFC68615C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1E86D800AA0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L29
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L02
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L01
       add       r14,10
       jmp       near ptr M00_L21
M00_L01:
       call      qword ptr [7FFC68837A20]
       int       3
M00_L02:
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L27
       mov       rcx,[rbx+8]
       mov       r11,7FFC68561230
       call      qword ptr [r11]
       mov       rcx,rax
M00_L03:
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-28]
       cmp       [rax],rcx
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L04:
       lea       rbx,[rax+8]
       mov       rcx,[rbx]
       mov       r8,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L15
       mov       r10d,[rbx+14]
       cmp       r10d,[r8+10]
       jae       short M00_L06
       mov       rsi,[r8+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L16
       mov       ecx,r10d
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rbp-28]
       mov       rdx,[rax+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L07
       cmp       dword ptr [r14+8],0
       setg      dil
       movzx     edi,dil
M00_L05:
       test      edi,edi
       je        short M00_L04
       jmp       near ptr M00_L17
M00_L06:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L19
M00_L07:
       xor       edi,edi
       jmp       short M00_L05
M00_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-28]
       cmp       [rax],rcx
       je        short M00_L09
       mov       rcx,rax
       mov       r11,7FFC68561218
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L19
M00_L09:
       lea       rbx,[rax+8]
       mov       r8,[rbx]
       mov       ecx,[rbx+10]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+14]
       jne       near ptr M00_L15
       mov       r10d,[rbx+14]
       cmp       r10d,[r8+10]
       jae       short M00_L06
       mov       rcx,[r8+8]
       cmp       r10d,[rcx+8]
       jae       near ptr M00_L16
       mov       edx,r10d
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rbp-28]
       mov       rdx,[rax+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
       jmp       short M00_L12
M00_L10:
       mov       rcx,[rbp-28]
       mov       r11,7FFC68561220
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edi,eax
       mov       rax,[rbp-28]
       jmp       short M00_L14
M00_L12:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L13
       xor       edi,edi
       jmp       short M00_L14
M00_L13:
       cmp       dword ptr [r14+8],0
       setg      dil
       movzx     edi,dil
M00_L14:
       test      edi,edi
       je        near ptr M00_L08
       jmp       short M00_L17
M00_L15:
       call      qword ptr [7FFC6883C150]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rax],rcx
       jne       near ptr M00_L28
M00_L18:
       mov       ebx,1
       jmp       short M00_L24
M00_L19:
       call      M00_L30
       jmp       short M00_L23
M00_L20:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L21:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L23
M00_L22:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L25
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L22
M00_L23:
       xor       ebx,ebx
M00_L24:
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
M00_L25:
       mov       ebx,1
       jmp       short M00_L24
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E86D800A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFC68616BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E86D800AA0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFC68561210
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L28:
       mov       rcx,rax
       mov       r11,7FFC68561228
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L29:
       xor       ebx,ebx
       jmp       near ptr M00_L24
M00_L30:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L31
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-28]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFC68561228
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 839
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 24
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
       call      qword ptr [7FFC68CEE388]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68580B10
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68570B10
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68550B10
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68580B70
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68580B10
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68560B10
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC68560D50
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setg      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC685611D8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

