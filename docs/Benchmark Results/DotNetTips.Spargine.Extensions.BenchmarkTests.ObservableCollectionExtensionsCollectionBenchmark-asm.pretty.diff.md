## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20260316-071408
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
+       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
-       lea       rbp,[rsp+50]
+       sub       rsp,30
+       lea       rbp,[rsp+60]
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
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r14
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
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-38],r14
+       cmp       qword ptr [rbp-38],0
        je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        jne       short M00_L02
+       nop       dword ptr [rax]
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
        jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
        jae       near ptr M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
        jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
        jne       short M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jae       short M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
        jae       short M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
        jo        short M00_L09
        jmp       short M00_L03
 M00_L05:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       rcx,rdi
+       mov       r11,7FFA02890F28
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L16
 M00_L11:
        cmp       rsi,5
        cmp       rsi,5
        sete      al
        movzx     eax,al
 M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L13:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
+       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,17675800C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA02890F38
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFA028B10A0
+       mov       r11,7FFA02890F20
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       mov       rcx,rdi
+       mov       r11,7FFA02890F30
        call      qword ptr [r11]
-       jmp       short M00_L11
+       jmp       near ptr M00_L11
 M00_L17:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       mov       rcx,rdi
+       mov       r11,7FFA02890F30
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
+; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
+       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
-       lea       rbp,[rsp+50]
+       sub       rsp,30
+       lea       rbp,[rsp+60]
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
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r14
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
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-38],r14
+       cmp       qword ptr [rbp-38],0
        je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        jne       short M00_L02
+       nop       dword ptr [rax]
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
        jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
        jae       near ptr M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
        jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
        jne       short M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jae       short M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
        jae       short M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
        jo        short M00_L09
        jmp       short M00_L03
 M00_L05:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       rcx,rdi
+       mov       r11,7FFA028A10A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L16
 M00_L11:
        cmp       rsi,5
        cmp       rsi,5
        sete      al
        movzx     eax,al
 M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L13:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2843AC00C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA028A10B8
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFA028B10A0
+       mov       r11,7FFA028A10A0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       mov       rcx,rdi
+       mov       r11,7FFA028A10B0
        call      qword ptr [r11]
-       jmp       short M00_L11
+       jmp       near ptr M00_L11
 M00_L17:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       mov       rcx,rdi
+       mov       r11,7FFA028A10B0
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
+; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
+       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
-       lea       rbp,[rsp+50]
+       sub       rsp,30
+       lea       rbp,[rsp+60]
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
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r14
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
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-38],r14
+       cmp       qword ptr [rbp-38],0
        je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        jne       short M00_L02
+       nop       dword ptr [rax]
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
        jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
        jae       near ptr M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
        jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
        jne       short M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jae       short M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
        jae       short M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
        jo        short M00_L09
        jmp       short M00_L03
 M00_L05:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       rcx,rdi
+       mov       r11,7FFA02890F28
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L16
 M00_L11:
        cmp       rsi,5
        cmp       rsi,5
        sete      al
        movzx     eax,al
 M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L13:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
+       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,208D5000C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA02890F38
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFA028B10A0
+       mov       r11,7FFA02890F20
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       mov       rcx,rdi
+       mov       r11,7FFA02890F30
        call      qword ptr [r11]
-       jmp       short M00_L11
+       jmp       near ptr M00_L11
 M00_L17:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       mov       rcx,rdi
+       mov       r11,7FFA02890F30
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
+; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
+       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
-       lea       rbp,[rsp+50]
+       sub       rsp,30
+       lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L10
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r14
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
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-38],r14
+       cmp       qword ptr [rbp-38],0
        je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        jne       short M00_L02
+       nop       dword ptr [rax]
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L09
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       near ptr M00_L07
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[rdi+14]
+       jne       short M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       short M00_L08
+       jae       short M00_L09
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       short M00_L07
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B5C138]
+       int       3
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       rcx,rdi
+       mov       r11,7FFA02880F50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,29B33000C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA02880F60
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA02880F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA02880F58
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
+       sub       rsp,28
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L17
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA02880F58
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028B10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
-       call      qword ptr [r11]
-       jmp       short M00_L11
 M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
-       sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
-       call      qword ptr [r11]
-M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
+       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
-       lea       rbp,[rsp+50]
+       sub       rsp,30
+       lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L10
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r14
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
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-38],r14
+       cmp       qword ptr [rbp-38],0
        je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        jne       short M00_L02
+       nop       dword ptr [rax]
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L09
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       near ptr M00_L07
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[rdi+14]
+       jne       short M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       short M00_L08
+       jae       short M00_L09
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       short M00_L07
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       rcx,rdi
+       mov       r11,7FFA028A10D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,145A5400C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028A10E0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028A10C8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028A10D8
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
+       sub       rsp,28
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L17
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA028A10D8
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028B10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
-       call      qword ptr [r11]
-       jmp       short M00_L11
 M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
-       sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
-       call      qword ptr [r11]
-M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
+       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
-       lea       rbp,[rsp+50]
+       sub       rsp,30
+       lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L10
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r14
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
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-38],r14
+       cmp       qword ptr [rbp-38],0
        je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
        jne       short M00_L02
+       nop       dword ptr [rax]
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L09
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       near ptr M00_L07
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       cmp       [rdi],r14
        jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[rdi+14]
+       jne       short M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       short M00_L08
+       jae       short M00_L09
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       short M00_L07
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B8C138]
+       int       3
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       rcx,rdi
+       mov       r11,7FFA028B1258
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1B6D8C00C18
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028B1268
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028B1250
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028B1260
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
+       sub       rsp,28
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L17
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028B10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
-       call      qword ptr [r11]
-       jmp       short M00_L11
 M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
-       sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
-       call      qword ptr [r11]
-M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L15
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L14
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-30],r14
+       mov       [rbp-30],rcx
        cmp       qword ptr [rbp-30],0
-       je        short M00_L02
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       jne       short M00_L02
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
        jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
        mov       r15,[rax+8]
        cmp       r8d,[r15+8]
        jae       near ptr M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
        jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-M00_L03:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L05
        mov       r15,[rax+8]
        cmp       r8d,[r15+8]
        jae       short M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-M00_L04:
+       inc       dword ptr [r14+14]
+M00_L03:
        add       rsi,1
        jo        short M00_L09
-       jmp       short M00_L03
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L06
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
+       cmp       r8d,[rax+10]
+       jb        short M00_L02
 M00_L05:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L16
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
        cmp       rsi,5
        sete      al
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
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02965728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1DF10400C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA028B10B8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028B10A0
+       mov       r11,7FFA028C1D58
        call      qword ptr [r11]
-       mov       r14,rax
+       mov       rcx,rax
        jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+M00_L14:
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
        jmp       short M00_L11
-M00_L17:
+M00_L15:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L18
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L18
-       mov       rcx,r14
-       mov       r11,7FFA028B10B0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L18:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 592
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028A10A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
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
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,17675800C10
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2843AC00C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFA02890F38
+       mov       r11,7FFA028A10B8
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFA02890F20
+       mov       r11,7FFA028A10A0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA028A10B0
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
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA028A10B0
        call      qword ptr [r11]
 M00_L18:
        nop
        nop
        add       rsp,28
        ret
 ; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,17675800C10
+       mov       rcx,208D5000C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B5C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA02880F50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,29B33000C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA02880F60
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA02880F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA02880F58
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,17675800C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA02880F58
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028A10D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,145A5400C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028A10E0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028A10C8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028A10D8
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,17675800C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA028A10D8
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B8C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028B1258
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1B6D8C00C18
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028B1268
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028B1250
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028B1260
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,17675800C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
-       lea       rbp,[rsp+60]
+       sub       rsp,28
+       lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L15
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L14
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-38],r14
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L02
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       jne       short M00_L02
-       nop       dword ptr [rax]
+       mov       [rbp-30],rcx
+       cmp       qword ptr [rbp-30],0
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
        jne       near ptr M00_L07
-       mov       r8d,[r15+14]
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
        jae       near ptr M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
        jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       rdi,[rbp-38]
-       cmp       [rdi],edi
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-M00_L03:
-       cmp       [rdi],r14
-       jne       short M00_L06
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[r15+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L05
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
        jae       short M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-M00_L04:
+       inc       dword ptr [r14+14]
+M00_L03:
        add       rsi,1
        jo        short M00_L09
-       jmp       short M00_L03
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L06
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
+       cmp       r8d,[rax+10]
+       jb        short M00_L02
 M00_L05:
        xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
        cmp       rsi,5
        sete      al
        cmp       rsi,5
        sete      al
        movzx     eax,al
 M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,17675800C10
-       mov       r14,[rcx]
+       mov       r11,7FFA028C1D58
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L18
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       je        short M00_L18
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L18:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA02890F28
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B7C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
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
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2843AC00C10
+       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,208D5000C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFA028A10B8
+       mov       r11,7FFA02890F38
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFA028A10A0
+       mov       r11,7FFA02890F20
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FFA028A10B0
+       mov       r11,7FFA02890F30
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
-       mov       r11,7FFA028A10B0
+       mov       r11,7FFA02890F30
        call      qword ptr [r11]
 M00_L18:
        nop
        nop
        add       rsp,28
        ret
 ; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B5C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA02880F50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B7C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,29B33000C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA02880F60
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA02880F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA02880F58
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2843AC00C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028A10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B0
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA028A10B0
+       mov       r11,7FFA02880F58
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA028A10D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B7C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,145A5400C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028A10E0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028A10C8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028A10D8
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2843AC00C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028A10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B0
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA028A10B0
+       mov       r11,7FFA028A10D8
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B8C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA028B1258
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B7C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1B6D8C00C18
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028B1268
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028B1250
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028B1260
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2843AC00C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA028A10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B0
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA028A10B0
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
-       lea       rbp,[rsp+60]
+       sub       rsp,28
+       lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L15
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L14
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-38],r14
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L02
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       jne       short M00_L02
-       nop       dword ptr [rax]
+       mov       [rbp-30],rcx
+       cmp       qword ptr [rbp-30],0
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
        jne       near ptr M00_L07
-       mov       r8d,[r15+14]
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
        jae       near ptr M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
        jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       rdi,[rbp-38]
-       cmp       [rdi],edi
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-M00_L03:
-       cmp       [rdi],r14
-       jne       short M00_L06
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[r15+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L05
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
        jae       short M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-M00_L04:
+       inc       dword ptr [r14+14]
+M00_L03:
        add       rsi,1
        jo        short M00_L09
-       jmp       short M00_L03
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L06
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
+       cmp       r8d,[rax+10]
+       jb        short M00_L02
 M00_L05:
        xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B7C138]
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
        cmp       rsi,5
        sete      al
        cmp       rsi,5
        sete      al
        movzx     eax,al
 M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2843AC00C10
-       mov       r14,[rcx]
+       mov       r11,7FFA028C1D58
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B8
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FFA028A10A0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B0
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L18
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       je        short M00_L18
-       mov       rcx,rdi
-       mov       r11,7FFA028A10B0
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L18:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B5C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA02880F50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,29B33000C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA02880F60
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA02880F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA02880F58
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,208D5000C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA02880F58
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028A10D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,145A5400C10
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028A10E0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028A10C8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028A10D8
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,208D5000C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA028A10D8
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L15
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L14
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
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
-       jne       near ptr M00_L07
+       jne       near ptr M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L05
+       jae       near ptr M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L08
+       jae       near ptr M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L09
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
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
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L05
+       jae       short M00_L09
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L08
+       jae       short M00_L07
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L09
+       jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L10
+       call      qword ptr [7FFA02B8C138]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028B1258
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1B6D8C00C18
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFA028B1268
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFA028B1250
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFA028B1260
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L12:
+       jmp       short M00_L16
+M00_L15:
+       xor       eax,eax
+M00_L16:
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
-M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,208D5000C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
-       xor       eax,eax
-       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L18
+       je        short M00_L17
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L18
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
-M00_L18:
+M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
-       lea       rbp,[rsp+60]
+       sub       rsp,28
+       lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        near ptr M00_L17
+       je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L15
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L14
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L13
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-38],r14
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L02
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       jne       short M00_L02
-       nop       dword ptr [rax]
+       mov       [rbp-30],rcx
+       cmp       qword ptr [rbp-30],0
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
        jne       near ptr M00_L07
-       mov       r8d,[r15+14]
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L05
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
        jae       near ptr M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
        jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       rdi,[rbp-38]
-       cmp       [rdi],edi
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-M00_L03:
-       cmp       [rdi],r14
-       jne       short M00_L06
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[r15+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L05
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
        jae       short M00_L08
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-M00_L04:
+       inc       dword ptr [r14+14]
+M00_L03:
        add       rsi,1
        jo        short M00_L09
-       jmp       short M00_L03
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L06
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
+       cmp       r8d,[rax+10]
+       jb        short M00_L02
 M00_L05:
        xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F28
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFA02B6C138]
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L10:
-       cmp       [rdi],r14
-       jne       short M00_L16
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
        cmp       rsi,5
        sete      al
        cmp       rsi,5
        sete      al
        movzx     eax,al
 M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L13:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,208D5000C10
-       mov       r14,[rcx]
+       mov       r11,7FFA028C1D58
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F38
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FFA02890F20
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
-       call      qword ptr [r11]
-       jmp       near ptr M00_L11
-M00_L17:
        xor       eax,eax
        jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L18
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       je        short M00_L18
-       mov       rcx,rdi
-       mov       r11,7FFA02890F30
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L18:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
add       rsi,1
        jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FFA02B5C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02880F50
+       mov       r11,7FFA028A10D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L13
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L13
 M00_L10:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,29B33000C10
+       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,145A5400C10
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FFA02880F60
+       mov       r11,7FFA028A10E0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FFA02880F48
+       mov       r11,7FFA028A10C8
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FFA02880F58
+       mov       r11,7FFA028A10D8
        call      qword ptr [r11]
 M00_L14:
        cmp       rsi,5
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
-       mov       r11,7FFA02880F58
+       mov       r11,7FFA028A10D8
        call      qword ptr [r11]
 M00_L17:
        nop
        nop
        add       rsp,28
        ret
 ; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
add       rsi,1
        jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FFA02B5C138]
+       call      qword ptr [7FFA02B8C138]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA02880F50
+       mov       r11,7FFA028B1258
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L13
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L13
 M00_L10:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,29B33000C10
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1B6D8C00C18
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FFA02880F60
+       mov       r11,7FFA028B1268
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FFA02880F48
+       mov       r11,7FFA028B1250
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FFA02880F58
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
 M00_L14:
        cmp       rsi,5
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
-       mov       r11,7FFA02880F58
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
 M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 594
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
-       lea       rbp,[rsp+60]
+       sub       rsp,28
+       lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
        je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L12
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L11
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L10
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-38],r14
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L02
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       jne       short M00_L02
-       nop       dword ptr [rax]
+       mov       [rbp-30],rcx
+       cmp       qword ptr [rbp-30],0
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L05
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L09
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
-       jae       near ptr M00_L07
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L05
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
+       jae       near ptr M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
-       jo        near ptr M00_L08
+       jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       rdi,[rbp-38]
-       cmp       [rdi],edi
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
+       jae       short M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r14+14]
 M00_L03:
-       cmp       [rdi],r14
+       add       rsi,1
+       jo        short M00_L09
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
        jne       short M00_L06
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L05
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L09
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
-       jae       short M00_L07
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-M00_L04:
-       add       rsi,1
-       jo        short M00_L08
-       jmp       short M00_L03
+       jb        short M00_L02
 M00_L05:
-       call      qword ptr [7FFA02B5C138]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFA02880F50
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L09:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L13
+       call      CORINFO_HELP_OVERFLOW
+       int       3
 M00_L10:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02935728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,29B33000C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FFA02880F60
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FFA02880F48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FFA02880F58
-       call      qword ptr [r11]
-M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-       jmp       short M00_L16
-M00_L15:
-       xor       eax,eax
-M00_L16:
+M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
+M00_L13:
+       mov       r11,7FFA028C1D58
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FFA028C1D68
+       call      qword ptr [r11]
+       jmp       short M00_L11
+M00_L15:
+       xor       eax,eax
+       jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L17
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       je        short M00_L17
-       mov       rcx,rdi
-       mov       r11,7FFA02880F58
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L17:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 594
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
add       rsi,1
        jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FFA02B7C138]
+       call      qword ptr [7FFA02B8C138]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFA028A10D0
+       mov       r11,7FFA028B1258
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L13
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L13
 M00_L10:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,145A5400C10
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1B6D8C00C18
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FFA028A10E0
+       mov       r11,7FFA028B1268
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FFA028A10C8
+       mov       r11,7FFA028B1250
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FFA028A10D8
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
 M00_L14:
        cmp       rsi,5
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
-       mov       r11,7FFA028A10D8
+       mov       r11,7FFA028B1260
        call      qword ptr [r11]
 M00_L17:
        nop
        add       rsp,28
        ret
-; Total bytes of code 594
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
-       lea       rbp,[rsp+60]
+       sub       rsp,28
+       lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
        je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L12
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L11
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L10
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-38],r14
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L02
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       jne       short M00_L02
-       nop       dword ptr [rax]
+       mov       [rbp-30],rcx
+       cmp       qword ptr [rbp-30],0
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L05
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L09
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
-       jae       near ptr M00_L07
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L05
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
+       jae       near ptr M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
-       jo        near ptr M00_L08
+       jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       rdi,[rbp-38]
-       cmp       [rdi],edi
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
+       jae       short M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r14+14]
 M00_L03:
-       cmp       [rdi],r14
+       add       rsi,1
+       jo        short M00_L09
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
        jne       short M00_L06
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L05
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L09
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
-       jae       short M00_L07
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-M00_L04:
-       add       rsi,1
-       jo        short M00_L08
-       jmp       short M00_L03
+       jb        short M00_L02
 M00_L05:
-       call      qword ptr [7FFA02B7C138]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10D0
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L09:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L13
+       call      CORINFO_HELP_OVERFLOW
+       int       3
 M00_L10:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA02955728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,145A5400C10
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FFA028A10E0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FFA028A10C8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FFA028A10D8
-       call      qword ptr [r11]
-M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-       jmp       short M00_L16
-M00_L15:
-       xor       eax,eax
-M00_L16:
+M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
+M00_L13:
+       mov       r11,7FFA028C1D58
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FFA028C1D68
+       call      qword ptr [r11]
+       jmp       short M00_L11
+M00_L15:
+       xor       eax,eax
+       jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L17
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       je        short M00_L17
-       mov       rcx,rdi
-       mov       r11,7FFA028A10D8
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L17:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 594
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithCount()
        push      rbp
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
-       lea       rbp,[rsp+60]
+       sub       rsp,28
+       lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
        je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L12
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L11
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L10
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       r15d,[rdi+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rdi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],r15d
-       mov       [r14+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rcx],r11
+       jne       near ptr M00_L13
+       mov       rcx,[rcx+8]
+       mov       r11,7FFA028C1D70
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L00:
-       mov       [rbp-38],r14
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L02
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       jne       short M00_L02
-       nop       dword ptr [rax]
+       mov       [rbp-30],rcx
+       cmp       qword ptr [rbp-30],0
+       je        near ptr M00_L04
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       near ptr M00_L04
 M00_L01:
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L05
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L09
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
-       jae       near ptr M00_L07
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L05
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
+       jae       near ptr M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
-       jo        near ptr M00_L08
+       jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       rdi,[rbp-38]
-       cmp       [rdi],edi
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rax+8]
+       cmp       r8d,[r15+8]
+       jae       short M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r14+14]
 M00_L03:
-       cmp       [rdi],r14
+       add       rsi,1
+       jo        short M00_L09
+M00_L04:
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
        jne       short M00_L06
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L05
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rax,[r14]
+       mov       edx,[r14+10]
+       mov       r8,[r14]
+       cmp       edx,[r8+14]
+       jne       short M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L09
-       mov       r13,[rax+8]
-       cmp       r8d,[r13+8]
-       jae       short M00_L07
-       mov       ecx,r8d
-       mov       rdx,[r13+rcx*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-M00_L04:
-       add       rsi,1
-       jo        short M00_L08
-       jmp       short M00_L03
+       jb        short M00_L02
 M00_L05:
-       call      qword ptr [7FFA02B8C138]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFA028B1258
+       mov       r11,7FFA028C1D60
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFA02B9C138]
        int       3
 M00_L08:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L09:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L13
+       call      CORINFO_HELP_OVERFLOW
+       int       3
 M00_L10:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1B6D8C00C18
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FFA028B1268
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FFA028B1250
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FFA028B1260
-       call      qword ptr [r11]
-M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-       jmp       short M00_L16
-M00_L15:
-       xor       eax,eax
-M00_L16:
+M00_L12:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
+M00_L13:
+       mov       r11,7FFA028C1D58
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FFA028C1D68
+       call      qword ptr [r11]
+       jmp       short M00_L11
+M00_L15:
+       xor       eax,eax
+       jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-38],0
-       je        short M00_L17
-       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rdi,[rbp-38]
-       cmp       [rdi],r14
-       je        short M00_L17
-       mov       rcx,rdi
-       mov       r11,7FFA028B1260
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFA028C1D68
        call      qword ptr [r11]
-M00_L17:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 593
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,2BDD0000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028810B0
+       mov       r11,7FFA028B10B0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028B10B8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
+       call      qword ptr [7FFA02B8C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L22
+       jl        short M00_L23
        jmp       short M00_L16
 M00_L21:
+       inc       r14d
+M00_L22:
        inc       esi
        cmp       esi,r15d
        jge       short M00_L16
-M00_L22:
+M00_L23:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1FAE2800AC8
+       mov       rdx,2BDD0000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2BDD0000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B57A08]
-       int       3
 M00_L25:
+       call      qword ptr [7FFA02B87A08]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
+       mov       rcx,2BDD0000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA028B10C8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028B10A8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA028B10C0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028810C0
+       je        short M00_L31
+       mov       r11,7FFA028B10C0
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA031E53E0]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,262B8802AC8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L23
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
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028810B0
+       mov       r11,7FFA028B10B0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028B10B8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
+       call      qword ptr [7FFA02B8C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
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
-       mov       rdx,1FAE2800AC8
+       mov       rdx,262B8802AC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,262B8802AC8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L24:
-       call      qword ptr [7FFA02B57A08]
+       call      qword ptr [7FFA02B87A08]
        int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
+       mov       rcx,262B8802C18
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA028B10C8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028B10A8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA028B10C0
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
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA028B10C0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA031E5398]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,19A65000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028810B0
+       mov       r11,7FFA028A10B0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028A10B8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L22
+       jl        short M00_L23
        jmp       short M00_L16
 M00_L21:
+       inc       r14d
+M00_L22:
        inc       esi
        cmp       esi,r15d
        jge       short M00_L16
-M00_L22:
+M00_L23:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1FAE2800AC8
+       mov       rdx,19A65000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19A65000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B57A08]
-       int       3
 M00_L25:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
+       mov       rcx,19A65000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA028A10C8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028A10A8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA028A10C0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028810C0
+       je        short M00_L31
+       mov       r11,7FFA028A10C0
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA031D5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,24B54000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       jae       near ptr M00_L12
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
        je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L14
+       jo        near ptr M00_L13
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
-       jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+       jo        near ptr M00_L13
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L09
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L12
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L10
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
+       xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028810B0
+       mov       rcx,r15
+       mov       r11,7FFA028810A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       rcx,r15
+       mov       r11,7FFA028810B0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L13:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L14:
-       call      CORINFO_HELP_OVERFLOW
+       call      qword ptr [7FFA02B5C138]
        int       3
 M00_L15:
-       cmp       rsi,r15
-       jne       near ptr M00_L28
+       cmp       rsi,r13
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L23:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1FAE2800AC8
+       mov       rdx,24B54000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       mov       rcx,24B54000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
+M00_L25:
        call      qword ptr [7FFA02B57A08]
        int       3
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
+       mov       rcx,24B54000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA028810C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028810A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+M00_L29:
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028810C0
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 1007
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA031B5398]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,205E1800AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B6C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028810B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028910A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       rcx,r15
+       mov       r11,7FFA028910B0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
-       jne       near ptr M00_L28
+       cmp       rsi,r13
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L23:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1FAE2800AC8
+       mov       rdx,205E1800AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,205E1800AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B57A08]
-       int       3
 M00_L25:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
+       mov       rcx,205E1800C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA028910C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028910A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+M00_L29:
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028810C0
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 1003
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA031C5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,26B04802B20
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028810B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028A1408
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       rcx,r15
+       mov       r11,7FFA028A1410
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
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
-       jb        near ptr M00_L24
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L23
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L23:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
+       je        short M00_L22
        inc       r14d
-       jmp       short M00_L21
-M00_L23:
+       jmp       short M00_L22
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1FAE2800AC8
+       mov       rdx,26B04802B18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,26B04802B20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B57A08]
-       int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
+       mov       rcx,26B04802C78
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA028A1420
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028A1400
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
        jmp       near ptr M00_L16
 M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FFA028810C0
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA0314CBE8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,1FAE2800AD0
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
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
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028810B0
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B5C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       inc       r14d
+M00_L23:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
-       jmp       short M00_L21
-M00_L23:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1FAE2800AC8
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1FAE2800AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B57A08]
-       int       3
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1FAE2800C20
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028810C8
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
 M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028810A8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028810C0
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L30:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B53B0]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,2BDD0000AD0
+       mov       rcx,262B8802AC8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L23
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
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
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
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
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        near ptr M00_L24
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L23
+       jl        short M00_L22
        jmp       short M00_L16
 M00_L21:
-       inc       r14d
-M00_L22:
        inc       esi
        cmp       esi,r15d
        jge       short M00_L16
-M00_L23:
+M00_L22:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
+       je        short M00_L21
+       inc       r14d
        jmp       short M00_L21
-M00_L24:
+M00_L23:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2BDD0000AC8
+       mov       rdx,262B8802AC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2BDD0000AD0
+       mov       rcx,262B8802AC8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L24:
        call      qword ptr [7FFA02B87A08]
        int       3
-M00_L26:
+M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2BDD0000C20
+       mov       rcx,262B8802C18
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
        mov       r11,7FFA028B10C8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L27:
        mov       rcx,rsi
        mov       r11,7FFA028B10A8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L29:
+M00_L28:
        mov       rcx,[rbp-40]
        mov       r11,7FFA028B10C0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
+       je        short M00_L30
        mov       r11,7FFA028B10C0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E53E0]
+       call      qword ptr [7FFA031E5398]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,2BDD0000AD0
+       mov       rcx,19A65000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028B10B0
+       mov       r11,7FFA028A10B0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA028A10B8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
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
-       mov       rdx,2BDD0000AC8
+       mov       rdx,19A65000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2BDD0000AD0
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19A65000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B87A08]
+       call      qword ptr [7FFA02B77A08]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2BDD0000C20
+       mov       rcx,19A65000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028A10C8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028A10A8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       r11,7FFA028A10C0
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
-       mov       r11,7FFA028B10C0
+       mov       r11,7FFA028A10C0
        call      qword ptr [r11]
 M00_L31:
        nop
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E53E0]
+       call      qword ptr [7FFA031D5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,2BDD0000AD0
+       mov       rcx,24B54000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       jae       near ptr M00_L12
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
        je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L14
+       jo        near ptr M00_L13
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
-       jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+       jo        near ptr M00_L13
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L09
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L12
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L10
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
+       xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028B10B0
+       mov       rcx,r15
+       mov       r11,7FFA028810A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       rcx,r15
+       mov       r11,7FFA028810B0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L13:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L14:
-       call      CORINFO_HELP_OVERFLOW
+       call      qword ptr [7FFA02B5C138]
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2BDD0000AC8
+       mov       rdx,24B54000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2BDD0000AD0
+       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24B54000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B87A08]
+       call      qword ptr [7FFA02B57A08]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2BDD0000C20
+       mov       rcx,24B54000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028810C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028810A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
 M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA028B10C0
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1007
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E53E0]
+       call      qword ptr [7FFA031B5398]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,2BDD0000AD0
+       mov       rcx,205E1800AD0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B6C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028B10B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028910A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       rcx,r15
+       mov       r11,7FFA028910B0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2BDD0000AC8
+       mov       rdx,205E1800AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2BDD0000AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,205E1800AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B87A08]
+       call      qword ptr [7FFA02B67A08]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2BDD0000C20
+       mov       rcx,205E1800C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028910C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028910A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
 M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA028B10C0
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1003
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E53E0]
+       call      qword ptr [7FFA031C5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,2BDD0000AD0
+       mov       rcx,26B04802B20
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028B10B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028A1408
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       rcx,r15
+       mov       r11,7FFA028A1410
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
-       jne       near ptr M00_L29
+       cmp       rsi,r13
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L23
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
-       jmp       short M00_L21
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2BDD0000AC8
+       mov       rdx,26B04802B18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2BDD0000AD0
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,26B04802B20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B87A08]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2BDD0000C20
+       mov       rcx,26B04802C78
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028A1420
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028A1400
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+M00_L28:
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA028B10C0
+       je        short M00_L30
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       je        short M00_L30
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E53E0]
+       call      qword ptr [7FFA0314CBE8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,2BDD0000AD0
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L26
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
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
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028B10B0
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L29
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2BDD0000AC8
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2BDD0000AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FFA02B87A08]
-       int       3
 M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2BDD0000C20
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028B10C8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
+M00_L27:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA028B10C0
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E53E0]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,262B8802AC8
+       mov       rcx,19A65000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028B10B0
+       mov       r11,7FFA028A10B0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA028A10B8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L22
+       jl        short M00_L23
        jmp       short M00_L16
 M00_L21:
+       inc       r14d
+M00_L22:
        inc       esi
        cmp       esi,r15d
        jge       short M00_L16
-M00_L22:
+M00_L23:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,262B8802AC0
+       mov       rdx,19A65000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,262B8802AC8
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19A65000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B87A08]
-       int       3
 M00_L25:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,262B8802C18
+       mov       rcx,19A65000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028A10C8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028A10A8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       r11,7FFA028A10C0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028B10C0
+       je        short M00_L31
+       mov       r11,7FFA028A10C0
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E5398]
+       call      qword ptr [7FFA031D5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,262B8802AC8
+       mov       rcx,24B54000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       jae       near ptr M00_L12
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
        je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L14
+       jo        near ptr M00_L13
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
-       jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+       jo        near ptr M00_L13
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L09
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L12
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L10
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
+       xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028B10B0
+       mov       rcx,r15
+       mov       r11,7FFA028810A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       rcx,r15
+       mov       r11,7FFA028810B0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L13:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L14:
-       call      CORINFO_HELP_OVERFLOW
+       call      qword ptr [7FFA02B5C138]
        int       3
 M00_L15:
-       cmp       rsi,r15
-       jne       near ptr M00_L28
+       cmp       rsi,r13
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L23:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,262B8802AC0
+       mov       rdx,24B54000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,262B8802AC8
+       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24B54000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B87A08]
-       int       3
 M00_L25:
+       call      qword ptr [7FFA02B57A08]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,262B8802C18
+       mov       rcx,24B54000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028810C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028810A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+M00_L29:
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028B10C0
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1007
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E5398]
+       call      qword ptr [7FFA031B5398]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,262B8802AC8
+       mov       rcx,205E1800AD0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
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
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B6C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028B10B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028910A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       rcx,r15
+       mov       r11,7FFA028910B0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
-       jne       near ptr M00_L28
+       cmp       rsi,r13
+       jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
        jmp       short M00_L20
 M00_L19:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L23:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
+       je        short M00_L22
        jmp       short M00_L21
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,262B8802AC0
+       mov       rdx,205E1800AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,262B8802AC8
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,205E1800AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B87A08]
-       int       3
 M00_L25:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,262B8802C18
+       mov       rcx,205E1800C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028910C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L27:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028910A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+M00_L29:
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028B10C0
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1003
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E5398]
+       call      qword ptr [7FFA031C5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,262B8802AC8
+       mov       rcx,26B04802B20
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028B10B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028A1408
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       rcx,r15
+       mov       r11,7FFA028A1410
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
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
-       jb        near ptr M00_L24
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L23
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L23:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
+       je        short M00_L22
        inc       r14d
-       jmp       short M00_L21
-M00_L23:
+       jmp       short M00_L22
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,262B8802AC0
+       mov       rdx,26B04802B18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,262B8802AC8
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,26B04802B20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B87A08]
-       int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,262B8802C18
+       mov       rcx,26B04802C78
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA028A1420
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028B10A8
+       mov       r11,7FFA028A1400
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
        jmp       near ptr M00_L16
 M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FFA028B10C0
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E5398]
+       call      qword ptr [7FFA0314CBE8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,262B8802AC8
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
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
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028B10B0
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10B8
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B8C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L24
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L22
-       jmp       short M00_L16
 M00_L21:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       mov       rdx,[r13+rsi*8]
+       inc       r14d
+M00_L23:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L21
-       inc       r14d
-       jmp       short M00_L21
-M00_L23:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,262B8802AC0
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,262B8802AC8
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FFA02B87A08]
-       int       3
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,262B8802C18
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028B10C8
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
 M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028B10A8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028B10C0
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L30
-       mov       r11,7FFA028B10C0
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L30:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031E5398]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,19A65000AD0
+       mov       rcx,24B54000AD0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       jae       near ptr M00_L12
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
        je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L14
+       jo        near ptr M00_L13
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
-       jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+       jo        near ptr M00_L13
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L09
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L14
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L12
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L10
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
+       xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028A10B0
+       mov       rcx,r15
+       mov       r11,7FFA028810A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10B8
+       mov       rcx,r15
+       mov       r11,7FFA028810B0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B7C138]
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L13:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L14:
-       call      CORINFO_HELP_OVERFLOW
+       call      qword ptr [7FFA02B5C138]
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,19A65000AC8
+       mov       rdx,24B54000AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19A65000AD0
+       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24B54000AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B77A08]
+       call      qword ptr [7FFA02B57A08]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19A65000C20
+       mov       rcx,24B54000C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028A10C8
+       mov       r11,7FFA028810C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA028810A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10C0
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
 M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA028A10C0
+       mov       rcx,r15
+       mov       r11,7FFA028810B8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1007
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031D5380]
+       call      qword ptr [7FFA031B5398]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,19A65000AD0
+       mov       rcx,205E1800AD0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B6C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028A10B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028910A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10B8
+       mov       rcx,r15
+       mov       r11,7FFA028910B0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B7C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L29
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,19A65000AC8
+       mov       rdx,205E1800AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19A65000AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,205E1800AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B77A08]
+       call      qword ptr [7FFA02B67A08]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19A65000C20
+       mov       rcx,205E1800C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028A10C8
+       mov       r11,7FFA028910C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA028910A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10C0
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
 M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA028A10C0
+       mov       rcx,r15
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1003
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031D5380]
+       call      qword ptr [7FFA031C5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,19A65000AD0
+       mov       rcx,26B04802B20
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
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
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA02B7C138]
+       int       3
 M00_L09:
-       mov       r11,7FFA028A10B0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA028A1408
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10B8
+       mov       rcx,r15
+       mov       r11,7FFA028A1410
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA02B7C138]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
-       jne       near ptr M00_L29
+       cmp       rsi,r13
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L23
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
-       jmp       short M00_L21
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,19A65000AC8
+       mov       rdx,26B04802B18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19A65000AD0
+       mov       rcx,26B04802B20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B77A08]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19A65000C20
+       mov       rcx,26B04802C78
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028A10C8
+       mov       r11,7FFA028A1420
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA028A1400
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10C0
+M00_L28:
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA028A10C0
+       je        short M00_L30
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       je        short M00_L30
+       mov       rcx,r15
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031D5380]
+       call      qword ptr [7FFA0314CBE8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,19A65000AD0
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L26
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
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
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA028A10B0
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10B8
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA02B7C138]
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L29
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,19A65000AC8
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19A65000AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FFA02B77A08]
-       int       3
 M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19A65000C20
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028A10C8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028A10A8
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
+M00_L27:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA028A10C0
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA028A10C0
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031D5380]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,24B54000AD0
+       mov       rcx,205E1800AD0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
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
-       jne       near ptr M00_L14
+       jne       near ptr M00_L08
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L13
        mov       ecx,r8d
        mov       rdx,[rdi+rcx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rax,[rdx+30]
        test      rax,rax
-       je        near ptr M00_L08
+       je        near ptr M00_L09
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
 M00_L03:
        test      r8d,r8d
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L13
+       jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
        add       r14d,1
-       jo        near ptr M00_L13
+       jo        near ptr M00_L14
 M00_L05:
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L09
+       jne       near ptr M00_L10
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L14
+       jne       short M00_L08
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       short M00_L07
        mov       rcx,[rax+8]
        cmp       r8d,[rcx+8]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L13
        mov       edx,r8d
        mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       short M00_L10
+       jne       short M00_L11
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M00_L11
+       je        short M00_L12
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
+       call      qword ptr [7FFA02B6C138]
+       int       3
+M00_L09:
        xor       r8d,r8d
        jmp       near ptr M00_L03
-M00_L09:
+M00_L10:
        mov       rcx,r15
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028910A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,r15
-       mov       r11,7FFA028810B0
+       mov       r11,7FFA028910B0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       r8d,eax
        jmp       short M00_L06
-M00_L11:
+M00_L12:
        xor       r8d,r8d
        jmp       short M00_L06
-M00_L12:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
 M00_L13:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L14:
-       call      qword ptr [7FFA02B5C138]
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r13
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
-       mov       rdx,24B54000AC8
+       mov       rdx,205E1800AC8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,24B54000AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,205E1800AD0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B57A08]
+       call      qword ptr [7FFA02B67A08]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,24B54000C20
+       mov       rcx,205E1800C20
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA028910C0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028810A0
+       mov       r11,7FFA028910A0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,r15
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028910B8
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
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028910B8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1007
+; Total bytes of code 1003
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B5398]
+       call      qword ptr [7FFA031C5380]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,24B54000AD0
+       mov       rcx,26B04802B20
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
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
-       jne       near ptr M00_L14
+       jne       near ptr M00_L08
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L13
        mov       ecx,r8d
        mov       rdx,[rdi+rcx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rax,[rdx+30]
        test      rax,rax
-       je        near ptr M00_L08
+       je        near ptr M00_L09
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
 M00_L03:
        test      r8d,r8d
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L13
+       jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
        add       r14d,1
-       jo        near ptr M00_L13
+       jo        near ptr M00_L14
 M00_L05:
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L09
+       jne       near ptr M00_L10
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L14
+       jne       short M00_L08
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       short M00_L07
        mov       rcx,[rax+8]
        cmp       r8d,[rcx+8]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L13
        mov       edx,r8d
        mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       short M00_L10
+       jne       short M00_L11
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M00_L11
+       je        short M00_L12
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
+       call      qword ptr [7FFA02B7C138]
+       int       3
+M00_L09:
        xor       r8d,r8d
        jmp       near ptr M00_L03
-M00_L09:
+M00_L10:
        mov       rcx,r15
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA028A1408
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,r15
-       mov       r11,7FFA028810B0
+       mov       r11,7FFA028A1410
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       r8d,eax
        jmp       short M00_L06
-M00_L11:
+M00_L12:
        xor       r8d,r8d
        jmp       short M00_L06
-M00_L12:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
 M00_L13:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L14:
-       call      qword ptr [7FFA02B5C138]
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r13
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
        jmp       short M00_L23
-M00_L21:
-       inc       r14d
 M00_L22:
        add       rsi,8
        dec       r15d
        add       rsi,8
        dec       r15d
        je        short M00_L16
 M00_L23:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
-       jmp       short M00_L21
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,24B54000AC8
+       mov       rdx,26B04802B18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,24B54000AD0
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,26B04802B20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B57A08]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,24B54000C20
+       mov       rcx,26B04802C78
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028810C0
+       mov       r11,7FFA028A1420
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028810A0
+       mov       r11,7FFA028A1400
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L29:
+M00_L28:
        mov       rcx,r15
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L30
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
+       je        short M00_L30
        mov       rcx,r15
-       mov       r11,7FFA028810B8
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1007
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B5398]
+       call      qword ptr [7FFA0314CBE8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,24B54000AD0
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L26
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L05
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r13,rcx
-       cmp       rsi,r13
-       jne       near ptr M00_L05
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L05
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       near ptr M00_L06
 M00_L02:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L14
-       mov       r8d,[r12+14]
+       lea       r13,[rcx+8]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L12
+       mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L12
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
        je        near ptr M00_L08
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L03:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L02
        add       r14d,1
-       jo        near ptr M00_L13
+       jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       add       r14d,1
-       jo        near ptr M00_L13
-M00_L05:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       near ptr M00_L09
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L14
-       mov       r8d,[r12+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
-       jae       near ptr M00_L12
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L13
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L10
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L11
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       near ptr M00_L10
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L11
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L06
+       add       r14d,1
+       jo        near ptr M00_L14
 M00_L06:
-       test      r8d,r8d
-       je        near ptr M00_L05
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       short M00_L09
+       lea       r13,[rcx+8]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
+       jne       short M00_L12
+       mov       r8d,[r13+14]
+       cmp       r8d,[rax+10]
+       jb        near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
+       mov       [r13+8],rax
+       mov       dword ptr [r13+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       r8d,r8d
+       xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       rcx,r15
-       mov       r11,7FFA028810A8
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,r15
-       mov       r11,7FFA028810B0
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L06
+       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L05
 M00_L11:
-       xor       r8d,r8d
-       jmp       short M00_L06
+       xor       eax,eax
+       jmp       near ptr M00_L05
 M00_L12:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFA02B6C138]
        int       3
 M00_L13:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L14:
-       call      qword ptr [7FFA02B5C138]
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
+       cmp       rsi,r15
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
-M00_L21:
-       inc       r14d
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,24B54000AC8
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02936BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,24B54000AD0
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FFA02B57A08]
-       int       3
 M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,24B54000C20
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028810C0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028810A0
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,r15
-       mov       r11,7FFA028810B8
+M00_L27:
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FFA028810B8
+       je        short M00_L29
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1007
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031B5398]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,205E1800AD0
+       mov       rcx,26B04802B20
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
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
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA02B6C138]
+       call      qword ptr [7FFA02B7C138]
        int       3
 M00_L09:
        xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L10:
        mov       rcx,r15
-       mov       r11,7FFA028910A8
+       mov       r11,7FFA028A1408
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,r15
-       mov       r11,7FFA028910B0
+       mov       r11,7FFA028A1410
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L11:
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r13
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B77A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
        jmp       short M00_L23
-M00_L21:
-       inc       r14d
 M00_L22:
        add       rsi,8
        dec       r15d
        add       rsi,8
        dec       r15d
        je        short M00_L16
 M00_L23:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
-       jmp       short M00_L21
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,205E1800AC8
+       mov       rdx,26B04802B18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,205E1800AD0
+       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,26B04802B20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FFA02B67A08]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,205E1800C20
+       mov       rcx,26B04802C78
        mov       r15,[rcx]
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028910C0
+       mov       r11,7FFA028A1420
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L28:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFA028910A0
+       mov       r11,7FFA028A1400
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
-M00_L29:
+M00_L28:
        mov       rcx,r15
-       mov       r11,7FFA028910B8
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L30
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
+       je        short M00_L30
        mov       rcx,r15
-       mov       r11,7FFA028910B8
+       mov       r11,7FFA028A1418
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031C5380]
+       call      qword ptr [7FFA0314CBE8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,205E1800AD0
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L26
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L05
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r13,rcx
-       cmp       rsi,r13
-       jne       near ptr M00_L05
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L05
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       near ptr M00_L06
 M00_L02:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L08
-       mov       r8d,[r12+14]
+       lea       r13,[rcx+8]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L12
+       mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L09
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L03:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       add       r14d,1
-       jo        near ptr M00_L14
-M00_L05:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       near ptr M00_L10
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[r12+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L11
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L12
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       near ptr M00_L10
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L11
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L06
+       add       r14d,1
+       jo        near ptr M00_L14
 M00_L06:
-       test      r8d,r8d
-       je        near ptr M00_L05
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       short M00_L09
+       lea       r13,[rcx+8]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
+       jne       short M00_L12
+       mov       r8d,[r13+14]
+       cmp       r8d,[rax+10]
+       jb        near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
+       mov       [r13+8],rax
+       mov       dword ptr [r13+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA02B6C138]
-       int       3
-M00_L09:
-       xor       r8d,r8d
+       xor       eax,eax
        jmp       near ptr M00_L03
-M00_L10:
-       mov       rcx,r15
-       mov       r11,7FFA028910A8
+M00_L09:
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,r15
-       mov       r11,7FFA028910B0
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L11:
+M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L06
+       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L05
+M00_L11:
+       xor       eax,eax
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L06
+       call      qword ptr [7FFA02B6C138]
+       int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
+       cmp       rsi,r15
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
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
-       jb        near ptr M00_L25
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA02B67A08]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
-M00_L21:
-       inc       r14d
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,205E1800AC8
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,205E1800AD0
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FFA02B67A08]
-       int       3
 M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,205E1800C20
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028910C0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA028910A0
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,r15
-       mov       r11,7FFA028910B8
+M00_L27:
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L30:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FFA028910B8
+       je        short M00_L29
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA031C5380]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
        mov       rsi,[rbx+270]
-       mov       rcx,26B04802B20
+       mov       rcx,19DB0800C48
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L28
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
        je        near ptr M00_L20
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA02891D58
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L05
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r13,rcx
-       cmp       rsi,r13
-       jne       near ptr M00_L05
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L05
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       near ptr M00_L06
 M00_L02:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L08
-       mov       r8d,[r12+14]
+       lea       r13,[rcx+8]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L12
+       mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L09
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L03:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       add       r14d,1
-       jo        near ptr M00_L14
-M00_L05:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       near ptr M00_L10
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[r12+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L11
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L12
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       near ptr M00_L10
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L11
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L06
+       add       r14d,1
+       jo        near ptr M00_L14
 M00_L06:
-       test      r8d,r8d
-       je        near ptr M00_L05
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       short M00_L09
+       lea       r13,[rcx+8]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
+       jne       short M00_L12
+       mov       r8d,[r13+14]
+       cmp       r8d,[rax+10]
+       jb        near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
+       mov       [r13+8],rax
+       mov       dword ptr [r13+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA02B7C138]
-       int       3
-M00_L09:
-       xor       r8d,r8d
+       xor       eax,eax
        jmp       near ptr M00_L03
-M00_L10:
-       mov       rcx,r15
-       mov       r11,7FFA028A1408
+M00_L09:
+       mov       r11,7FFA02891D40
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,r15
-       mov       r11,7FFA028A1410
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA02891D48
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L11:
+M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L06
+       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L05
+M00_L11:
+       xor       eax,eax
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L06
+       call      qword ptr [7FFA02B6C138]
+       int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
+       cmp       rsi,r15
+       jne       near ptr M00_L27
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        short M00_L19
        add       r13,10
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFA02B77A08]
+       call      qword ptr [7FFA02B67A08]
        int       3
 M00_L20:
        lea       r13,[rsi+10]
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       inc       r14d
+       je        short M00_L23
        jmp       short M00_L22
-M00_L24:
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,26B04802B18
+       mov       rdx,19DB0800C40
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,26B04802B20
+       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19DB0800C48
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,26B04802C78
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFA028A1420
+       mov       r11,7FFA02891D38
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
 M00_L27:
-       mov       rcx,rsi
-       mov       r11,7FFA028A1400
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,r15
-       mov       r11,7FFA028A1418
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
        jmp       near ptr M00_L16
-M00_L29:
+M00_L28:
        xor       eax,eax
        jmp       near ptr M00_L17
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       je        short M00_L30
-       mov       rcx,r15
-       mov       r11,7FFA028A1418
+       je        short M00_L29
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       je        short M00_L29
+       mov       r11,7FFA02891D50
        call      qword ptr [r11]
-M00_L30:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 999
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
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
-       call      qword ptr [7FFA0314CBE8]
+       call      qword ptr [7FFA03047948]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028A1078
+       mov       r11,7FFA028C1078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028A1078
+       mov       r11,7FFA028B1078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028A1078
+       mov       r11,7FFA028B1078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028A1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028A1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028A1078
+       mov       r11,7FFA028913C8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA028A1078
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028C1078
+       mov       r11,7FFA028B1078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028C1078
+       mov       r11,7FFA028B1078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028C1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028C1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028C1078
+       mov       r11,7FFA028913C8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA028C1078
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028B1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028B1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028B1078
+       mov       r11,7FFA028913C8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA028B1078
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028B1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028B1078
+       mov       r11,7FFA02891078
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA028B1078
+       mov       r11,7FFA028913C8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA028B1078
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA02891078
+       mov       r11,7FFA028913C8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA02891078
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA02891078
+       mov       r11,7FFA028913C8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA02891078
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
**Diff for IsNotEmpty method between:**
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+270]
        test      rcx,rcx
-       je        short M00_L03
+       je        short M00_L01
        mov       rcx,[rcx+8]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],r11
-       jne       short M00_L02
-       mov       esi,[rcx+10]
-M00_L00:
-       test      esi,esi
+       mov       r11,7FFA028B1CD0
+       call      qword ptr [r11]
+       test      eax,eax
        setg      al
        movzx     eax,al
-M00_L01:
+M00_L00:
        mov       rcx,[rbx+60]
        mov       [rcx+4C],al
-       add       rsp,28
+       add       rsp,20
        pop       rbx
-       pop       rsi
        ret
-M00_L02:
-       mov       r11,7FFA028913C8
-       call      qword ptr [r11]
-       mov       esi,eax
-       jmp       short M00_L00
-M00_L03:
+M00_L01:
        xor       eax,eax
-       jmp       short M00_L01
-; Total bytes of code 86
+       jmp       short M00_L00
+; Total bytes of code 62
```
