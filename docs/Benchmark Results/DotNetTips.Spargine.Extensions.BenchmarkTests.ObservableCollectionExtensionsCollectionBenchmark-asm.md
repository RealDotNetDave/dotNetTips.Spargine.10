## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD910E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD910E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD910D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD910C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD910C8
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
       mov       r11,7FFF7FD910D0
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
       mov       r11,7FFF7FD910D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD710E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD710E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD710D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD710C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD710C8
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
       mov       r11,7FFF7FD710D0
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
       mov       r11,7FFF7FD710D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD610E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD610E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD610D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD610C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD610C8
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
       mov       r11,7FFF7FD610D0
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
       mov       r11,7FFF7FD610D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD710E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD710E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD710D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD710C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD710C8
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
       mov       r11,7FFF7FD710D0
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
       mov       r11,7FFF7FD710D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD610E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD610E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD610D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD610C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD610C8
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
       mov       r11,7FFF7FD610D0
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
       mov       r11,7FFF7FD610D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD910E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD910E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD910D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD910C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD910C8
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
       mov       r11,7FFF7FD910D0
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
       mov       r11,7FFF7FD910D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD91488
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD91480
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD91478
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD91460
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD91468
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
       mov       r11,7FFF7FD91470
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
       mov       r11,7FFF7FD91470
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD716E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rax
       mov       r11,7FFF7FD716E0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L05:
       mov       rax,rcx
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FFF7FD716D8
       call      qword ptr [r11]
       movsxd    rsi,eax
       jmp       short M00_L01
M00_L06:
       xor       esi,esi
       mov       r11,7FFF7FD716C0
       call      qword ptr [r11]
       mov       [rbp-18],rax
M00_L07:
       mov       rcx,[rbp-18]
       mov       r11,7FFF7FD716C8
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
       mov       r11,7FFF7FD716D0
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
       mov       r11,7FFF7FD716D0
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,198A9C00AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD810C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD810C8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF800BC0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L24
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L16
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,198A9C00AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,198A9C00AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFF800B79A8]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,198A9C00C10
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD810D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD810B8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L29:
       mov       r11,7FFF7FD810D0
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD810D0
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 964
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF80825230]
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
       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1BD48000AE0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD60CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD60D00
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF8009C0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L24
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L16
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1BD48000AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BD48000AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFF800979A8]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFF7FE15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BD32001FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD60D10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD60CF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L29:
       mov       r11,7FFF7FD60D08
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD60D08
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 965
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF808155C0]
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
       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1D173400AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD710D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD710E0
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF800AC0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L24
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L16
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D173400AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D173400AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFF800A79A8]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D173400C10
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD710F0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD710D0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L29:
       mov       r11,7FFF7FD710E8
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD710E8
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 964
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF808151D0]
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
       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1C3A4000AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD910C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD910C8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF800CC0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L24
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L16
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C3A4000AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C3A4000AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFF800C79A8]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C3A4000C10
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD910D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD910B8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L29:
       mov       r11,7FFF7FD910D0
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD910D0
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 964
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF80834DB0]
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
       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,20B95802AC0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD710C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD710C8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF800AC0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L24
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L16
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20B95802AB8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20B95802AC0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFF800A79A8]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20B95802C08
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD710D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD710B8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L29:
       mov       r11,7FFF7FD710D0
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD710D0
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 964
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF808151D0]
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
       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,2C118800AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD810D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD810E0
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF800BC0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L24
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L16
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2C118800AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C118800AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFF800B79A8]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C118800C10
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD810F0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD810D0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L29:
       mov       r11,7FFF7FD810E8
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD810E8
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 964
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF80825248]
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
       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,12752402AE0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rax,rdx
       je        near ptr M00_L19
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       je        near ptr M00_L17
       mov       r8,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,r8
       jne       near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rdx
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
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
       mov       [rbp-28],rdi
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L10
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L14
M00_L03:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L04:
       mov       r11,7FFF7FD913D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L28
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L06:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
       jmp       short M00_L09
M00_L07:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD913D8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L11
M00_L10:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L11:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L10
       jmp       short M00_L14
M00_L12:
       call      qword ptr [7FFF800CC0D8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L29
M00_L15:
       mov       edi,1
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L18
       add       r14,10
       jmp       short M00_L20
M00_L18:
       call      qword ptr [7FFF800C79A8]
       int       3
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L22
M00_L21:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
M00_L22:
       xor       edi,edi
       jmp       short M00_L16
M00_L23:
       mov       edi,1
       jmp       short M00_L16
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,12752402AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,12752402AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,12752402C30
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFF7FD913E8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFF7FD913C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L22
M00_L29:
       mov       r11,7FFF7FD913E0
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L30:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L32
       mov       rcx,[rbp-28]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FFF7FD913E0
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 960
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF8076C678]
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
       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1AEC7C02B60
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L27
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       mov       r11,7FFF7FD91770
       call      qword ptr [r11]
       mov       rcx,rax
M00_L01:
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-28],0
       je        near ptr M00_L09
       mov       rbx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-28]
       cmp       [rcx],rbx
       jne       near ptr M00_L09
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L09
M00_L02:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L11
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L12
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+30]
       test      r14,r14
       je        short M00_L02
       mov       edx,[r14+8]
       test      edx,edx
       je        short M00_L02
       jmp       near ptr M00_L13
M00_L03:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L15
M00_L04:
       mov       r11,7FFF7FD91758
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L05:
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L11
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L03
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L12
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-28]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L07
       jmp       short M00_L08
M00_L06:
       mov       rcx,[rbp-28]
       mov       r11,7FFF7FD91760
       call      qword ptr [r11]
       mov       rdx,rax
M00_L07:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L09
       jmp       short M00_L13
M00_L08:
       mov       r14,[rdx+30]
       test      r14,r14
       jne       short M00_L10
M00_L09:
       mov       rbx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-28]
       cmp       [rcx],rbx
       jne       near ptr M00_L04
       jmp       near ptr M00_L05
M00_L10:
       mov       r11d,[r14+8]
       test      r11d,r11d
       je        short M00_L09
       jmp       short M00_L13
M00_L11:
       call      qword ptr [7FFF800CC0D8]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,[rbp-28]
       cmp       [rcx],rbx
       jne       near ptr M00_L26
M00_L14:
       mov       edi,1
       jmp       short M00_L22
M00_L15:
       call      M00_L28
       jmp       short M00_L21
M00_L16:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L17
       add       r14,10
       jmp       short M00_L19
M00_L17:
       call      qword ptr [7FFF800C79A8]
       int       3
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L23:
       mov       edi,1
       jmp       short M00_L22
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1AEC7C02B58
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AEC7C02B60
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFF7FD91750
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       r11,7FFF7FD91768
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L27:
       xor       edi,edi
       jmp       near ptr M00_L22
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L29
       mov       rbx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-28]
       cmp       [rcx],rbx
       je        short M00_L29
       mov       r11,7FFF7FD91768
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 810
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       setne     al
       movzx     eax,al
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 23
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
       call      qword ptr [7FFF80677C48]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD61078
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD70CC0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD91088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD80CC0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FDA0D20
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD80CC0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD61370
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD61708
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD71088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD81088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD81088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD91088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD91088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD71088
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD81370
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       r11,7FFF7FD81718
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

