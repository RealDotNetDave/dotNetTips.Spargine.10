## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L17
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L15
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L14
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L13
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       short M00_L02
M00_L01:
       lea       rdi,[r14+8]
       mov       rcx,[rdi]
       mov       rax,rcx
       mov       edx,[rdi+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L07
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L05
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L08
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       add       rsi,1
       jo        near ptr M00_L09
       jmp       short M00_L01
M00_L02:
       mov       r14,[rbp-30]
       cmp       [r14],r14d
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rcx
       jne       short M00_L06
       lea       rdi,[r14+8]
       mov       rcx,[rdi]
       mov       rax,rcx
       mov       edx,[rdi+10]
       cmp       edx,[rcx+14]
       jne       short M00_L07
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L05
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       short M00_L08
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
M00_L04:
       add       rsi,1
       jo        short M00_L09
       jmp       short M00_L03
M00_L05:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L10
M00_L06:
       mov       rcx,r14
       mov       r11,7FFB6D230F78
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFB6D50C9C0]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rcx
       jne       short M00_L16
M00_L11:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L12:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C647802008
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFB6D230F88
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFB6D230F70
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,r14
       mov       r11,7FFB6D230F80
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L17:
       xor       eax,eax
       jmp       short M00_L12
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L18
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       je        short M00_L18
       mov       rcx,r14
       mov       r11,7FFB6D230F80
       call      qword ptr [r11]
M00_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 591
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L17
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L15
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L14
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-38],r14
       cmp       qword ptr [rbp-38],0
       je        short M00_L02
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       short M00_L02
       nop       dword ptr [rax]
M00_L01:
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L07
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L05
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       near ptr M00_L08
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
       add       rsi,1
       jo        near ptr M00_L09
       jmp       short M00_L01
M00_L02:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
M00_L03:
       cmp       [rdi],r14
       jne       short M00_L06
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       short M00_L07
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       short M00_L05
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       short M00_L08
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       add       rsi,1
       jo        short M00_L09
       jmp       short M00_L03
M00_L05:
       xor       eax,eax
       mov       [r15+8],rax
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M00_L10
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFB6D250F18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       cmp       [rdi],r14
       jne       short M00_L16
M00_L11:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L12:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AF6B801FF8
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFB6D250F10
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L17:
       xor       eax,eax
       jmp       short M00_L12
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L18
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
M00_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 599
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L17
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L15
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L14
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-38],r14
       cmp       qword ptr [rbp-38],0
       je        short M00_L02
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       short M00_L02
       nop       dword ptr [rax]
M00_L01:
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L07
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L05
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       near ptr M00_L08
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
       add       rsi,1
       jo        near ptr M00_L09
       jmp       short M00_L01
M00_L02:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
M00_L03:
       cmp       [rdi],r14
       jne       short M00_L06
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       short M00_L07
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       short M00_L05
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       short M00_L08
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       add       rsi,1
       jo        short M00_L09
       jmp       short M00_L03
M00_L05:
       xor       eax,eax
       mov       [r15+8],rax
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M00_L10
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFB6D250C90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       cmp       [rdi],r14
       jne       short M00_L16
M00_L11:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L12:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24634401FB8
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFB6D250CA0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFB6D250C88
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFB6D250C98
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L17:
       xor       eax,eax
       jmp       short M00_L12
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L18
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFB6D250C98
       call      qword ptr [r11]
M00_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 599
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L17
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L15
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L14
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-38],r14
       cmp       qword ptr [rbp-38],0
       je        short M00_L02
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       short M00_L02
       nop       dword ptr [rax]
M00_L01:
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L07
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L05
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       near ptr M00_L08
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
       add       rsi,1
       jo        near ptr M00_L09
       jmp       short M00_L01
M00_L02:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
M00_L03:
       cmp       [rdi],r14
       jne       short M00_L06
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       short M00_L07
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       short M00_L05
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       short M00_L08
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       add       rsi,1
       jo        short M00_L09
       jmp       short M00_L03
M00_L05:
       xor       eax,eax
       mov       [r15+8],rax
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M00_L10
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFB6D260F10
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       cmp       [rdi],r14
       jne       short M00_L16
M00_L11:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L12:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15CE9C01FF8
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFB6D260F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFB6D260F08
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L17:
       xor       eax,eax
       jmp       short M00_L12
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L18
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
M00_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 599
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L15
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L12
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L11
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L10
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-38],r14
       cmp       qword ptr [rbp-38],0
       je        short M00_L02
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       short M00_L02
       nop       dword ptr [rax]
M00_L01:
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L05
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       near ptr M00_L07
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
       add       rsi,1
       jo        near ptr M00_L08
       jmp       short M00_L01
M00_L02:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
M00_L03:
       cmp       [rdi],r14
       jne       short M00_L06
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       short M00_L05
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       short M00_L09
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       short M00_L07
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       add       rsi,1
       jo        short M00_L08
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFB6D240DB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L13
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       xor       eax,eax
       mov       [r15+8],rax
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M00_L13
M00_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D2F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26F2A801FF8
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFB6D240DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L12:
       mov       r11,7FFB6D240DB0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L13:
       cmp       [rdi],r14
       je        short M00_L14
       mov       rcx,rdi
       mov       r11,7FFB6D240DC0
       call      qword ptr [r11]
M00_L14:
       cmp       rsi,5
       sete      al
       movzx     eax,al
       jmp       short M00_L16
M00_L15:
       xor       eax,eax
M00_L16:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L17
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L17
       mov       rcx,rdi
       mov       r11,7FFB6D240DC0
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 594
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L15
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L12
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L11
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L10
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-38],r14
       cmp       qword ptr [rbp-38],0
       je        short M00_L02
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       short M00_L02
       nop       dword ptr [rax]
M00_L01:
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L05
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       near ptr M00_L07
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
       add       rsi,1
       jo        near ptr M00_L08
       jmp       short M00_L01
M00_L02:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
M00_L03:
       cmp       [rdi],r14
       jne       short M00_L06
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       short M00_L05
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       short M00_L09
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       short M00_L07
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       add       rsi,1
       jo        short M00_L08
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFB6D240DB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L13
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       xor       eax,eax
       mov       [r15+8],rax
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M00_L13
M00_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D2F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CC52001FF8
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFB6D240DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L12:
       mov       r11,7FFB6D240DB0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L13:
       cmp       [rdi],r14
       je        short M00_L14
       mov       rcx,rdi
       mov       r11,7FFB6D240DC0
       call      qword ptr [r11]
M00_L14:
       cmp       rsi,5
       sete      al
       movzx     eax,al
       jmp       short M00_L16
M00_L15:
       xor       eax,eax
M00_L16:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L17
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L17
       mov       rcx,rdi
       mov       r11,7FFB6D240DC0
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 594
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L15
       xor       esi,esi
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L12
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L11
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L10
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L00:
       mov       [rbp-38],r14
       cmp       qword ptr [rbp-38],0
       je        short M00_L02
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       short M00_L02
       nop       dword ptr [rax]
M00_L01:
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L05
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       near ptr M00_L07
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
       add       rsi,1
       jo        near ptr M00_L08
       jmp       short M00_L01
M00_L02:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
M00_L03:
       cmp       [rdi],r14
       jne       short M00_L06
       lea       r15,[rdi+8]
       mov       rcx,[r15]
       mov       rax,rcx
       mov       edx,[r15+10]
       cmp       edx,[rcx+14]
       jne       short M00_L05
       mov       r8d,[r15+14]
       cmp       r8d,[rax+10]
       jae       short M00_L09
       mov       r13,[rax+8]
       cmp       r8d,[r13+8]
       jae       short M00_L07
       mov       ecx,r8d
       mov       rdx,[r13+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       add       rsi,1
       jo        short M00_L08
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFB6D251190
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L13
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L09:
       xor       eax,eax
       mov       [r15+8],rax
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M00_L13
M00_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1610FC02010
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFB6D2511A0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L12:
       mov       r11,7FFB6D251188
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L13:
       cmp       [rdi],r14
       je        short M00_L14
       mov       rcx,rdi
       mov       r11,7FFB6D251198
       call      qword ptr [r11]
M00_L14:
       cmp       rsi,5
       sete      al
       movzx     eax,al
       jmp       short M00_L16
M00_L15:
       xor       eax,eax
M00_L16:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L17
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L17
       mov       rcx,rdi
       mov       r11,7FFB6D251198
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L15
       xor       esi,esi
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L13
       mov       rcx,[rcx+8]
       mov       r11,7FFB6D2419B8
       call      qword ptr [r11]
       mov       rcx,rax
M00_L00:
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L04
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-30]
       cmp       [rcx],rdi
       jne       near ptr M00_L04
M00_L01:
       lea       r14,[rcx+8]
       mov       rdx,[r14]
       mov       rax,rdx
       mov       r8d,[r14+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L07
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L05
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L08
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       add       rsi,1
       jo        near ptr M00_L09
       mov       rcx,[rbp-30]
       jmp       short M00_L01
M00_L02:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       short M00_L08
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
M00_L03:
       add       rsi,1
       jo        short M00_L09
M00_L04:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-30]
       cmp       [rcx],rdi
       jne       short M00_L06
       lea       r14,[rcx+8]
       mov       rax,[r14]
       mov       edx,[r14+10]
       mov       r8,[r14]
       cmp       edx,[r8+14]
       jne       short M00_L07
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jb        short M00_L02
M00_L05:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       short M00_L10
M00_L06:
       mov       r11,7FFB6D2419A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L03
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,[rbp-30]
       cmp       [rcx],rdi
       jne       short M00_L14
M00_L11:
       cmp       rsi,5
       sete      al
       movzx     eax,al
M00_L12:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       r11,7FFB6D2419A0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L14:
       mov       r11,7FFB6D2419B0
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L15:
       xor       eax,eax
       jmp       short M00_L12
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L16
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-30]
       cmp       [rcx],rdi
       je        short M00_L16
       mov       r11,7FFB6D2419B0
       call      qword ptr [r11]
M00_L16:
       nop
       add       rsp,28
       ret
; Total bytes of code 472
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,222738029F0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L24
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L30
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L28
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L27
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L26
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L06
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       near ptr M00_L06
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L06
M00_L02:
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L08
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],r11
       jne       near ptr M00_L10
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L11
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       je        short M00_L06
       add       r14d,1
       jo        near ptr M00_L14
M00_L06:
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       short M00_L09
       lea       r13,[rcx+8]
       mov       rax,[r13]
       mov       edx,[r13+10]
       mov       r8,[r13]
       cmp       edx,[r8+14]
       jne       short M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jb        near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r13+8],rax
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       mov       r11,7FFB6D240F20
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D240F28
       call      qword ptr [r11]
       mov       rdx,rax
M00_L10:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L05
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r15
       jne       near ptr M00_L29
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        near ptr M00_L25
       add       r13,10
       jmp       short M00_L20
M00_L19:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L20:
       xor       esi,esi
       cmp       esi,r15d
       jl        short M00_L23
       jmp       short M00_L16
M00_L21:
       inc       r14d
M00_L22:
       inc       esi
       cmp       esi,r15d
       jge       short M00_L16
M00_L23:
       mov       rdx,[r13+rsi*8]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L22
       jmp       short M00_L21
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,222738029E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,222738029F0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB6D517A08]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22273801FF8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D240F38
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFB6D240F18
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D240F30
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L30:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L31
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       je        short M00_L31
       mov       r11,7FFB6D240F30
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
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
       call      qword ptr [7FFBE435EB38]
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
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,1B2698009F8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L29
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L27
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L26
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L25
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L06
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       near ptr M00_L06
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L06
M00_L02:
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L08
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],r11
       jne       near ptr M00_L10
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L11
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       je        short M00_L06
       add       r14d,1
       jo        near ptr M00_L14
M00_L06:
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       short M00_L09
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       short M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jb        near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r13+8],rax
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       mov       r11,7FFB6D270F20
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D270F28
       call      qword ptr [r11]
       mov       rdx,rax
M00_L10:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L05
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FFB6D54C138]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r15
       jne       near ptr M00_L28
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        near ptr M00_L24
       add       r13,10
       jmp       short M00_L20
M00_L19:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L20:
       xor       esi,esi
       cmp       esi,r15d
       jl        short M00_L22
       jmp       short M00_L16
M00_L21:
       inc       esi
       cmp       esi,r15d
       jge       short M00_L16
M00_L22:
       mov       rdx,[r13+rsi*8]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L21
       inc       r14d
       jmp       short M00_L21
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1B2698009F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D326BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B2698009F8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFB6D547A08]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B253801FF8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D270F38
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D270F18
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D270F30
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       je        short M00_L30
       mov       r11,7FFB6D270F30
       call      qword ptr [r11]
M00_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 997
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
       call      qword ptr [7FFBE435EB68]
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
       jmp       qword ptr [7FFB6D325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,1AF790009F8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L29
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L27
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L26
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L25
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L06
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       near ptr M00_L06
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L06
M00_L02:
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L08
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],r11
       jne       near ptr M00_L10
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L11
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       je        short M00_L06
       add       r14d,1
       jo        near ptr M00_L14
M00_L06:
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       short M00_L09
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       short M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jb        near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r13+8],rax
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       mov       r11,7FFB6D230DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D230DA8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L10:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L05
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r15
       jne       near ptr M00_L28
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        near ptr M00_L24
       add       r13,10
       jmp       short M00_L20
M00_L19:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L20:
       xor       esi,esi
       cmp       esi,r15d
       jl        short M00_L22
       jmp       short M00_L16
M00_L21:
       inc       esi
       cmp       esi,r15d
       jge       short M00_L16
M00_L22:
       mov       rdx,[r13+rsi*8]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L21
       inc       r14d
       jmp       short M00_L21
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1AF790009F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AF790009F8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFB6D507A08]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AF63001FF8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D230DB8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D230D98
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D230DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       je        short M00_L30
       mov       r11,7FFB6D230DB0
       call      qword ptr [r11]
M00_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 997
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
       call      qword ptr [7FFBE435EB50]
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
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,208B94009F8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L29
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L27
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L26
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L25
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L06
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       near ptr M00_L06
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L06
M00_L02:
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L08
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],r11
       jne       near ptr M00_L10
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L11
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       je        short M00_L06
       add       r14d,1
       jo        near ptr M00_L14
M00_L06:
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       short M00_L09
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       short M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jb        near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r13+8],rax
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       mov       r11,7FFB6D270C98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D270CA0
       call      qword ptr [r11]
       mov       rdx,rax
M00_L10:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L05
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FFB6D54C138]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r15
       jne       near ptr M00_L28
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        near ptr M00_L24
       add       r13,10
       jmp       short M00_L20
M00_L19:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L20:
       xor       esi,esi
       cmp       esi,r15d
       jl        short M00_L22
       jmp       short M00_L16
M00_L21:
       inc       esi
       cmp       esi,r15d
       jge       short M00_L16
M00_L22:
       mov       rdx,[r13+rsi*8]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L21
       inc       r14d
       jmp       short M00_L21
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,208B94009F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D326BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,208B94009F8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFB6D547A08]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,208A3401FB8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D270CB0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D270C90
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D270CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       je        short M00_L30
       mov       r11,7FFB6D270CA8
       call      qword ptr [r11]
M00_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
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
       call      qword ptr [7FFBE438F0C0]
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
       jmp       qword ptr [7FFB6D325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,21F88C009F8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L29
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L27
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L26
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L25
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L05
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,rcx
       cmp       rsi,r13
       jne       near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L05
M00_L02:
       lea       r12,[r15+8]
       mov       rcx,[r12]
       mov       rax,rcx
       mov       edx,[r12+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L08
       mov       r8d,[r12+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       ecx,r8d
       mov       rdx,[rdi+rcx*8+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rdx,[r15+10]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M00_L09
       cmp       dword ptr [rax+8],0
       setg      r8b
       movzx     r8d,r8b
M00_L03:
       test      r8d,r8d
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       add       r14d,1
       jo        near ptr M00_L14
M00_L05:
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r13
       jne       near ptr M00_L10
       lea       r12,[r15+8]
       mov       rcx,[r12]
       mov       rax,rcx
       mov       edx,[r12+10]
       cmp       edx,[rcx+14]
       jne       short M00_L08
       mov       r8d,[r12+14]
       cmp       r8d,[rax+10]
       jae       short M00_L07
       mov       rcx,[rax+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rdx,[r15+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rcx
       jne       short M00_L11
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M00_L12
       cmp       dword ptr [rax+8],0
       setg      r8b
       movzx     r8d,r8b
M00_L06:
       test      r8d,r8d
       je        near ptr M00_L05
       jmp       near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r12+8],rax
       mov       dword ptr [r12+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L09:
       xor       r8d,r8d
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r15
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,r15
       mov       r11,7FFB6D260F20
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r8d,eax
       jmp       short M00_L06
M00_L12:
       xor       r8d,r8d
       jmp       short M00_L06
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r13
       jne       near ptr M00_L28
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        near ptr M00_L24
       add       r13,10
       jmp       short M00_L20
M00_L19:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L20:
       test      r15d,r15d
       jle       short M00_L16
       xor       esi,esi
       jmp       short M00_L22
M00_L21:
       add       rsi,8
       dec       r15d
       je        short M00_L16
M00_L22:
       mov       rdx,[rsi+r13]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L21
       inc       r14d
       jmp       short M00_L21
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21F88C009F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21F88C009F8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFB6D537A08]
       int       3
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21F72C01FF8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D260F30
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D260F10
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r13
       je        short M00_L30
       mov       rcx,r15
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
M00_L30:
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
       call      qword ptr [7FFBE435EB50]
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
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,2158D8029F0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L24
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L30
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L28
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L27
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L26
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L05
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,rcx
       cmp       rsi,r13
       jne       near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L05
M00_L02:
       lea       r12,[r15+8]
       mov       rcx,[r12]
       mov       rax,rcx
       mov       edx,[r12+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L08
       mov       r8d,[r12+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       ecx,r8d
       mov       rdx,[rdi+rcx*8+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rdx,[r15+10]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M00_L09
       cmp       dword ptr [rax+8],0
       setg      r8b
       movzx     r8d,r8b
M00_L03:
       test      r8d,r8d
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       add       r14d,1
       jo        near ptr M00_L14
M00_L05:
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r13
       jne       near ptr M00_L10
       lea       r12,[r15+8]
       mov       rcx,[r12]
       mov       rax,rcx
       mov       edx,[r12+10]
       cmp       edx,[rcx+14]
       jne       short M00_L08
       mov       r8d,[r12+14]
       cmp       r8d,[rax+10]
       jae       short M00_L07
       mov       rcx,[rax+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rdx,[r15+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rcx
       jne       short M00_L11
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M00_L12
       cmp       dword ptr [rax+8],0
       setg      r8b
       movzx     r8d,r8b
M00_L06:
       test      r8d,r8d
       je        near ptr M00_L05
       jmp       near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r12+8],rax
       mov       dword ptr [r12+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L09:
       xor       r8d,r8d
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r15
       mov       r11,7FFB6D250F18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,r15
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r8d,eax
       jmp       short M00_L06
M00_L12:
       xor       r8d,r8d
       jmp       short M00_L06
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r13
       jne       near ptr M00_L29
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        near ptr M00_L25
       add       r13,10
       jmp       short M00_L20
M00_L19:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L20:
       test      r15d,r15d
       jle       short M00_L16
       xor       esi,esi
       jmp       short M00_L23
M00_L21:
       inc       r14d
M00_L22:
       add       rsi,8
       dec       r15d
       je        short M00_L16
M00_L23:
       mov       rdx,[rsi+r13]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L22
       jmp       short M00_L21
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2158D8029E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2158D8029F0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB6D527A08]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2158D801FF8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D250F30
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFB6D250F10
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,r15
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L30:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L31
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r13
       je        short M00_L31
       mov       rcx,r15
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
M00_L31:
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
       call      qword ptr [7FFBE435EB98]
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
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,1F252000A50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L24
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L29
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,rax
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rdx
       jne       near ptr M00_L27
       mov       rsi,[rsi+8]
       cmp       [rsi],rax
       jne       near ptr M00_L26
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L25
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-40],r15
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L05
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,rcx
       cmp       rsi,r13
       jne       near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L05
M00_L02:
       lea       r12,[r15+8]
       mov       rcx,[r12]
       mov       rax,rcx
       mov       edx,[r12+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L12
       mov       r8d,[r12+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       ecx,r8d
       mov       rdx,[rdi+rcx*8+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rdx,[r15+10]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M00_L08
       cmp       dword ptr [rax+8],0
       setg      r8b
       movzx     r8d,r8b
M00_L03:
       test      r8d,r8d
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       add       r14d,1
       jo        near ptr M00_L14
M00_L05:
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r13
       jne       near ptr M00_L09
       lea       r12,[r15+8]
       mov       rcx,[r12]
       mov       rax,rcx
       mov       edx,[r12+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L12
       mov       r8d,[r12+14]
       cmp       r8d,[rax+10]
       jae       short M00_L07
       mov       rcx,[rax+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rdx,[r15+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rcx
       jne       short M00_L10
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M00_L11
       cmp       dword ptr [rax+8],0
       setg      r8b
       movzx     r8d,r8b
M00_L06:
       test      r8d,r8d
       je        near ptr M00_L05
       jmp       near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r12+8],rax
       mov       dword ptr [r12+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       xor       r8d,r8d
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,r15
       mov       r11,7FFB6D241210
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,r15
       mov       r11,7FFB6D241218
       call      qword ptr [r11]
       mov       rdx,rax
M00_L10:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r8d,eax
       jmp       short M00_L06
M00_L11:
       xor       r8d,r8d
       jmp       short M00_L06
M00_L12:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r13
       jne       near ptr M00_L28
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        short M00_L19
       add       r13,10
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFB6D517A08]
       int       3
M00_L20:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L21:
       test      r15d,r15d
       jle       short M00_L16
       xor       esi,esi
       jmp       short M00_L23
M00_L22:
       add       rsi,8
       dec       r15d
       je        short M00_L16
M00_L23:
       mov       rdx,[rsi+r13]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L22
       inc       r14d
       jmp       short M00_L22
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F252000A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F252000A50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F23C002010
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D241228
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D241208
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D241220
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       r15,[rbp-40]
       mov       rsi,[r15]
       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r13
       je        short M00_L30
       mov       rcx,r15
       mov       r11,7FFB6D241220
       call      qword ptr [r11]
M00_L30:
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
       call      qword ptr [7FFB6D9FFEB8]
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
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,27220802B58
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rsi]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       rcx,r11
       je        near ptr M00_L20
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,r11
       je        near ptr M00_L18
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,r11
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,7FFB6D231A70
       call      qword ptr [r11]
       mov       rcx,rax
M00_L01:
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L06
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       near ptr M00_L06
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L06
M00_L02:
       lea       r13,[rcx+8]
       mov       rdx,[r13]
       mov       rax,rdx
       mov       r8d,[r13+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L08
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       je        short M00_L02
       add       r14d,1
       jo        near ptr M00_L14
       jmp       short M00_L02
M00_L04:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rdi+18],r11
       jne       near ptr M00_L10
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M00_L11
       cmp       dword ptr [r12+8],0
       setg      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       je        short M00_L06
       add       r14d,1
       jo        near ptr M00_L14
M00_L06:
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       jne       short M00_L09
       lea       r13,[rcx+8]
       mov       rax,[r13]
       mov       edx,[r13+10]
       mov       r8,[r13]
       cmp       edx,[r8+14]
       jne       short M00_L12
       mov       r8d,[r13+14]
       cmp       r8d,[rax+10]
       jb        near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [r13+8],rax
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       short M00_L15
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       mov       r11,7FFB6D231A58
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D231A60
       call      qword ptr [r11]
       mov       rdx,rax
M00_L10:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L05
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       cmp       rsi,r15
       jne       near ptr M00_L27
M00_L16:
       test      r14d,r14d
       setg      al
       movzx     eax,al
M00_L17:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
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
       mov       r15d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r15d
       jb        short M00_L19
       add       r13,10
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFB6D507A08]
       int       3
M00_L20:
       lea       r13,[rsi+10]
       mov       r15d,[rsi+8]
M00_L21:
       test      r15d,r15d
       jle       short M00_L16
       xor       esi,esi
       jmp       short M00_L24
M00_L22:
       inc       r14d
M00_L23:
       add       rsi,8
       dec       r15d
       je        short M00_L16
M00_L24:
       mov       rdx,[rsi+r13]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L23
       jmp       short M00_L22
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27220802B50
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27220802B58
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D231A50
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D231A68
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L28:
       xor       eax,eax
       jmp       near ptr M00_L17
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       rsi,[rcx]
       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rsi,r15
       je        short M00_L29
       mov       r11,7FFB6D231A68
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 884
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
       call      qword ptr [7FFB6D9E7B40]
       int       3
; Total bytes of code 44
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D260EF0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D250C60
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D260EF0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D240EF0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D260EF0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D230EF0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB6D261170
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        short M00_L01
       mov       rcx,[rcx+8]
       mov       r11,7FFB6D251930
       call      qword ptr [r11]
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 62
```

