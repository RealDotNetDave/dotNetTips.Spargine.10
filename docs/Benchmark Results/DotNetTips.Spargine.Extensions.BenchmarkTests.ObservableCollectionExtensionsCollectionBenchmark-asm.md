## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C4E10E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C4E10E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C4E10D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10D0
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C5010E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C5010E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C5010D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C5010C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5010C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5010D0
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5010D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C5110E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C5110E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C5110D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C5110C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5110C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5110D0
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5110D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C4E10E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C4E10E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C4E10D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10D0
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C4F10E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C4F10E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C4F10D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C4F10C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4F10C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4F10D0
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4F10D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C4E10E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C4E10E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C4E10D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10D0
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C4E10D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C5013D0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C5013C8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C5013C0
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C5013A8
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5013B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5013B8
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C5013B8
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,rcx
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L04
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       esi,[rcx+10]
M00_L00:
       movsxd    rsi,esi
M00_L01:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L03:
       mov       r11,7FF94C501778
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FF94C501770
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF94C501768
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FF94C501750
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C501758
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       add       esi,1
       jo        short M00_L08
       jmp       short M00_L07
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       mov       rcx,[rbp-18]
       mov       r11,7FF94C501760
       call      qword ptr [r11]
       movsxd    rsi,esi
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L02
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L11
       mov       rcx,[rbp-18]
       mov       r11,7FF94C501760
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,16C8D000AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L18
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L23
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L20
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L04
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L06
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L03:
       test      r15d,r15d
       je        short M00_L02
       jmp       near ptr M00_L15
M00_L04:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L08
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L14
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L11
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L12
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L05:
       test      r15d,r15d
       je        near ptr M00_L04
       jmp       short M00_L15
M00_L06:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L07:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L08:
       mov       r11,7FF94C5110B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L21
M00_L09:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L10:
       mov       rcx,[rbp-30]
       mov       r11,7FF94C5110B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L05
M00_L12:
       xor       r15d,r15d
       jmp       short M00_L05
M00_L13:
       call      qword ptr [7FF94C84C0D8]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L22
M00_L16:
       mov       esi,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,16C8D000AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16C8D000AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16C8D000C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,rbx
       mov       r11,7FF94C5110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L21:
       call      M00_L24
       jmp       short M00_L23
M00_L22:
       mov       r11,7FF94C5110C0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       esi,esi
       jmp       near ptr M00_L17
M00_L24:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L25
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L25
       mov       r11,7FF94C5110C0
       call      qword ptr [r11]
M00_L25:
       nop
       add       rsp,28
       ret
; Total bytes of code 856
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CEF5200]
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
       jmp       qword ptr [7FF94C5C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rbx,[rcx+270]
       mov       rax,24C30C00AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L16
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L21
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L18
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L04
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       r14,[rcx+8]
       mov       rdx,[r14]
       mov       rax,rdx
       mov       r8d,[r14+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L10
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+30]
       test      r15,r15
       je        near ptr M00_L06
       cmp       dword ptr [r15+8],0
       setg      r13b
       movzx     r13d,r13b
M00_L03:
       test      r13d,r13d
       je        short M00_L02
       jmp       near ptr M00_L13
M00_L04:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L07
       lea       r14,[rcx+8]
       mov       rax,[r14]
       mov       edx,[r14+10]
       mov       r8,[r14]
       cmp       edx,[r8+14]
       jne       near ptr M00_L10
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L11
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       mov       r15,[rdx+30]
       test      r15,r15
       je        short M00_L09
       cmp       dword ptr [r15+8],0
       setg      r13b
       movzx     r13d,r13b
M00_L05:
       test      r13d,r13d
       je        near ptr M00_L04
       jmp       short M00_L13
M00_L06:
       xor       r13d,r13d
       jmp       near ptr M00_L03
M00_L07:
       mov       r11,7FF94C4E10B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L19
       mov       rcx,[rbp-38]
       mov       r11,7FF94C4E10B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r13d,eax
       mov       rcx,[rbp-38]
       jmp       short M00_L05
M00_L09:
       xor       r13d,r13d
       jmp       short M00_L05
M00_L10:
       call      qword ptr [7FF94C81C0D8]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L19
M00_L13:
       cmp       rbx,rdi
       jne       near ptr M00_L20
M00_L14:
       mov       esi,1
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24C30C00AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24C30C00AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24C30C00C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L18:
       mov       rcx,rbx
       mov       r11,7FF94C4E10C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L19:
       call      M00_L22
       jmp       short M00_L21
M00_L20:
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L21:
       xor       esi,esi
       jmp       near ptr M00_L15
M00_L22:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L23
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L23
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
M00_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 831
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CEC5218]
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
       jmp       qword ptr [7FF94C595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rbx,[rcx+270]
       mov       rax,2B988C02AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L16
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L21
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L18
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L04
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       r14,[rcx+8]
       mov       rdx,[r14]
       mov       rax,rdx
       mov       r8d,[r14+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L10
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+30]
       test      r15,r15
       je        near ptr M00_L06
       cmp       dword ptr [r15+8],0
       setg      r13b
       movzx     r13d,r13b
M00_L03:
       test      r13d,r13d
       je        short M00_L02
       jmp       near ptr M00_L13
M00_L04:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L07
       lea       r14,[rcx+8]
       mov       rax,[r14]
       mov       edx,[r14+10]
       mov       r8,[r14]
       cmp       edx,[r8+14]
       jne       near ptr M00_L10
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L11
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       mov       r15,[rdx+30]
       test      r15,r15
       je        short M00_L09
       cmp       dword ptr [r15+8],0
       setg      r13b
       movzx     r13d,r13b
M00_L05:
       test      r13d,r13d
       je        near ptr M00_L04
       jmp       short M00_L13
M00_L06:
       xor       r13d,r13d
       jmp       near ptr M00_L03
M00_L07:
       mov       r11,7FF94C5110B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L19
       mov       rcx,[rbp-38]
       mov       r11,7FF94C5110B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r13d,eax
       mov       rcx,[rbp-38]
       jmp       short M00_L05
M00_L09:
       xor       r13d,r13d
       jmp       short M00_L05
M00_L10:
       call      qword ptr [7FF94C84C0D8]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L19
M00_L13:
       cmp       rbx,rdi
       jne       near ptr M00_L20
M00_L14:
       mov       esi,1
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2B988C02AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B988C02AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B988C02C18
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L18:
       mov       rcx,rbx
       mov       r11,7FF94C5110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L19:
       call      M00_L22
       jmp       short M00_L21
M00_L20:
       mov       r11,7FF94C5110C0
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L21:
       xor       esi,esi
       jmp       near ptr M00_L15
M00_L22:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L23
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L23
       mov       r11,7FF94C5110C0
       call      qword ptr [r11]
M00_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 831
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CEF52A8]
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
       jmp       qword ptr [7FF94C5C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1B251002AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L18
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L23
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L20
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L04
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L06
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L03:
       test      r15d,r15d
       je        short M00_L02
       jmp       near ptr M00_L15
M00_L04:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L08
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L14
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L11
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L12
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L05:
       test      r15d,r15d
       je        near ptr M00_L04
       jmp       short M00_L15
M00_L06:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L07:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L08:
       mov       r11,7FF94C4E10B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L21
M00_L09:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L10:
       mov       rcx,[rbp-30]
       mov       r11,7FF94C4E10B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L05
M00_L12:
       xor       r15d,r15d
       jmp       short M00_L05
M00_L13:
       call      qword ptr [7FF94C81C0D8]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L22
M00_L16:
       mov       esi,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1B251002AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B251002AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B251002C18
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,rbx
       mov       r11,7FF94C4E10C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L21:
       call      M00_L24
       jmp       short M00_L23
M00_L22:
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       esi,esi
       jmp       near ptr M00_L17
M00_L24:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L25
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L25
       mov       r11,7FF94C4E10C0
       call      qword ptr [r11]
M00_L25:
       nop
       add       rsp,28
       ret
; Total bytes of code 856
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CEC5230]
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
       jmp       qword ptr [7FF94C595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1F943400AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L18
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L23
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L20
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L04
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L06
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L03:
       test      r15d,r15d
       je        short M00_L02
       jmp       near ptr M00_L15
M00_L04:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L08
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L14
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L11
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L12
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L05:
       test      r15d,r15d
       je        near ptr M00_L04
       jmp       short M00_L15
M00_L06:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L07:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L08:
       mov       r11,7FF94C5010B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L21
M00_L09:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L10:
       mov       rcx,[rbp-30]
       mov       r11,7FF94C5010B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L05
M00_L12:
       xor       r15d,r15d
       jmp       short M00_L05
M00_L13:
       call      qword ptr [7FF94C83C0D8]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L22
M00_L16:
       mov       esi,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F943400AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F943400AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F943400C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,rbx
       mov       r11,7FF94C5010C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L21:
       call      M00_L24
       jmp       short M00_L23
M00_L22:
       mov       r11,7FF94C5010C0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       esi,esi
       jmp       near ptr M00_L17
M00_L24:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L25
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L25
       mov       r11,7FF94C5010C0
       call      qword ptr [r11]
M00_L25:
       nop
       add       rsp,28
       ret
; Total bytes of code 856
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CEE5278]
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
       jmp       qword ptr [7FF94C5B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1D58F800AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L18
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L23
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L20
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L04
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L06
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L03:
       test      r15d,r15d
       je        short M00_L02
       jmp       near ptr M00_L15
M00_L04:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L08
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L14
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L11
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L12
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L05:
       test      r15d,r15d
       je        near ptr M00_L04
       jmp       short M00_L15
M00_L06:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L07:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L08:
       mov       r11,7FF94C5010B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L21
M00_L09:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L10:
       mov       rcx,[rbp-30]
       mov       r11,7FF94C5010B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L05
M00_L12:
       xor       r15d,r15d
       jmp       short M00_L05
M00_L13:
       call      qword ptr [7FF94C83C0D8]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L22
M00_L16:
       mov       esi,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D58F800AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D58F800AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D58F800C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,rbx
       mov       r11,7FF94C5010C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L21:
       call      M00_L24
       jmp       short M00_L23
M00_L22:
       mov       r11,7FF94C5010C0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       esi,esi
       jmp       near ptr M00_L17
M00_L24:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L25
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L25
       mov       r11,7FF94C5010C0
       call      qword ptr [r11]
M00_L25:
       nop
       add       rsp,28
       ret
; Total bytes of code 856
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CEE5290]
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
       jmp       qword ptr [7FF94C5B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,2058BC00AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L18
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L23
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L20
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L01:
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L04
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L04
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L06
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L03:
       test      r15d,r15d
       je        short M00_L02
       jmp       near ptr M00_L15
M00_L04:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L08
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L14
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L11
       mov       r14,[rdx+30]
       test      r14,r14
       je        near ptr M00_L12
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L05:
       test      r15d,r15d
       je        near ptr M00_L04
       jmp       short M00_L15
M00_L06:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L07:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L08:
       mov       r11,7FF94C4F1308
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L21
M00_L09:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L10:
       mov       rcx,[rbp-30]
       mov       r11,7FF94C4F1310
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rcx,[rbp-30]
       jmp       short M00_L05
M00_L12:
       xor       r15d,r15d
       jmp       short M00_L05
M00_L13:
       call      qword ptr [7FF94C82C0D8]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L22
M00_L16:
       mov       esi,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2058BC00AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2058BC00AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2058BC00C48
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,rbx
       mov       r11,7FF94C4F1320
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L21:
       call      M00_L24
       jmp       short M00_L23
M00_L22:
       mov       r11,7FF94C4F1318
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       esi,esi
       jmp       near ptr M00_L17
M00_L24:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L25
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L25
       mov       r11,7FF94C4F1318
       call      qword ptr [r11]
M00_L25:
       nop
       add       rsp,28
       ret
; Total bytes of code 856
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CED5290]
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
       jmp       qword ptr [7FF94C5A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,22D01C00B90
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L20
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L19
       mov       rcx,[rbx+8]
       mov       r11,7FF94C501758
       call      qword ptr [r11]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L03
       mov       rax,[rbp-30]
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rcx
       jne       near ptr M00_L03
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L03
M00_L01:
       lea       rdi,[rax+8]
       mov       rcx,[rdi]
       mov       r8,rcx
       mov       edx,[rdi+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L13
       mov       r10d,[rdi+14]
       cmp       r10d,[r8+10]
       jae       near ptr M00_L04
       mov       rsi,[r8+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L14
       mov       ecx,r10d
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rax,[rbp-30]
       mov       rdx,[rax+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L05
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L02:
       test      r15d,r15d
       je        short M00_L01
       jmp       near ptr M00_L15
M00_L03:
       mov       rax,[rbp-30]
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rcx
       jne       short M00_L06
       lea       rdi,[rax+8]
       mov       r8,[rdi]
       mov       ecx,[rdi+10]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+14]
       jne       near ptr M00_L13
       mov       r10d,[rdi+14]
       cmp       r10d,[r8+10]
       jb        short M00_L07
M00_L04:
       mov       rax,[rbp-30]
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L18
M00_L05:
       xor       r15d,r15d
       jmp       short M00_L02
M00_L06:
       mov       rcx,rax
       mov       r11,7FF94C501740
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L18
M00_L07:
       mov       rcx,[r8+8]
       cmp       r10d,[rcx+8]
       jae       near ptr M00_L14
       mov       edx,r10d
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rax,[rbp-30]
       mov       rdx,[rax+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L09
       jmp       short M00_L10
M00_L08:
       mov       rcx,[rbp-30]
       mov       r11,7FF94C501748
       call      qword ptr [r11]
       mov       rdx,rax
M00_L09:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r15d,eax
       mov       rax,[rbp-30]
       jmp       short M00_L12
M00_L10:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
       xor       r15d,r15d
       jmp       short M00_L12
M00_L11:
       cmp       dword ptr [r14+8],0
       setg      r15b
       movzx     r15d,r15b
M00_L12:
       test      r15d,r15d
       je        near ptr M00_L03
       jmp       short M00_L15
M00_L13:
       call      qword ptr [7FF94C83C0D8]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rcx
       jne       short M00_L21
M00_L16:
       mov       esi,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rax,[rbp-30]
       call      M00_L22
       nop
M00_L19:
       xor       esi,esi
       jmp       short M00_L17
M00_L20:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22D01C00B88
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22D01C00B90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,rax
       mov       r11,7FF94C501750
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L23
       mov       rax,[rbp-30]
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rcx
       je        short M00_L23
       mov       rcx,rax
       mov       r11,7FF94C501750
       call      qword ptr [r11]
M00_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 704
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF94CD27BD0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4E1118
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C511088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C511088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C501088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4E1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C511088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4E1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       sete      al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4F1710
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4F1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4F1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C511088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4F1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4E1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4F1088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C4F1340
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94C511710
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

