## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
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
       mov       r11,7FFCFC7510C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFCFCA8C0D8]
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
       call      qword ptr [7FFCFC805728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17BDFC00C10
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFCFC7510D8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFCFC7510C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,r14
       mov       r11,7FFCFC7510D0
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
       mov       r11,7FFCFC7510D0
       call      qword ptr [r11]
M00_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 592
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
       jmp       qword ptr [7FFCFC805C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
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
       mov       rcx,[rbx+270]
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
       mov       r11,7FFCFC7310C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFCFCA6C0D8]
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
       call      qword ptr [7FFCFC7E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B78F802C08
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFCFC7310D8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFCFC7310C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFCFC7310D0
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
       mov       r11,7FFCFC7310D0
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
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
       mov       rcx,[rbx+270]
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
       mov       r11,7FFCFC7210C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFCFCA5C0D8]
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
       call      qword ptr [7FFCFC7D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B090800C10
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFCFC7210C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFCFC7210D0
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
       mov       r11,7FFCFC7210D0
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
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
       mov       rcx,[rbx+270]
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
       mov       r11,7FFCFC7110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L04
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFCFCA4C0D8]
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
       call      qword ptr [7FFCFC7C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DF4B402C08
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFCFC7110D8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L15:
       mov       r11,7FFCFC7110C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFCFC7110D0
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
       mov       r11,7FFCFC7110D0
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
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
       mov       rcx,[rbx+270]
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
       call      qword ptr [7FFCFCA7C0D8]
       int       3
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFCFC740F70
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
       call      qword ptr [7FFCFC7F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2447B402C08
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFCFC740F80
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L12:
       mov       r11,7FFCFC740F68
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L13:
       cmp       [rdi],r14
       je        short M00_L14
       mov       rcx,rdi
       mov       r11,7FFCFC740F78
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
       mov       r11,7FFCFC740F78
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
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
       mov       rcx,[rbx+270]
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
       call      qword ptr [7FFCFCA4C0D8]
       int       3
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFCFC710F70
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
       call      qword ptr [7FFCFC7C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18CB1002C08
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFCFC710F80
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L12:
       mov       r11,7FFCFC710F68
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L13:
       cmp       [rdi],r14
       je        short M00_L14
       mov       rcx,rdi
       mov       r11,7FFCFC710F78
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
       mov       r11,7FFCFC710F78
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
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
       mov       rcx,[rbx+270]
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
       call      qword ptr [7FFCFCA5C0D8]
       int       3
M00_L06:
       mov       rcx,rdi
       mov       r11,7FFCFC721388
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
       call      qword ptr [7FFCFC7D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B6C9C00C68
       mov       r14,[rcx]
       jmp       near ptr M00_L00
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFCFC721398
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L12:
       mov       r11,7FFCFC721380
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L13:
       cmp       [rdi],r14
       je        short M00_L14
       mov       rcx,rdi
       mov       r11,7FFCFC721390
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
       mov       r11,7FFCFC721390
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        near ptr M00_L15
       xor       esi,esi
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L13
       mov       rcx,[rcx+8]
       mov       r11,7FFCFC731740
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
       mov       r11,7FFCFC731730
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L03
       jmp       short M00_L10
M00_L07:
       call      qword ptr [7FFCFCA6C0D8]
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
       mov       r11,7FFCFC731728
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L14:
       mov       r11,7FFCFC731738
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
       mov       r11,7FFCFC731738
       call      qword ptr [r11]
M00_L16:
       nop
       add       rsp,28
       ret
; Total bytes of code 472
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,2C840C00AD0
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,7FFCFC7210D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7210D8
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
       call      qword ptr [7FFCFCA5C0D8]
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
       mov       rdx,2C840C00AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C840C00AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCFCA579A8]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C840C00C20
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC7210E8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC7210C8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7210E0
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
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
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
       call      qword ptr [7FFCFD1C5248]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,2038E000AD0
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,7FFCFC7410D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7410D8
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
       call      qword ptr [7FFCFCA7C0D8]
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
       mov       rdx,2038E000AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2038E000AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCFCA779A8]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2038E000C20
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC7410E8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC7410C8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7410E0
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
       mov       r11,7FFCFC7410E0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 997
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
       call      qword ptr [7FFCFD1E5278]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,16EABC00AD0
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,7FFCFC7410D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7410D8
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
       call      qword ptr [7FFCFCA7C0D8]
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
       mov       rdx,16EABC00AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16EABC00AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCFCA779A8]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16EABC00C20
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC7410E8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC7410C8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7410E0
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
       mov       r11,7FFCFC7410E0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 997
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
       call      qword ptr [7FFCFD1E51E8]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,15F29C00AD0
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,7FFCFC7310D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7310D8
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
       call      qword ptr [7FFCFCA6C0D8]
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
       mov       rdx,15F29C00AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15F29C00AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCFCA679A8]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15F29C00C20
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC7310E8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC7310C8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC7310E0
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
       mov       r11,7FFCFC7310E0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 997
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
       call      qword ptr [7FFCFD1D5230]
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,13C9E800AD0
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
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       jne       near ptr M00_L28
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FFCFCA7C0D8]
       int       3
M00_L09:
       xor       r8d,r8d
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r15
       mov       r11,7FFCFC740F48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,r15
       mov       r11,7FFCFC740F50
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
       mov       rdx,13C9E800AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,13C9E800AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCFCA779A8]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,13C9E800C20
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC740F60
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC740F40
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,r15
       mov       r11,7FFCFC740F58
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
       mov       r11,7FFCFC740F58
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1013
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
       call      qword ptr [7FFCFD1E52A8]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,25BA0000AD0
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
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       jne       near ptr M00_L28
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FFCFCA4C0D8]
       int       3
M00_L09:
       xor       r8d,r8d
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r15
       mov       r11,7FFCFC7110C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,r15
       mov       r11,7FFCFC7110D0
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
       mov       rdx,25BA0000AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25BA0000AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCFCA479A8]
       int       3
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25BA0000C20
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC7110E0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC7110C0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,r15
       mov       r11,7FFCFC7110D8
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
       mov       r11,7FFCFC7110D8
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1013
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
       call      qword ptr [7FFCFD1B52A8]
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,19C8CC00AD0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L30
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FFCFCA5C0D8]
       int       3
M00_L09:
       xor       r8d,r8d
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r15
       mov       r11,7FFCFC721368
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,r15
       mov       r11,7FFCFC721370
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
       jb        short M00_L19
       add       r13,10
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFCFCA579A8]
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
       mov       rdx,19C8CC00AC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19C8CC00AD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19C8CC00C48
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCFC721380
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFCFC721360
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,r15
       mov       r11,7FFCFC721378
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
       mov       r11,7FFCFC721378
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
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
       call      qword ptr [7FFCFD1C5308]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
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
       mov       rsi,[rbx+270]
       mov       rcx,26224800B90
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
       mov       r11,7FFCFC711720
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       r11,7FFCFC711708
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC711710
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
       call      qword ptr [7FFCFCA4C0D8]
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
       call      qword ptr [7FFCFCA479A8]
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
       mov       rdx,26224800B88
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26224800B90
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFCFC711700
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,[rbp-40]
       mov       r11,7FFCFC711718
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
       mov       r11,7FFCFC711718
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 884
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
       call      qword ptr [7FFCFCFF7A80]
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC741098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC731098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC741098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC750CD0
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC711098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC731098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC711338
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7216E0
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC711098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC741098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC731098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC731098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC711098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC731098
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC731348
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
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7216D8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 86
```

