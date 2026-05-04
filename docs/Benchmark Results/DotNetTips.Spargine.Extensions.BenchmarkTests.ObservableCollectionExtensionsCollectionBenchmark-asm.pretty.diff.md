## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20260504-070726
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L17
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L16
+       jne       near ptr M00_L15
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L15
+       jne       near ptr M00_L14
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L13
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       near ptr M00_L09
+       jae       near ptr M00_L05
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       near ptr M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L10
+       jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       short M00_L09
+       cmp       [rdi],r14
+       jne       short M00_L06
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
+       mov       rax,rcx
+       mov       edx,[r15+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L07
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
+       jae       short M00_L05
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       short M00_L08
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
-       jo        short M00_L10
+       jo        short M00_L09
+       jmp       short M00_L03
 M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L03
-M00_L06:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L10
+M00_L06:
+       mov       rcx,rdi
+       mov       r11,7FFF78270E58
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
+       jmp       short M00_L10
+M00_L07:
+       call      qword ptr [7FFF7854C150]
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L09:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L10:
+       cmp       [rdi],r14
+       jne       short M00_L16
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
-M00_L12:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
+M00_L12:
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
-M00_L14:
+M00_L13:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
+       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1F060402A80
        mov       r14,[rcx]
        jmp       near ptr M00_L00
-M00_L15:
+M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFF78230F50
+       mov       r11,7FFF78270E68
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+M00_L15:
+       mov       r11,7FFF78270E50
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
-M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+M00_L16:
+       mov       rcx,rdi
+       mov       r11,7FFF78270E60
        call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
+       jmp       near ptr M00_L11
+M00_L17:
        xor       eax,eax
-       jmp       short M00_L13
+       jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L18
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L18
+       mov       rcx,rdi
+       mov       r11,7FFF78270E60
        call      qword ptr [r11]
-M00_L19:
+M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L17
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L16
+       jne       near ptr M00_L15
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L15
+       jne       near ptr M00_L14
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L13
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       near ptr M00_L09
+       jae       near ptr M00_L05
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       near ptr M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L10
+       jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       short M00_L09
+       cmp       [rdi],r14
+       jne       short M00_L06
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
+       mov       rax,rcx
+       mov       edx,[r15+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L07
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
+       jae       short M00_L05
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       short M00_L08
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
-       jo        short M00_L10
+       jo        short M00_L09
+       jmp       short M00_L03
 M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L03
-M00_L06:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L10
+M00_L06:
+       mov       rcx,rdi
+       mov       r11,7FFF78230E58
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
+       jmp       short M00_L10
+M00_L07:
+       call      qword ptr [7FFF7850C150]
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L09:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L10:
+       cmp       [rdi],r14
+       jne       short M00_L16
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
-M00_L12:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
+M00_L12:
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
-M00_L14:
+M00_L13:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
+       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1C044C00A88
        mov       r14,[rcx]
        jmp       near ptr M00_L00
-M00_L15:
+M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFF78230F50
+       mov       r11,7FFF78230E68
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+M00_L15:
+       mov       r11,7FFF78230E50
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
-M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+M00_L16:
+       mov       rcx,rdi
+       mov       r11,7FFF78230E60
        call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
+       jmp       near ptr M00_L11
+M00_L17:
        xor       eax,eax
-       jmp       short M00_L13
+       jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L18
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L18
+       mov       rcx,rdi
+       mov       r11,7FFF78230E60
        call      qword ptr [r11]
-M00_L19:
+M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L17
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L16
+       jne       near ptr M00_L15
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L15
+       jne       near ptr M00_L14
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L13
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       near ptr M00_L09
+       jae       near ptr M00_L05
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       near ptr M00_L08
        mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rdx,[r13+rcx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L10
+       jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
-       jae       short M00_L09
+       cmp       [rdi],r14
+       jne       short M00_L06
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
+       mov       rax,rcx
+       mov       edx,[r15+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L07
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
+       jae       short M00_L05
+       mov       r13,[rax+8]
+       cmp       r8d,[r13+8]
+       jae       short M00_L08
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
-       jo        short M00_L10
+       jo        short M00_L09
+       jmp       short M00_L03
 M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L03
-M00_L06:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L10
+M00_L06:
+       mov       rcx,rdi
+       mov       r11,7FFF78240E50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
+       jmp       short M00_L10
+M00_L07:
+       call      qword ptr [7FFF7851C150]
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L09:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L10:
+       cmp       [rdi],r14
+       jne       short M00_L16
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
-M00_L12:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
+M00_L12:
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
-M00_L14:
+M00_L13:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,14978802A80
        mov       r14,[rcx]
        jmp       near ptr M00_L00
-M00_L15:
+M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFF78230F50
+       mov       r11,7FFF78240E60
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+M00_L15:
+       mov       r11,7FFF78240E48
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
-M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+M00_L16:
+       mov       rcx,rdi
+       mov       r11,7FFF78240E58
        call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
+       jmp       near ptr M00_L11
+M00_L17:
        xor       eax,eax
-       jmp       short M00_L13
+       jmp       short M00_L12
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L18
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L18
+       mov       rcx,rdi
+       mov       r11,7FFF78240E58
        call      qword ptr [r11]
-M00_L19:
+M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 599
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L16
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L15
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
        jae       near ptr M00_L09
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
-       jo        near ptr M00_L10
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       cmp       [rdi],r14
+       jne       short M00_L06
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
+       mov       rax,rcx
+       mov       edx,[r15+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L05
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
        jae       short M00_L09
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
-       jo        short M00_L10
+       jo        short M00_L08
+       jmp       short M00_L03
 M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L03
+       call      qword ptr [7FFF7853C150]
+       int       3
 M00_L06:
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       rcx,rdi
+       mov       r11,7FFF78260CF8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
-       int       3
-M00_L09:
+       jmp       short M00_L13
+M00_L07:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
+M00_L10:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BC07000A88
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
+       mov       rcx,rdi
+       mov       r11,7FFF78260D08
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
 M00_L12:
+       mov       r11,7FFF78260CF0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78260D00
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
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
-M00_L14:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L15:
+       sub       rsp,28
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L17
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFF78230F50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+       mov       r11,7FFF78260D00
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
 M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
-       call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
-       xor       eax,eax
-       jmp       short M00_L13
-       sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
-       call      qword ptr [r11]
-M00_L19:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L16
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L15
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
        jae       near ptr M00_L09
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
-       jo        near ptr M00_L10
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       cmp       [rdi],r14
+       jne       short M00_L06
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
+       mov       rax,rcx
+       mov       edx,[r15+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L05
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
        jae       short M00_L09
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
-       jo        short M00_L10
+       jo        short M00_L08
+       jmp       short M00_L03
 M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L03
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       rcx,rdi
+       mov       r11,7FFF78240E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
-       int       3
-M00_L09:
+       jmp       short M00_L13
+M00_L07:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
+M00_L10:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1F484002A80
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
+       mov       rcx,rdi
+       mov       r11,7FFF78240E90
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
 M00_L12:
+       mov       r11,7FFF78240E78
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78240E88
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
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
-M00_L14:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L15:
+       sub       rsp,28
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L17
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFF78230F50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+       mov       r11,7FFF78240E88
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
 M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
-       call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
-       xor       eax,eax
-       jmp       short M00_L13
-       sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
-       call      qword ptr [r11]
-M00_L19:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 594
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L15
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L16
+       jne       near ptr M00_L12
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L15
+       jne       near ptr M00_L11
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L05
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
        jae       near ptr M00_L09
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
-       jo        near ptr M00_L10
+       jo        near ptr M00_L08
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
+       mov       rdi,[rbp-38]
+       cmp       [rdi],edi
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
-       mov       r15,[rax+8]
-       cmp       r8d,[r15+8]
+       cmp       [rdi],r14
+       jne       short M00_L06
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
+       mov       rax,rcx
+       mov       edx,[r15+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L05
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
        jae       short M00_L09
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
-       jo        short M00_L10
+       jo        short M00_L08
+       jmp       short M00_L03
 M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L03
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       rcx,rdi
+       mov       r11,7FFF78241050
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
-       int       3
-M00_L09:
+       jmp       short M00_L13
+M00_L07:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L09:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L13
+M00_L10:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,178F4000AE8
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
+       mov       rcx,rdi
+       mov       r11,7FFF78241060
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
 M00_L12:
+       mov       r11,7FFF78241048
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78241058
+       call      qword ptr [r11]
+M00_L14:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
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
-M00_L14:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L15:
+       sub       rsp,28
+       cmp       qword ptr [rbp-38],0
+       je        short M00_L17
+       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rdi,[rbp-38]
+       cmp       [rdi],r14
+       je        short M00_L17
        mov       rcx,rdi
-       mov       r11,7FFF78230F50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+       mov       r11,7FFF78241058
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
 M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
-       call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
-       xor       eax,eax
-       jmp       short M00_L13
-       sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
-       call      qword ptr [r11]
-M00_L19:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 593
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
        test      rcx,rcx
-       je        near ptr M00_L18
+       je        near ptr M00_L15
        xor       esi,esi
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rcx],rax
-       jne       near ptr M00_L16
-       mov       rdi,[rcx+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rdi],rcx
-       jne       near ptr M00_L15
-       cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L14
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
+       mov       r11,7FFF782712E0
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
-       jne       near ptr M00_L08
-       mov       r8d,[rdi+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L07
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L06
+       jae       near ptr M00_L05
        mov       r15,[rax+8]
        cmp       r8d,[r15+8]
-       jae       near ptr M00_L09
-       mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       jae       near ptr M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [r14+14]
        add       rsi,1
-       jo        near ptr M00_L10
+       jo        near ptr M00_L09
+       mov       rcx,[rbp-30]
        jmp       short M00_L01
 M00_L02:
-       mov       r14,[rbp-30]
-       cmp       [r14],r14d
-       jmp       short M00_L05
-M00_L03:
        mov       r15,[rax+8]
        cmp       r8d,[r15+8]
-       jae       short M00_L09
-       mov       ecx,r8d
-       mov       rdx,[r15+rcx*8+10]
-       lea       rcx,[rdi+8]
+       jae       short M00_L08
+       mov       edx,r8d
+       mov       rdx,[r15+rdx*8+10]
+       lea       rcx,[r14+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-M00_L04:
+       inc       dword ptr [r14+14]
+M00_L03:
        add       rsi,1
-       jo        short M00_L10
-M00_L05:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
+       jo        short M00_L09
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
        jne       short M00_L07
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
-       mov       rax,rcx
-       mov       edx,[rdi+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[rdi+14]
+       mov       r8d,[r14+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L03
-M00_L06:
+       jb        short M00_L02
+M00_L05:
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       short M00_L11
-M00_L07:
-       mov       rcx,r14
-       mov       r11,7FFF78230F40
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
+M00_L06:
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L11
-M00_L08:
-       call      qword ptr [7FFF7850C9F0]
+       jne       short M00_L03
+       jmp       short M00_L10
+M00_L07:
+       call      qword ptr [7FFF7854C150]
        int       3
-M00_L09:
+M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L10:
+M00_L09:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L10:
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r14],rcx
-       jne       short M00_L17
-M00_L12:
        cmp       rsi,5
        sete      al
        movzx     eax,al
-M00_L13:
+M00_L12:
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
-M00_L14:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25D64002AE8
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       rcx,rdi
-       mov       r11,7FFF78230F50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       r11,7FFF78230F38
+M00_L13:
+       mov       r11,7FFF782712C8
        call      qword ptr [r11]
-       mov       r14,rax
+       mov       rcx,rax
        jmp       near ptr M00_L00
-M00_L17:
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+M00_L14:
+       mov       r11,7FFF782712D8
        call      qword ptr [r11]
-       jmp       short M00_L12
-M00_L18:
+       jmp       short M00_L11
+M00_L15:
        xor       eax,eax
-       jmp       short M00_L13
+       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L19
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r14,[rbp-30]
-       cmp       [r14],rcx
-       je        short M00_L19
-       mov       rcx,r14
-       mov       r11,7FFF78230F48
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
        call      qword ptr [r11]
-M00_L19:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78270E58
+       mov       r11,7FFF78230E58
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFF7854C150]
+       call      qword ptr [7FFF7850C150]
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
-       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F060402A80
+       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1C044C00A88
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFF78270E68
+       mov       r11,7FFF78230E68
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFF78270E50
+       mov       r11,7FFF78230E50
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78230E60
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
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78230E60
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
-       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78270E58
+       mov       r11,7FFF78240E50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFF7854C150]
+       call      qword ptr [7FFF7851C150]
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
-       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F060402A80
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,14978802A80
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFF78270E68
+       mov       r11,7FFF78240E60
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFF78270E50
+       mov       r11,7FFF78240E48
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78240E58
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
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78240E58
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
-       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7853C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78270E58
+       mov       r11,7FFF78260CF8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7854C150]
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
+       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BC07000A88
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78260D08
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78260CF0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78260D00
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
-       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F060402A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78270E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E60
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
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78260D00
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
-       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78270E58
+       mov       r11,7FFF78240E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7854C150]
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
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1F484002A80
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78240E90
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78240E78
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78240E88
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
-       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F060402A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78270E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E60
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
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78240E88
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
-       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78270E58
+       mov       r11,7FFF78241050
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7854C150]
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
+       mov       rcx,178F4000AE8
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78241060
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78241048
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78241058
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
-       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F060402A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78270E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E60
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
-       mov       r11,7FFF78270E60
+       mov       r11,7FFF78241058
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
-       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       mov       r11,7FFF782712E0
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
-       mov       r11,7FFF78270E58
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
        call      qword ptr [7FFF7854C150]
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
-       call      qword ptr [7FFF78325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F060402A80
-       mov       r14,[rcx]
+       mov       r11,7FFF782712C8
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E68
+       mov       r11,7FFF782712D8
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FFF78270E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78270E60
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
-       mov       r11,7FFF78270E60
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
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
-       jmp       qword ptr [7FFF78325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78230E58
+       mov       r11,7FFF78240E50
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7851C150]
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
-       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C044C00A88
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,14978802A80
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FFF78230E68
+       mov       r11,7FFF78240E60
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FFF78230E50
+       mov       r11,7FFF78240E48
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78240E58
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
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78240E58
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7853C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78230E58
+       mov       r11,7FFF78260CF8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7850C150]
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
+       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BC07000A88
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78260D08
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78260CF0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78260D00
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
-       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C044C00A88
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78230E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E60
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
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78260D00
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78230E58
+       mov       r11,7FFF78240E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7850C150]
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
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1F484002A80
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78240E90
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78240E78
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78240E88
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
-       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C044C00A88
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78230E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E60
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
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78240E88
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78230E58
+       mov       r11,7FFF78241050
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7850C150]
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
+       mov       rcx,178F4000AE8
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78241060
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78241048
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78241058
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
-       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C044C00A88
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78230E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E60
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
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78241058
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       mov       r11,7FFF782712E0
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
-       mov       r11,7FFF78230E58
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7854C150]
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
-       call      qword ptr [7FFF782E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C044C00A88
-       mov       r14,[rcx]
+       mov       r11,7FFF782712C8
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E68
+       mov       r11,7FFF782712D8
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FFF78230E50
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78230E60
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
-       mov       r11,7FFF78230E60
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7853C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78240E50
+       mov       r11,7FFF78260CF8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7851C150]
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
+       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BC07000A88
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78260D08
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78260CF0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78260D00
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
-       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,14978802A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E60
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78240E48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E58
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
-       mov       r11,7FFF78240E58
+       mov       r11,7FFF78260D00
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
-       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78240E50
+       mov       r11,7FFF78240E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7851C150]
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
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1F484002A80
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78240E90
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78240E78
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78240E88
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
-       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,14978802A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E60
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78240E48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E58
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
-       mov       r11,7FFF78240E58
+       mov       r11,7FFF78240E88
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
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       call      qword ptr [7FFF7851C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78240E50
+       mov       r11,7FFF78241050
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FFF7851C150]
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
+       mov       rcx,178F4000AE8
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FFF78241060
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FFF78241048
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FFF78241058
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
-       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,14978802A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E60
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FFF78240E48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E58
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
-       mov       r11,7FFF78240E58
+       mov       r11,7FFF78241058
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
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       mov       r11,7FFF782712E0
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
-       mov       r11,7FFF78240E50
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FFF7851C150]
+       call      qword ptr [7FFF7854C150]
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
-       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,14978802A80
-       mov       r14,[rcx]
+       mov       r11,7FFF782712C8
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E60
+       mov       r11,7FFF782712D8
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FFF78240E48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E58
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
-       mov       r11,7FFF78240E58
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
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
-       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
add       rsi,1
        jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FFF7853C150]
+       call      qword ptr [7FFF7851C150]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78260CF8
+       mov       r11,7FFF78240E80
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
-       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BC07000A88
+       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1F484002A80
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FFF78260D08
+       mov       r11,7FFF78240E90
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FFF78260CF0
+       mov       r11,7FFF78240E78
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FFF78260D00
+       mov       r11,7FFF78240E88
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
-       mov       r11,7FFF78260D00
+       mov       r11,7FFF78240E88
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
add       rsi,1
        jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FFF7853C150]
+       call      qword ptr [7FFF7851C150]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78260CF8
+       mov       r11,7FFF78241050
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
-       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BC07000A88
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,178F4000AE8
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FFF78260D08
+       mov       r11,7FFF78241060
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FFF78260CF0
+       mov       r11,7FFF78241048
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FFF78260D00
+       mov       r11,7FFF78241058
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
-       mov       r11,7FFF78260D00
+       mov       r11,7FFF78241058
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       mov       r11,7FFF782712E0
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
-       call      qword ptr [7FFF7853C150]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFF78260CF8
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFF7854C150]
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
-       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BC07000A88
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FFF78260D08
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FFF78260CF0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FFF78260D00
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
+       mov       r11,7FFF782712C8
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FFF782712D8
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
-       mov       r11,7FFF78260D00
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
call      qword ptr [7FFF7851C150]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FFF78240E80
+       mov       r11,7FFF78241050
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
-       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F484002A80
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,178F4000AE8
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FFF78240E90
+       mov       r11,7FFF78241060
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FFF78240E78
+       mov       r11,7FFF78241048
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FFF78240E88
+       mov       r11,7FFF78241058
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
-       mov       r11,7FFF78240E88
+       mov       r11,7FFF78241058
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
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       mov       r11,7FFF782712E0
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
-       call      qword ptr [7FFF7851C150]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E80
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFF7854C150]
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
-       call      qword ptr [7FFF782F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1F484002A80
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FFF78240E90
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FFF78240E78
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FFF78240E88
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
+       mov       r11,7FFF782712C8
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FFF782712D8
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
-       mov       r11,7FFF78240E88
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
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
-       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rcx,[rbx+278]
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
+       mov       r11,7FFF782712E0
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
-       call      qword ptr [7FFF7851C150]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FFF78241050
+       mov       r11,7FFF782712D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FFF7854C150]
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
-       mov       rcx,178F4000AE8
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FFF78241060
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FFF78241048
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FFF78241058
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
+       mov       r11,7FFF782712C8
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FFF782712D8
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
-       mov       r11,7FFF78241058
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FFF782712D8
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
-       jmp       qword ptr [7FFF782F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,19046C02A10
+       mov       rax,2DE4BC00A18
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78230E68
+       mov       r11,7FFF78250E68
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78230E70
+       mov       r11,7FFF78250E70
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7852C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,2DE4BC00A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2DE4BC00A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78507A20]
+       call      qword ptr [7FFF78527A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
+       mov       rcx,2DE4BC00A98
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230E80
+       mov       r11,7FFF78250E80
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78250E60
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78250E78
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
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78250E78
        call      qword ptr [r11]
 M00_L34:
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF78ADC960]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,19046C02A10
+       mov       rax,2C040C029F8
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78230E68
+       mov       r11,7FFF78250BD8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78230E70
+       mov       r11,7FFF78250BE0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7852C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,2C040C029F0
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2C040C029F8
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78507A20]
+       call      qword ptr [7FFF78527A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
+       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2C040C02A10
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230E80
+       mov       r11,7FFF78250BF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78250BD0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78250BE8
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
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78250BE8
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF78ABD2F0]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,19046C02A10
+       mov       rax,1CC35C00A18
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78230E68
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78230E70
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7853C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,1CC35C00A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1CC35C00A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78507A20]
+       call      qword ptr [7FFF78537A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
+       mov       rcx,1CC35C00A98
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230E80
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78260E90
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
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
 M00_L34:
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF78ADC8D0]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,19046C02A10
+       mov       rax,1E46B800A00
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78230E68
+       mov       r11,7FFF78230BD8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78230E70
+       mov       r11,7FFF78230BE0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,1E46B8009F8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       mov       rcx,1E46B800A00
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FFF78507A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
+       mov       rcx,1E46B800A18
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230E80
+       mov       r11,7FFF78230BF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78230BD0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78230BE8
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
-       mov       r11,7FFF78230E78
+       mov       r11,7FFF78230BE8
        call      qword ptr [r11]
 M00_L34:
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF78A9DC08]
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
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,19046C02A10
+       mov       rax,28444000A18
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L24
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L31
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
        jne       short M00_L05
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        near ptr M00_L25
        add       r15,10
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
+       xor       ebx,ebx
+       cmp       ebx,r14d
        jge       short M00_L03
 M00_L02:
-       mov       rdx,[r15+rdi*8]
+       mov       rdx,[r15+rbx*8]
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
+       jne       near ptr M00_L23
+       inc       ebx
+       cmp       ebx,r14d
        jl        short M00_L02
 M00_L03:
-       xor       edi,edi
+       xor       ebx,ebx
 M00_L04:
        mov       rcx,[rbp+10]
        mov       rax,[rcx+60]
-       mov       [rax+4C],dil
+       mov       [rax+4C],bl
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
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rbx,[rbx+8]
        cmp       [rbx],rdi
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L26
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
+       mov       r14,rax
+       mov       edi,[rbx+14]
+       lea       rcx,[r14+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
+       mov       [r14+10],rcx
+       mov       [r14+18],edi
+       mov       [r14+1C],ecx
 M00_L06:
-       mov       [rbp-30],r15
+       mov       [rbp-30],r14
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
+       je        near ptr M00_L10
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
+       cmp       [rcx],r15
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
+       jne       short M00_L10
 M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
+       lea       rbx,[rcx+8]
+       mov       rdx,[rbx]
        mov       rax,rdx
-       mov       r8d,[rdi+10]
+       mov       r8d,[rbx+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       near ptr M00_L19
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
        je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L08:
-       test      r15d,r15d
+       test      r14d,r14d
        je        short M00_L07
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L20
 M00_L09:
-       xor       r15d,r15d
+       xor       r14d,r14d
        jmp       short M00_L08
 M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78230E68
+       cmp       [rcx],r15
+       je        short M00_L11
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
+       jne       short M00_L12
+       jmp       near ptr M00_L29
+M00_L11:
+       lea       rbx,[rcx+8]
+       mov       rax,[rbx]
+       mov       edx,[rbx+10]
+       mov       r8,[rbx]
        cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
+       jae       near ptr M00_L19
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
+       jne       short M00_L13
+       jmp       short M00_L14
+M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF78230E70
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L13:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
+       mov       r14d,eax
        mov       rcx,[rbp-30]
-       jmp       short M00_L18
+       jmp       short M00_L16
+M00_L14:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L15
+       xor       r14d,r14d
+       jmp       short M00_L16
+M00_L15:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       test      r14d,r14d
+       je        near ptr M00_L10
+       jmp       short M00_L20
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L18:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L19:
+       xor       eax,eax
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L29
+M00_L20:
+       cmp       [rcx],r15
+       jne       near ptr M00_L30
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L23:
+M00_L22:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
        jmp       near ptr M00_L01
-M00_L24:
-       mov       edi,1
+M00_L23:
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L25:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,28444000A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,28444000A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78507A20]
+M00_L25:
+       call      qword ptr [7FFF78537A20]
        int       3
-M00_L27:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
-       mov       r15,[rcx]
+       mov       rcx,28444000A98
+       mov       r14,[rcx]
        jmp       near ptr M00_L06
-M00_L28:
+M00_L27:
        mov       rcx,rbx
-       mov       r11,7FFF78230E80
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L29:
+M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+M00_L29:
+       call      M00_L32
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78230E78
+M00_L30:
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
+       jmp       near ptr M00_L21
+M00_L31:
+       xor       ebx,ebx
        jmp       near ptr M00_L04
-M00_L33:
+M00_L32:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L34
+       je        short M00_L33
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78230E78
+       cmp       [rcx],r15
+       je        short M00_L33
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-M00_L34:
+M00_L33:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 965
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF78AEC888]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,19046C02A10
+       mov       rax,177F2802A10
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
        je        near ptr M00_L32
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        short M00_L01
        add       r15,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78527A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
-M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
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
-M00_L06:
+M00_L03:
        mov       [rbp-30],r15
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[r15+8]
+       mov       rcx,[rbx]
+       mov       rax,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       short M00_L07
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       jae       near ptr M00_L17
+       mov       ecx,r8d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
-       je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       je        short M00_L06
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L05:
+       test      r14d,r14d
+       je        short M00_L04
+       jmp       near ptr M00_L18
+M00_L06:
+       xor       r14d,r14d
+       jmp       short M00_L05
+M00_L07:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78230E68
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       je        short M00_L09
+       mov       rcx,r15
+       mov       r11,7FFF78251048
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
+       jne       short M00_L11
        jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+M00_L09:
+       lea       rbx,[r15+8]
+       mov       rax,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
+       jb        short M00_L10
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+M00_L10:
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       short M00_L17
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78230E70
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,r15
+       mov       r11,7FFF78251050
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L12:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
+       mov       r14d,eax
+       jmp       short M00_L15
+M00_L13:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L14
+       xor       r14d,r14d
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L15:
+       test      r14d,r14d
+       je        near ptr M00_L08
        jmp       short M00_L18
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       call      qword ptr [7FFF7852C150]
+       int       3
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
 M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [r15],rcx
+       jne       near ptr M00_L31
 M00_L19:
-       call      qword ptr [7FFF7850C150]
-       int       3
+       mov       ebx,1
+       jmp       short M00_L24
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       lea       r15,[rbx+10]
+       mov       r14d,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,r14d
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r15+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,r14d
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,177F2802A08
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,177F2802A10
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78507A20]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
+       mov       rcx,177F2802AF0
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230E80
+       mov       r11,7FFF78251060
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF78251040
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L30:
        call      M00_L33
-       jmp       near ptr M00_L03
+       jmp       near ptr M00_L23
 M00_L31:
-       mov       r11,7FFF78230E78
+       mov       rcx,r15
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L19
 M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
 M00_L33:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
        je        short M00_L34
-       mov       r11,7FFF78230E78
+       mov       rcx,rax
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 962
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF78ADC990]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,19046C02A10
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
-       jne       short M00_L05
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
-       jb        near ptr M00_L26
-       add       r15,10
+       je        near ptr M00_L20
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
+       jne       short M00_L02
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
+       jb        short M00_L01
+       add       r14,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78537A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L29
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L28
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
+       je        near ptr M00_L08
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
-M00_L06:
-       mov       [rbp-30],r15
-       cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L10
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[rax+8]
+       mov       rcx,[rbx]
+       mov       r8,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
        mov       r14,[rdx+30]
        test      r14,r14
-       je        short M00_L09
+       je        short M00_L07
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       setg      dil
+       movzx     edi,dil
+M00_L05:
+       test      edi,edi
+       je        short M00_L04
+       jmp       near ptr M00_L17
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
 M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78230E68
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L09
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       jne       short M00_L10
+       jmp       near ptr M00_L19
+M00_L09:
+       lea       rbx,[rax+8]
+       mov       r8,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78230E70
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L18
-M00_L16:
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
        mov       r14,[rdx+30]
        test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
+M00_L13:
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7850C150]
+       setg      dil
+       movzx     edi,dil
+M00_L14:
+       test      edi,edi
+       je        near ptr M00_L08
+       jmp       short M00_L17
+M00_L15:
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L17:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L19:
+       call      M00_L30
+       jmp       short M00_L23
+M00_L20:
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,edi
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r14+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,edi
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,19046C02A08
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19046C02A10
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78507A20]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19046C02A90
-       mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L28:
-       mov       rcx,rbx
-       mov       r11,7FFF78230E80
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230E60
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+       mov       rcx,rax
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78230E78
+M00_L28:
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
-M00_L33:
+       jmp       near ptr M00_L18
+M00_L29:
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78230E78
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L34:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78ABC8D0]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2DE4BC00A18
+       mov       rax,2C040C029F8
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78250E68
+       mov       r11,7FFF78250BD8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78250E70
+       mov       r11,7FFF78250BE0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2DE4BC00A10
+       mov       rdx,2C040C029F0
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2DE4BC00A18
+       mov       rcx,2C040C029F8
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FFF78527A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2DE4BC00A98
+       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2C040C02A10
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250E80
+       mov       r11,7FFF78250BF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250E60
+       mov       r11,7FFF78250BD0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78250E78
+       mov       r11,7FFF78250BE8
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
-       mov       r11,7FFF78250E78
+       mov       r11,7FFF78250BE8
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
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
-       call      qword ptr [7FFF78ADC960]
+       call      qword ptr [7FFF78ABD2F0]
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
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2DE4BC00A18
+       mov       rax,1CC35C00A18
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78250E68
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78250E70
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7852C150]
+       call      qword ptr [7FFF7853C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2DE4BC00A10
+       mov       rdx,1CC35C00A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2DE4BC00A18
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1CC35C00A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78527A20]
+       call      qword ptr [7FFF78537A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2DE4BC00A98
+       mov       rcx,1CC35C00A98
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250E80
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250E60
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78250E78
+       mov       r11,7FFF78260E90
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
-       mov       r11,7FFF78250E78
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
 M00_L34:
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
-       call      qword ptr [7FFF78ADC960]
+       call      qword ptr [7FFF78ADC8D0]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2DE4BC00A18
+       mov       rax,1E46B800A00
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78250E68
+       mov       r11,7FFF78230BD8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78250E70
+       mov       r11,7FFF78230BE0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7852C150]
+       call      qword ptr [7FFF7850C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2DE4BC00A10
+       mov       rdx,1E46B8009F8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2DE4BC00A18
+       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E46B800A00
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78527A20]
+       call      qword ptr [7FFF78507A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2DE4BC00A98
+       mov       rcx,1E46B800A18
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250E80
+       mov       r11,7FFF78230BF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250E60
+       mov       r11,7FFF78230BD0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78250E78
+       mov       r11,7FFF78230BE8
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
-       mov       r11,7FFF78250E78
+       mov       r11,7FFF78230BE8
        call      qword ptr [r11]
 M00_L34:
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
-       call      qword ptr [7FFF78ADC960]
+       call      qword ptr [7FFF78A9DC08]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2DE4BC00A18
+       mov       rax,28444000A18
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L24
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L31
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
        jne       short M00_L05
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        near ptr M00_L25
        add       r15,10
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
+       xor       ebx,ebx
+       cmp       ebx,r14d
        jge       short M00_L03
 M00_L02:
-       mov       rdx,[r15+rdi*8]
+       mov       rdx,[r15+rbx*8]
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
+       jne       near ptr M00_L23
+       inc       ebx
+       cmp       ebx,r14d
        jl        short M00_L02
 M00_L03:
-       xor       edi,edi
+       xor       ebx,ebx
 M00_L04:
        mov       rcx,[rbp+10]
        mov       rax,[rcx+60]
-       mov       [rax+4C],dil
+       mov       [rax+4C],bl
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
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rbx,[rbx+8]
        cmp       [rbx],rdi
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L26
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
+       mov       r14,rax
+       mov       edi,[rbx+14]
+       lea       rcx,[r14+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
+       mov       [r14+10],rcx
+       mov       [r14+18],edi
+       mov       [r14+1C],ecx
 M00_L06:
-       mov       [rbp-30],r15
+       mov       [rbp-30],r14
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
+       je        near ptr M00_L10
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
+       cmp       [rcx],r15
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
+       jne       short M00_L10
 M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
+       lea       rbx,[rcx+8]
+       mov       rdx,[rbx]
        mov       rax,rdx
-       mov       r8d,[rdi+10]
+       mov       r8d,[rbx+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       near ptr M00_L19
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
        je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L08:
-       test      r15d,r15d
+       test      r14d,r14d
        je        short M00_L07
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L20
 M00_L09:
-       xor       r15d,r15d
+       xor       r14d,r14d
        jmp       short M00_L08
 M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78250E68
+       cmp       [rcx],r15
+       je        short M00_L11
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
+       jne       short M00_L12
+       jmp       near ptr M00_L29
+M00_L11:
+       lea       rbx,[rcx+8]
+       mov       rax,[rbx]
+       mov       edx,[rbx+10]
+       mov       r8,[rbx]
        cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
+       jae       near ptr M00_L19
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
+       jne       short M00_L13
+       jmp       short M00_L14
+M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF78250E70
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L13:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
+       mov       r14d,eax
        mov       rcx,[rbp-30]
-       jmp       short M00_L18
+       jmp       short M00_L16
+M00_L14:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L15
+       xor       r14d,r14d
+       jmp       short M00_L16
+M00_L15:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       test      r14d,r14d
+       je        near ptr M00_L10
+       jmp       short M00_L20
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7852C150]
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L18:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L19:
+       xor       eax,eax
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L29
+M00_L20:
+       cmp       [rcx],r15
+       jne       near ptr M00_L30
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L23:
+M00_L22:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
        jmp       near ptr M00_L01
-M00_L24:
-       mov       edi,1
+M00_L23:
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L25:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2DE4BC00A10
+       mov       rdx,28444000A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2DE4BC00A18
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,28444000A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78527A20]
+M00_L25:
+       call      qword ptr [7FFF78537A20]
        int       3
-M00_L27:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2DE4BC00A98
-       mov       r15,[rcx]
+       mov       rcx,28444000A98
+       mov       r14,[rcx]
        jmp       near ptr M00_L06
-M00_L28:
+M00_L27:
        mov       rcx,rbx
-       mov       r11,7FFF78250E80
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L29:
+M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250E60
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+M00_L29:
+       call      M00_L32
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78250E78
+M00_L30:
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
+       jmp       near ptr M00_L21
+M00_L31:
+       xor       ebx,ebx
        jmp       near ptr M00_L04
-M00_L33:
+M00_L32:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L34
+       je        short M00_L33
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78250E78
+       cmp       [rcx],r15
+       je        short M00_L33
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-M00_L34:
+M00_L33:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 965
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
-       call      qword ptr [7FFF78ADC960]
+       call      qword ptr [7FFF78AEC888]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2DE4BC00A18
+       mov       rax,177F2802A10
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
        je        near ptr M00_L32
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        short M00_L01
        add       r15,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78527A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
-M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
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
-M00_L06:
+M00_L03:
        mov       [rbp-30],r15
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[r15+8]
+       mov       rcx,[rbx]
+       mov       rax,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       short M00_L07
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       jae       near ptr M00_L17
+       mov       ecx,r8d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
-       je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       je        short M00_L06
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L05:
+       test      r14d,r14d
+       je        short M00_L04
+       jmp       near ptr M00_L18
+M00_L06:
+       xor       r14d,r14d
+       jmp       short M00_L05
+M00_L07:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78250E68
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       je        short M00_L09
+       mov       rcx,r15
+       mov       r11,7FFF78251048
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
+       jne       short M00_L11
        jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+M00_L09:
+       lea       rbx,[r15+8]
+       mov       rax,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
+       jb        short M00_L10
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+M00_L10:
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       short M00_L17
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78250E70
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,r15
+       mov       r11,7FFF78251050
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L12:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
+       mov       r14d,eax
+       jmp       short M00_L15
+M00_L13:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L14
+       xor       r14d,r14d
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L15:
+       test      r14d,r14d
+       je        near ptr M00_L08
        jmp       short M00_L18
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
        call      qword ptr [7FFF7852C150]
        int       3
-M00_L20:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+M00_L18:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [r15],rcx
        jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
-M00_L23:
+M00_L19:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L20:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       xor       ebx,ebx
+       cmp       ebx,r14d
+       jge       short M00_L23
+M00_L22:
+       mov       rdx,[r15+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,r14d
+       jl        short M00_L22
+M00_L23:
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2DE4BC00A10
+       mov       rdx,177F2802A08
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2DE4BC00A18
+       mov       rcx,177F2802A10
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78527A20]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2DE4BC00A98
+       mov       rcx,177F2802AF0
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250E80
+       mov       r11,7FFF78251060
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250E60
+       mov       r11,7FFF78251040
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L30:
        call      M00_L33
-       jmp       near ptr M00_L03
+       jmp       near ptr M00_L23
 M00_L31:
-       mov       r11,7FFF78250E78
+       mov       rcx,r15
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L19
 M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
 M00_L33:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
        je        short M00_L34
-       mov       r11,7FFF78250E78
+       mov       rcx,rax
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 962
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
-       call      qword ptr [7FFF78ADC960]
+       call      qword ptr [7FFF78ADC990]
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
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,2DE4BC00A18
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
-       jne       short M00_L05
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
-       jb        near ptr M00_L26
-       add       r15,10
+       je        near ptr M00_L20
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
+       jne       short M00_L02
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
+       jb        short M00_L01
+       add       r14,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78537A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L29
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L28
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
+       je        near ptr M00_L08
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
-M00_L06:
-       mov       [rbp-30],r15
-       cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L10
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[rax+8]
+       mov       rcx,[rbx]
+       mov       r8,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
        mov       r14,[rdx+30]
        test      r14,r14
-       je        short M00_L09
+       je        short M00_L07
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       setg      dil
+       movzx     edi,dil
+M00_L05:
+       test      edi,edi
+       je        short M00_L04
+       jmp       near ptr M00_L17
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
 M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78250E68
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L09
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       jne       short M00_L10
+       jmp       near ptr M00_L19
+M00_L09:
+       lea       rbx,[rax+8]
+       mov       r8,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78250E70
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L18
-M00_L16:
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
        mov       r14,[rdx+30]
        test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
+M00_L13:
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7852C150]
+       setg      dil
+       movzx     edi,dil
+M00_L14:
+       test      edi,edi
+       je        near ptr M00_L08
+       jmp       short M00_L17
+M00_L15:
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L17:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L19:
+       call      M00_L30
+       jmp       short M00_L23
+M00_L20:
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,edi
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r14+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,edi
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2DE4BC00A10
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2DE4BC00A18
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78527A20]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2DE4BC00A98
-       mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L28:
-       mov       rcx,rbx
-       mov       r11,7FFF78250E80
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250E60
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+       mov       rcx,rax
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78250E78
+M00_L28:
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
-M00_L33:
+       jmp       near ptr M00_L18
+M00_L29:
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78250E78
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L34:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78ADC960]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2C040C029F8
+       mov       rax,1CC35C00A18
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78250BD8
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78250BE0
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7852C150]
+       call      qword ptr [7FFF7853C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2C040C029F0
+       mov       rdx,1CC35C00A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2C040C029F8
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1CC35C00A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78527A20]
+       call      qword ptr [7FFF78537A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2C040C02A10
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1CC35C00A98
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250BF0
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250BD0
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78250BE8
+       mov       r11,7FFF78260E90
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
-       mov       r11,7FFF78250BE8
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 1002
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
-       call      qword ptr [7FFF78ABD2F0]
+       call      qword ptr [7FFF78ADC8D0]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2C040C029F8
+       mov       rax,1E46B800A00
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78250BD8
+       mov       r11,7FFF78230BD8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78250BE0
+       mov       r11,7FFF78230BE0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7852C150]
+       call      qword ptr [7FFF7850C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2C040C029F0
+       mov       rdx,1E46B8009F8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2C040C029F8
+       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E46B800A00
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78527A20]
+       call      qword ptr [7FFF78507A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2C040C02A10
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1E46B800A18
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250BF0
+       mov       r11,7FFF78230BF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250BD0
+       mov       r11,7FFF78230BD0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78250BE8
+       mov       r11,7FFF78230BE8
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
-       mov       r11,7FFF78250BE8
+       mov       r11,7FFF78230BE8
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 1002
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
-       call      qword ptr [7FFF78ABD2F0]
+       call      qword ptr [7FFF78A9DC08]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2C040C029F8
+       mov       rax,28444000A18
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L24
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L31
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
        jne       short M00_L05
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        near ptr M00_L25
        add       r15,10
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
+       xor       ebx,ebx
+       cmp       ebx,r14d
        jge       short M00_L03
 M00_L02:
-       mov       rdx,[r15+rdi*8]
+       mov       rdx,[r15+rbx*8]
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
+       jne       near ptr M00_L23
+       inc       ebx
+       cmp       ebx,r14d
        jl        short M00_L02
 M00_L03:
-       xor       edi,edi
+       xor       ebx,ebx
 M00_L04:
        mov       rcx,[rbp+10]
        mov       rax,[rcx+60]
-       mov       [rax+4C],dil
+       mov       [rax+4C],bl
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
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rbx,[rbx+8]
        cmp       [rbx],rdi
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L26
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
+       mov       r14,rax
+       mov       edi,[rbx+14]
+       lea       rcx,[r14+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
+       mov       [r14+10],rcx
+       mov       [r14+18],edi
+       mov       [r14+1C],ecx
 M00_L06:
-       mov       [rbp-30],r15
+       mov       [rbp-30],r14
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
+       je        near ptr M00_L10
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
+       cmp       [rcx],r15
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
+       jne       short M00_L10
 M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
+       lea       rbx,[rcx+8]
+       mov       rdx,[rbx]
        mov       rax,rdx
-       mov       r8d,[rdi+10]
+       mov       r8d,[rbx+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       near ptr M00_L19
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
        je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L08:
-       test      r15d,r15d
+       test      r14d,r14d
        je        short M00_L07
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L20
 M00_L09:
-       xor       r15d,r15d
+       xor       r14d,r14d
        jmp       short M00_L08
 M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78250BD8
+       cmp       [rcx],r15
+       je        short M00_L11
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
+       jne       short M00_L12
+       jmp       near ptr M00_L29
+M00_L11:
+       lea       rbx,[rcx+8]
+       mov       rax,[rbx]
+       mov       edx,[rbx+10]
+       mov       r8,[rbx]
        cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
+       jae       near ptr M00_L19
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
+       jne       short M00_L13
+       jmp       short M00_L14
+M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF78250BE0
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L13:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
+       mov       r14d,eax
        mov       rcx,[rbp-30]
-       jmp       short M00_L18
+       jmp       short M00_L16
+M00_L14:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L15
+       xor       r14d,r14d
+       jmp       short M00_L16
+M00_L15:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       test      r14d,r14d
+       je        near ptr M00_L10
+       jmp       short M00_L20
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7852C150]
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L18:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L19:
+       xor       eax,eax
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L29
+M00_L20:
+       cmp       [rcx],r15
+       jne       near ptr M00_L30
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L23:
+M00_L22:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
        jmp       near ptr M00_L01
-M00_L24:
-       mov       edi,1
+M00_L23:
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L25:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2C040C029F0
+       mov       rdx,28444000A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2C040C029F8
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,28444000A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78527A20]
+M00_L25:
+       call      qword ptr [7FFF78537A20]
        int       3
-M00_L27:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2C040C02A10
-       mov       r15,[rcx]
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,28444000A98
+       mov       r14,[rcx]
        jmp       near ptr M00_L06
-M00_L28:
+M00_L27:
        mov       rcx,rbx
-       mov       r11,7FFF78250BF0
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L29:
+M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250BD0
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+M00_L29:
+       call      M00_L32
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78250BE8
+M00_L30:
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
+       jmp       near ptr M00_L21
+M00_L31:
+       xor       ebx,ebx
        jmp       near ptr M00_L04
-M00_L33:
+M00_L32:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L34
+       je        short M00_L33
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78250BE8
+       cmp       [rcx],r15
+       je        short M00_L33
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-M00_L34:
+M00_L33:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 965
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
-       call      qword ptr [7FFF78ABD2F0]
+       call      qword ptr [7FFF78AEC888]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,2C040C029F8
+       mov       rax,177F2802A10
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
        je        near ptr M00_L32
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        short M00_L01
        add       r15,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78527A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
-M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
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
-M00_L06:
+M00_L03:
        mov       [rbp-30],r15
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[r15+8]
+       mov       rcx,[rbx]
+       mov       rax,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       short M00_L07
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       jae       near ptr M00_L17
+       mov       ecx,r8d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
-       je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       je        short M00_L06
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L05:
+       test      r14d,r14d
+       je        short M00_L04
+       jmp       near ptr M00_L18
+M00_L06:
+       xor       r14d,r14d
+       jmp       short M00_L05
+M00_L07:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78250BD8
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       je        short M00_L09
+       mov       rcx,r15
+       mov       r11,7FFF78251048
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
+       jne       short M00_L11
        jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+M00_L09:
+       lea       rbx,[r15+8]
+       mov       rax,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
+       jb        short M00_L10
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+M00_L10:
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       short M00_L17
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78250BE0
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,r15
+       mov       r11,7FFF78251050
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L12:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
+       mov       r14d,eax
+       jmp       short M00_L15
+M00_L13:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L14
+       xor       r14d,r14d
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L15:
+       test      r14d,r14d
+       je        near ptr M00_L08
        jmp       short M00_L18
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
        call      qword ptr [7FFF7852C150]
        int       3
-M00_L20:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+M00_L18:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [r15],rcx
        jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
-M00_L23:
+M00_L19:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L20:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       xor       ebx,ebx
+       cmp       ebx,r14d
+       jge       short M00_L23
+M00_L22:
+       mov       rdx,[r15+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,r14d
+       jl        short M00_L22
+M00_L23:
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2C040C029F0
+       mov       rdx,177F2802A08
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2C040C029F8
+       mov       rcx,177F2802A10
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78527A20]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2C040C02A10
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,177F2802AF0
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78250BF0
+       mov       r11,7FFF78251060
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250BD0
+       mov       r11,7FFF78251040
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L30:
        call      M00_L33
-       jmp       near ptr M00_L03
+       jmp       near ptr M00_L23
 M00_L31:
-       mov       r11,7FFF78250BE8
+       mov       rcx,r15
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L19
 M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
 M00_L33:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
        je        short M00_L34
-       mov       r11,7FFF78250BE8
+       mov       rcx,rax
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 962
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
-       call      qword ptr [7FFF78ABD2F0]
+       call      qword ptr [7FFF78ADC990]
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
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,2C040C029F8
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
-       jne       short M00_L05
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
-       jb        near ptr M00_L26
-       add       r15,10
+       je        near ptr M00_L20
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
+       jne       short M00_L02
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
+       jb        short M00_L01
+       add       r14,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78537A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L29
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L28
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
+       je        near ptr M00_L08
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
-M00_L06:
-       mov       [rbp-30],r15
-       cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L10
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[rax+8]
+       mov       rcx,[rbx]
+       mov       r8,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
        mov       r14,[rdx+30]
        test      r14,r14
-       je        short M00_L09
+       je        short M00_L07
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       setg      dil
+       movzx     edi,dil
+M00_L05:
+       test      edi,edi
+       je        short M00_L04
+       jmp       near ptr M00_L17
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
 M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78250BD8
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L09
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       jne       short M00_L10
+       jmp       near ptr M00_L19
+M00_L09:
+       lea       rbx,[rax+8]
+       mov       r8,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78250BE0
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L18
-M00_L16:
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
        mov       r14,[rdx+30]
        test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
+M00_L13:
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7852C150]
+       setg      dil
+       movzx     edi,dil
+M00_L14:
+       test      edi,edi
+       je        near ptr M00_L08
+       jmp       short M00_L17
+M00_L15:
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L17:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L19:
+       call      M00_L30
+       jmp       short M00_L23
+M00_L20:
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,edi
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r14+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,edi
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,2C040C029F0
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2C040C029F8
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78527A20]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF78305728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2C040C02A10
-       mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L28:
-       mov       rcx,rbx
-       mov       r11,7FFF78250BF0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78250BD0
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+       mov       rcx,rax
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78250BE8
+M00_L28:
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
-M00_L33:
+       jmp       near ptr M00_L18
+M00_L29:
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78250BE8
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L34:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1003
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78ABD2F0]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,1CC35C00A18
+       mov       rax,1E46B800A00
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L25
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
-       mov       r11,7FFF78260E80
+       mov       r11,7FFF78230BD8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L14
        jmp       near ptr M00_L30
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
-       mov       r11,7FFF78260E88
+       mov       r11,7FFF78230BE0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L15:
        test      r15d,r15d
        je        near ptr M00_L11
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFF7853C150]
+       call      qword ptr [7FFF7850C150]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       edi,1
        jmp       near ptr M00_L04
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1CC35C00A10
+       mov       rdx,1E46B8009F8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CC35C00A18
+       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E46B800A00
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L26:
-       call      qword ptr [7FFF78537A20]
+       call      qword ptr [7FFF78507A20]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CC35C00A98
+       mov       rcx,1E46B800A18
        mov       r15,[rcx]
        jmp       near ptr M00_L06
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78260E98
+       mov       r11,7FFF78230BF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78260E78
+       mov       r11,7FFF78230BD0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L06
        call      M00_L33
        jmp       near ptr M00_L03
 M00_L31:
-       mov       r11,7FFF78260E90
+       mov       r11,7FFF78230BE8
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
-       mov       r11,7FFF78260E90
+       mov       r11,7FFF78230BE8
        call      qword ptr [r11]
 M00_L34:
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
-       call      qword ptr [7FFF78ADC8D0]
+       call      qword ptr [7FFF78A9DC08]
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,1CC35C00A18
+       mov       rax,28444000A18
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L24
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L31
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
        jne       short M00_L05
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        near ptr M00_L25
        add       r15,10
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
+       xor       ebx,ebx
+       cmp       ebx,r14d
        jge       short M00_L03
 M00_L02:
-       mov       rdx,[r15+rdi*8]
+       mov       rdx,[r15+rbx*8]
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
+       jne       near ptr M00_L23
+       inc       ebx
+       cmp       ebx,r14d
        jl        short M00_L02
 M00_L03:
-       xor       edi,edi
+       xor       ebx,ebx
 M00_L04:
        mov       rcx,[rbp+10]
        mov       rax,[rcx+60]
-       mov       [rax+4C],dil
+       mov       [rax+4C],bl
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
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rbx,[rbx+8]
        cmp       [rbx],rdi
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L26
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
+       mov       r14,rax
+       mov       edi,[rbx+14]
+       lea       rcx,[r14+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
+       mov       [r14+10],rcx
+       mov       [r14+18],edi
+       mov       [r14+1C],ecx
 M00_L06:
-       mov       [rbp-30],r15
+       mov       [rbp-30],r14
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
+       je        near ptr M00_L10
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
+       cmp       [rcx],r15
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
+       jne       short M00_L10
 M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
+       lea       rbx,[rcx+8]
+       mov       rdx,[rbx]
        mov       rax,rdx
-       mov       r8d,[rdi+10]
+       mov       r8d,[rbx+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       near ptr M00_L19
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
        je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L08:
-       test      r15d,r15d
+       test      r14d,r14d
        je        short M00_L07
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L20
 M00_L09:
-       xor       r15d,r15d
+       xor       r14d,r14d
        jmp       short M00_L08
 M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
+       cmp       [rcx],r15
+       je        short M00_L11
        mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
+       jne       short M00_L12
+       jmp       near ptr M00_L29
+M00_L11:
+       lea       rbx,[rcx+8]
+       mov       rax,[rbx]
+       mov       edx,[rbx+10]
+       mov       r8,[rbx]
        cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
+       jae       near ptr M00_L19
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
+       jne       short M00_L13
+       jmp       short M00_L14
+M00_L12:
        mov       rcx,[rbp-30]
        mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L13:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
+       mov       r14d,eax
        mov       rcx,[rbp-30]
-       jmp       short M00_L18
+       jmp       short M00_L16
+M00_L14:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L15
+       xor       r14d,r14d
+       jmp       short M00_L16
+M00_L15:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       test      r14d,r14d
+       je        near ptr M00_L10
+       jmp       short M00_L20
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
        call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L18:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L19:
+       xor       eax,eax
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L29
+M00_L20:
+       cmp       [rcx],r15
+       jne       near ptr M00_L30
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L23:
+M00_L22:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
        jmp       near ptr M00_L01
-M00_L24:
-       mov       edi,1
+M00_L23:
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L25:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1CC35C00A10
+       mov       rdx,28444000A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CC35C00A18
+       mov       rcx,28444000A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
+M00_L25:
        call      qword ptr [7FFF78537A20]
        int       3
-M00_L27:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CC35C00A98
-       mov       r15,[rcx]
+       mov       rcx,28444000A98
+       mov       r14,[rcx]
        jmp       near ptr M00_L06
-M00_L28:
+M00_L27:
        mov       rcx,rbx
        mov       r11,7FFF78260E98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L29:
+M00_L28:
        mov       rcx,rbx
        mov       r11,7FFF78260E78
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+M00_L29:
+       call      M00_L32
        jmp       near ptr M00_L03
-M00_L31:
+M00_L30:
        mov       r11,7FFF78260E90
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
+       jmp       near ptr M00_L21
+M00_L31:
+       xor       ebx,ebx
        jmp       near ptr M00_L04
-M00_L33:
+M00_L32:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L34
+       je        short M00_L33
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
+       cmp       [rcx],r15
+       je        short M00_L33
        mov       r11,7FFF78260E90
        call      qword ptr [r11]
-M00_L34:
+M00_L33:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 965
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
-       call      qword ptr [7FFF78ADC8D0]
+       call      qword ptr [7FFF78AEC888]
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
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,1CC35C00A18
+       mov       rax,177F2802A10
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
        je        near ptr M00_L32
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        short M00_L01
        add       r15,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78527A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
-M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
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
-M00_L06:
+M00_L03:
        mov       [rbp-30],r15
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[r15+8]
+       mov       rcx,[rbx]
+       mov       rax,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       short M00_L07
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       jae       near ptr M00_L17
+       mov       ecx,r8d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
-       je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       je        short M00_L06
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L05:
+       test      r14d,r14d
+       je        short M00_L04
+       jmp       near ptr M00_L18
+M00_L06:
+       xor       r14d,r14d
+       jmp       short M00_L05
+M00_L07:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78260E80
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       je        short M00_L09
+       mov       rcx,r15
+       mov       r11,7FFF78251048
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
+       jne       short M00_L11
        jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+M00_L09:
+       lea       rbx,[r15+8]
+       mov       rax,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
+       jb        short M00_L10
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+M00_L10:
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       short M00_L17
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78260E88
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,r15
+       mov       r11,7FFF78251050
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L12:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
+       mov       r14d,eax
+       jmp       short M00_L15
+M00_L13:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L14
+       xor       r14d,r14d
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L15:
+       test      r14d,r14d
+       je        near ptr M00_L08
        jmp       short M00_L18
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       call      qword ptr [7FFF7852C150]
+       int       3
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
 M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [r15],rcx
+       jne       near ptr M00_L31
 M00_L19:
-       call      qword ptr [7FFF7853C150]
-       int       3
+       mov       ebx,1
+       jmp       short M00_L24
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       lea       r15,[rbx+10]
+       mov       r14d,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,r14d
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r15+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,r14d
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1CC35C00A10
+       mov       rdx,177F2802A08
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CC35C00A18
+       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,177F2802A10
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78537A20]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CC35C00A98
+       mov       rcx,177F2802AF0
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78260E98
+       mov       r11,7FFF78251060
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78260E78
+       mov       r11,7FFF78251040
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L30:
        call      M00_L33
-       jmp       near ptr M00_L03
+       jmp       near ptr M00_L23
 M00_L31:
-       mov       r11,7FFF78260E90
+       mov       rcx,r15
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L19
 M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
 M00_L33:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
        je        short M00_L34
-       mov       r11,7FFF78260E90
+       mov       rcx,rax
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 962
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
-       call      qword ptr [7FFF78ADC8D0]
+       call      qword ptr [7FFF78ADC990]
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,1CC35C00A18
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
-       jne       short M00_L05
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
-       jb        near ptr M00_L26
-       add       r15,10
+       je        near ptr M00_L20
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
+       jne       short M00_L02
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
+       jb        short M00_L01
+       add       r14,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78537A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L29
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L28
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
+       je        near ptr M00_L08
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
-M00_L06:
-       mov       [rbp-30],r15
-       cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L10
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[rax+8]
+       mov       rcx,[rbx]
+       mov       r8,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
        mov       r14,[rdx+30]
        test      r14,r14
-       je        short M00_L09
+       je        short M00_L07
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       setg      dil
+       movzx     edi,dil
+M00_L05:
+       test      edi,edi
+       je        short M00_L04
+       jmp       near ptr M00_L17
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
 M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78260E80
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L09
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       jne       short M00_L10
+       jmp       near ptr M00_L19
+M00_L09:
+       lea       rbx,[rax+8]
+       mov       r8,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78260E88
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L18
-M00_L16:
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
        mov       r14,[rdx+30]
        test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
+M00_L13:
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
+       setg      dil
+       movzx     edi,dil
+M00_L14:
+       test      edi,edi
+       je        near ptr M00_L08
+       jmp       short M00_L17
+M00_L15:
        call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L17:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L19:
+       call      M00_L30
+       jmp       short M00_L23
+M00_L20:
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,edi
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r14+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,edi
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1CC35C00A10
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CC35C00A18
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78537A20]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CC35C00A98
-       mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78260E98
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
-       mov       rcx,rbx
-       mov       r11,7FFF78260E78
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+       mov       rcx,rax
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78260E90
+M00_L28:
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
-M00_L33:
+       jmp       near ptr M00_L18
+M00_L29:
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78260E90
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L34:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78ADC8D0]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,1E46B800A00
+       mov       rax,28444000A18
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L24
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L31
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
        jne       short M00_L05
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        near ptr M00_L25
        add       r15,10
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
+       xor       ebx,ebx
+       cmp       ebx,r14d
        jge       short M00_L03
 M00_L02:
-       mov       rdx,[r15+rdi*8]
+       mov       rdx,[r15+rbx*8]
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
+       jne       near ptr M00_L23
+       inc       ebx
+       cmp       ebx,r14d
        jl        short M00_L02
 M00_L03:
-       xor       edi,edi
+       xor       ebx,ebx
 M00_L04:
        mov       rcx,[rbp+10]
        mov       rax,[rcx+60]
-       mov       [rax+4C],dil
+       mov       [rax+4C],bl
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
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rbx,[rbx+8]
        cmp       [rbx],rdi
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       je        near ptr M00_L26
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
+       mov       r14,rax
+       mov       edi,[rbx+14]
+       lea       rcx,[r14+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
+       mov       [r14+10],rcx
+       mov       [r14+18],edi
+       mov       [r14+1C],ecx
 M00_L06:
-       mov       [rbp-30],r15
+       mov       [rbp-30],r14
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
+       je        near ptr M00_L10
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
+       cmp       [rcx],r15
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
+       jne       short M00_L10
 M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
+       lea       rbx,[rcx+8]
+       mov       rdx,[rbx]
        mov       rax,rdx
-       mov       r8d,[rdi+10]
+       mov       r8d,[rbx+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       near ptr M00_L19
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
        je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L08:
-       test      r15d,r15d
+       test      r14d,r14d
        je        short M00_L07
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L20
 M00_L09:
-       xor       r15d,r15d
+       xor       r14d,r14d
        jmp       short M00_L08
 M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78230BD8
+       cmp       [rcx],r15
+       je        short M00_L11
+       mov       r11,7FFF78260E80
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
+       jne       short M00_L12
+       jmp       near ptr M00_L29
+M00_L11:
+       lea       rbx,[rcx+8]
+       mov       rax,[rbx]
+       mov       edx,[rbx+10]
+       mov       r8,[rbx]
        cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L17
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
+       jae       near ptr M00_L19
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
+       inc       dword ptr [rbx+14]
        mov       rcx,[rbp-30]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
+       jne       short M00_L13
+       jmp       short M00_L14
+M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF78230BE0
+       mov       r11,7FFF78260E88
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L13:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
+       mov       r14d,eax
        mov       rcx,[rbp-30]
-       jmp       short M00_L18
+       jmp       short M00_L16
+M00_L14:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L15
+       xor       r14d,r14d
+       jmp       short M00_L16
+M00_L15:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       test      r14d,r14d
+       je        near ptr M00_L10
+       jmp       short M00_L20
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7850C150]
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L18:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L19:
+       xor       eax,eax
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L29
+M00_L20:
+       cmp       [rcx],r15
+       jne       near ptr M00_L30
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
-M00_L22:
-       mov       edi,1
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L23:
+M00_L22:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
        jmp       near ptr M00_L01
-M00_L24:
-       mov       edi,1
+M00_L23:
+       mov       ebx,1
        jmp       near ptr M00_L04
-M00_L25:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1E46B8009F8
+       mov       rdx,28444000A10
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E46B800A00
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,28444000A18
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78507A20]
+M00_L25:
+       call      qword ptr [7FFF78537A20]
        int       3
-M00_L27:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1E46B800A18
-       mov       r15,[rcx]
+       mov       rcx,28444000A98
+       mov       r14,[rcx]
        jmp       near ptr M00_L06
-M00_L28:
+M00_L27:
        mov       rcx,rbx
-       mov       r11,7FFF78230BF0
+       mov       r11,7FFF78260E98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L29:
+M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230BD0
+       mov       r11,7FFF78260E78
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+M00_L29:
+       call      M00_L32
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78230BE8
+M00_L30:
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
+       jmp       near ptr M00_L21
+M00_L31:
+       xor       ebx,ebx
        jmp       near ptr M00_L04
-M00_L33:
+M00_L32:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L34
+       je        short M00_L33
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78230BE8
+       cmp       [rcx],r15
+       je        short M00_L33
+       mov       r11,7FFF78260E90
        call      qword ptr [r11]
-M00_L34:
+M00_L33:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 965
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
-       call      qword ptr [7FFF78A9DC08]
+       call      qword ptr [7FFF78AEC888]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,1E46B800A00
+       mov       rax,177F2802A10
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
        je        near ptr M00_L32
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L26
+       jb        short M00_L01
        add       r15,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78527A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
-M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
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
-M00_L06:
+M00_L03:
        mov       [rbp-30],r15
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[r15+8]
+       mov       rcx,[rbx]
+       mov       rax,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L10
+       jae       short M00_L07
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       jae       near ptr M00_L17
+       mov       ecx,r8d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r14,[rdx+30]
-       test      r14,r14
-       je        short M00_L09
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       je        short M00_L06
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L05:
+       test      r14d,r14d
+       je        short M00_L04
+       jmp       near ptr M00_L18
+M00_L06:
+       xor       r14d,r14d
+       jmp       short M00_L05
+M00_L07:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78230BD8
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       je        short M00_L09
+       mov       rcx,r15
+       mov       r11,7FFF78251048
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
+       jne       short M00_L11
        jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
+M00_L09:
+       lea       rbx,[r15+8]
+       mov       rax,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jb        short M00_L13
+       jb        short M00_L10
        xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
        jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+M00_L10:
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       short M00_L17
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78230BE0
+       inc       dword ptr [rbx+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,r15
+       mov       r11,7FFF78251050
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L12:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
+       mov       r14d,eax
+       jmp       short M00_L15
+M00_L13:
+       mov       rdi,[rdx+30]
+       test      rdi,rdi
+       jne       short M00_L14
+       xor       r14d,r14d
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [rdi+8],0
+       setg      r14b
+       movzx     r14d,r14b
+M00_L15:
+       test      r14d,r14d
+       je        near ptr M00_L08
        jmp       short M00_L18
 M00_L16:
-       mov       r14,[rdx+30]
-       test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
+       call      qword ptr [7FFF7852C150]
+       int       3
 M00_L17:
-       cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
 M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [r15],rcx
+       jne       near ptr M00_L31
 M00_L19:
-       call      qword ptr [7FFF7850C150]
-       int       3
+       mov       ebx,1
+       jmp       short M00_L24
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       lea       r15,[rbx+10]
+       mov       r14d,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,r14d
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r15+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,r14d
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1E46B8009F8
+       mov       rdx,177F2802A08
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E46B800A00
+       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,177F2802A10
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78507A20]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1E46B800A18
+       mov       rcx,177F2802AF0
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78230BF0
+       mov       r11,7FFF78251060
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230BD0
+       mov       r11,7FFF78251040
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L03
 M00_L30:
        call      M00_L33
-       jmp       near ptr M00_L03
+       jmp       near ptr M00_L23
 M00_L31:
-       mov       r11,7FFF78230BE8
+       mov       rcx,r15
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L19
 M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
 M00_L33:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
        je        short M00_L34
-       mov       r11,7FFF78230BE8
+       mov       rcx,rax
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
 M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 962
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
-       call      qword ptr [7FFF78A9DC08]
+       call      qword ptr [7FFF78ADC990]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,1E46B800A00
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L23
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
-       jne       short M00_L05
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
-       jb        near ptr M00_L26
-       add       r15,10
+       je        near ptr M00_L20
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
+       jne       short M00_L02
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
+       jb        short M00_L01
+       add       r14,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       edi,edi
-       cmp       edi,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78537A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rdi*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L24
-       inc       edi
-       cmp       edi,r14d
-       jl        short M00_L02
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       xor       edi,edi
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],dil
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L29
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L28
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
+       je        near ptr M00_L08
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
-M00_L06:
-       mov       [rbp-30],r15
-       cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       rdi,[rcx+8]
-       mov       rdx,[rdi]
-       mov       rax,rdx
-       mov       r8d,[rdi+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L10
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
-       lea       rcx,[rdi+8]
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[rax+8]
+       mov       rcx,[rbx]
+       mov       r8,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
+       mov       rdx,[rsi+rcx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
        mov       r14,[rdx+30]
        test      r14,r14
-       je        short M00_L09
+       je        short M00_L07
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
+       setg      dil
+       movzx     edi,dil
+M00_L05:
+       test      edi,edi
+       je        short M00_L04
+       jmp       near ptr M00_L17
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
 M00_L08:
-       test      r15d,r15d
-       je        short M00_L07
-       jmp       near ptr M00_L21
-M00_L09:
-       xor       r15d,r15d
-       jmp       short M00_L08
-M00_L10:
-       xor       edx,edx
-       mov       [rdi+8],rdx
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L11:
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,rdx
-       je        short M00_L12
-       mov       r11,7FFF78230BD8
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L09
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L14
-       jmp       near ptr M00_L30
-M00_L12:
-       lea       rdi,[rcx+8]
-       mov       rax,[rdi]
-       mov       edx,[rdi+10]
-       mov       r8,[rdi]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L19
-       mov       r8d,[rdi+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L13
-       xor       eax,eax
-       mov       [rdi+8],rax
-       mov       dword ptr [rdi+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L13:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[rdi+8]
+       jne       short M00_L10
+       jmp       near ptr M00_L19
+M00_L09:
+       lea       rbx,[rax+8]
+       mov       r8,[rbx]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [rdi+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L15
-       jmp       short M00_L16
-M00_L14:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78230BE0
+       inc       dword ptr [rbx+14]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r15d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L18
-M00_L16:
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
        mov       r14,[rdx+30]
        test      r14,r14
-       jne       short M00_L17
-       xor       r15d,r15d
-       jmp       short M00_L18
-M00_L17:
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
+M00_L13:
        cmp       dword ptr [r14+8],0
-       setg      r15b
-       movzx     r15d,r15b
-M00_L18:
-       test      r15d,r15d
-       je        near ptr M00_L11
-       jmp       short M00_L21
-M00_L19:
-       call      qword ptr [7FFF7850C150]
+       setg      dil
+       movzx     edi,dil
+M00_L14:
+       test      edi,edi
+       je        near ptr M00_L08
+       jmp       short M00_L17
+M00_L15:
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L20:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L17:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L19:
+       call      M00_L30
+       jmp       short M00_L23
+M00_L20:
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       jne       near ptr M00_L31
+       xor       ebx,ebx
+       cmp       ebx,edi
+       jge       short M00_L23
 M00_L22:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rdx,[r14+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,edi
+       jl        short M00_L22
 M00_L23:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       xor       ebx,ebx
 M00_L24:
-       mov       edi,1
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       rbp
+       ret
 M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1E46B8009F8
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF782E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E46B800A00
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L26:
-       call      qword ptr [7FFF78507A20]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1E46B800A18
-       mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L28:
-       mov       rcx,rbx
-       mov       r11,7FFF78230BF0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78230BD0
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L30:
-       call      M00_L33
+       mov       rcx,rax
        jmp       near ptr M00_L03
-M00_L31:
-       mov       r11,7FFF78230BE8
+M00_L28:
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       jmp       near ptr M00_L22
-M00_L32:
-       xor       edi,edi
-       jmp       near ptr M00_L04
-M00_L33:
+       jmp       near ptr M00_L18
+M00_L29:
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L34
-       mov       rcx,[rbp-30]
-       mov       rbx,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rbx,r11
-       je        short M00_L34
-       mov       r11,7FFF78230BE8
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L34:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78A9DC08]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF782E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
-       mov       rax,28444000A18
+       mov       rax,177F2802A10
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L24
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L31
+       je        near ptr M00_L32
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L20
        mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rdi
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r14d,[rbx+10]
        mov       r15,[rbx+8]
        cmp       [r15+8],r14d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r15,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       ebx,ebx
-       cmp       ebx,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78527A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rbx*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L23
-       inc       ebx
-       cmp       ebx,r14d
-       jl        short M00_L02
-M00_L03:
-       xor       ebx,ebx
-M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],bl
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rbx],rax
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
        mov       rbx,[rbx+8]
        cmp       [rbx],rdi
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L26
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
+       je        near ptr M00_L27
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       edi,[rbx+14]
-       lea       rcx,[r14+8]
+       mov       r15,rax
+       mov       r14d,[rbx+14]
+       lea       rcx,[r15+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],edi
-       mov       [r14+1C],ecx
-M00_L06:
-       mov       [rbp-30],r14
+       mov       [r15+10],rcx
+       mov       [r15+18],r14d
+       mov       [r15+1C],ecx
+M00_L03:
+       mov       [rbp-30],r15
        cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L10
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,[rbp-30]
-       cmp       [rcx],r15
-       jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       short M00_L10
-M00_L07:
-       lea       rbx,[rcx+8]
-       mov       rdx,[rbx]
-       mov       rax,rdx
-       mov       r8d,[rbx+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
+M00_L04:
+       lea       rbx,[r15+8]
+       mov       rcx,[rbx]
+       mov       rax,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
        mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L19
+       jae       short M00_L07
        mov       rsi,[rax+8]
        cmp       r8d,[rsi+8]
-       jae       near ptr M00_L18
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
+       jae       near ptr M00_L17
+       mov       ecx,r8d
+       mov       rdx,[rsi+rcx*8+10]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [rbx+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
+       mov       rdx,[r15+10]
        mov       rdi,[rdx+30]
        test      rdi,rdi
-       je        short M00_L09
+       je        short M00_L06
        cmp       dword ptr [rdi+8],0
        setg      r14b
        movzx     r14d,r14b
-M00_L08:
+M00_L05:
        test      r14d,r14d
-       je        short M00_L07
-       jmp       near ptr M00_L20
-M00_L09:
+       je        short M00_L04
+       jmp       near ptr M00_L18
+M00_L06:
        xor       r14d,r14d
-       jmp       short M00_L08
-M00_L10:
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,[rbp-30]
-       cmp       [rcx],r15
-       je        short M00_L11
-       mov       r11,7FFF78260E80
+       jmp       short M00_L05
+M00_L07:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L30
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r15,[rbp-30]
+       cmp       [r15],rcx
+       je        short M00_L09
+       mov       rcx,r15
+       mov       r11,7FFF78251048
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L12
-       jmp       near ptr M00_L29
-M00_L11:
-       lea       rbx,[rcx+8]
+       jne       short M00_L11
+       jmp       near ptr M00_L30
+M00_L09:
+       lea       rbx,[r15+8]
        mov       rax,[rbx]
-       mov       edx,[rbx+10]
-       mov       r8,[rbx]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L17
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L16
        mov       r8d,[rbx+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L19
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
+       jb        short M00_L10
+       xor       eax,eax
+       mov       [rbx+8],rax
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L30
+M00_L10:
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       short M00_L17
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [rbx+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L13
-       jmp       short M00_L14
-M00_L12:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78260E88
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,r15
+       mov       r11,7FFF78251050
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L13:
+M00_L12:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        mov       r14d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L16
-M00_L14:
+       jmp       short M00_L15
+M00_L13:
        mov       rdi,[rdx+30]
        test      rdi,rdi
-       jne       short M00_L15
+       jne       short M00_L14
        xor       r14d,r14d
-       jmp       short M00_L16
-M00_L15:
+       jmp       short M00_L15
+M00_L14:
        cmp       dword ptr [rdi+8],0
        setg      r14b
        movzx     r14d,r14b
-M00_L16:
+M00_L15:
        test      r14d,r14d
-       je        near ptr M00_L10
-       jmp       short M00_L20
-M00_L17:
-       call      qword ptr [7FFF7853C150]
+       je        near ptr M00_L08
+       jmp       short M00_L18
+M00_L16:
+       call      qword ptr [7FFF7852C150]
        int       3
-M00_L18:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L18:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [r15],rcx
+       jne       near ptr M00_L31
 M00_L19:
-       xor       eax,eax
-       mov       [rbx+8],rax
-       mov       dword ptr [rbx+14],0FFFFFFFF
-       jmp       near ptr M00_L29
-M00_L20:
-       cmp       [rcx],r15
-       jne       near ptr M00_L30
-M00_L21:
        mov       ebx,1
-       jmp       near ptr M00_L04
-M00_L22:
+       jmp       short M00_L24
+M00_L20:
        lea       r15,[rbx+10]
        mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       xor       ebx,ebx
+       cmp       ebx,r14d
+       jge       short M00_L23
+M00_L22:
+       mov       rdx,[r15+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,r14d
+       jl        short M00_L22
 M00_L23:
-       mov       ebx,1
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
 M00_L24:
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,28444000A10
+       mov       rdx,177F2802A08
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28444000A18
+       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,177F2802A10
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FFF78537A20]
-       int       3
-M00_L26:
+M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,28444000A98
-       mov       r14,[rcx]
-       jmp       near ptr M00_L06
-M00_L27:
-       mov       rcx,rbx
-       mov       r11,7FFF78260E98
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L06
+       mov       rcx,177F2802AF0
+       mov       r15,[rcx]
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,rbx
-       mov       r11,7FFF78260E78
+       mov       r11,7FFF78251060
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L06
+       mov       r15,rax
+       jmp       near ptr M00_L03
 M00_L29:
-       call      M00_L32
+       mov       rcx,rbx
+       mov       r11,7FFF78251040
+       call      qword ptr [r11]
+       mov       r15,rax
        jmp       near ptr M00_L03
 M00_L30:
-       mov       r11,7FFF78260E90
-       call      qword ptr [r11]
-       jmp       near ptr M00_L21
+       call      M00_L33
+       jmp       near ptr M00_L23
 M00_L31:
-       xor       ebx,ebx
-       jmp       near ptr M00_L04
+       mov       rcx,r15
+       mov       r11,7FFF78251058
+       call      qword ptr [r11]
+       jmp       near ptr M00_L19
 M00_L32:
+       xor       ebx,ebx
+       jmp       near ptr M00_L24
+M00_L33:
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L33
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,[rbp-30]
-       cmp       [rcx],r15
-       je        short M00_L33
-       mov       r11,7FFF78260E90
+       je        short M00_L34
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        short M00_L34
+       mov       rcx,rax
+       mov       r11,7FFF78251058
        call      qword ptr [r11]
-M00_L33:
+M00_L34:
        nop
        add       rsp,28
        ret
-; Total bytes of code 965
+; Total bytes of code 962
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
-       call      qword ptr [7FFF78AEC888]
+       call      qword ptr [7FFF78ADC990]
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,28444000A18
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
-       je        near ptr M00_L24
+       je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L31
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
-       je        near ptr M00_L22
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
-       jne       short M00_L05
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
-       jb        near ptr M00_L25
-       add       r15,10
+       je        near ptr M00_L20
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
+       jne       short M00_L02
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
+       jb        short M00_L01
+       add       r14,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       ebx,ebx
-       cmp       ebx,r14d
-       jge       short M00_L03
+       call      qword ptr [7FFF78537A20]
+       int       3
 M00_L02:
-       mov       rdx,[r15+rbx*8]
-       mov       rcx,[rsi+8]
-       call      qword ptr [rsi+18]
-       test      eax,eax
-       jne       near ptr M00_L23
-       inc       ebx
-       cmp       ebx,r14d
-       jl        short M00_L02
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       xor       ebx,ebx
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
+       je        near ptr M00_L08
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       jne       near ptr M00_L08
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       near ptr M00_L08
 M00_L04:
-       mov       rcx,[rbp+10]
-       mov       rax,[rcx+60]
-       mov       [rax+4C],bl
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L05:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L28
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L27
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L26
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       edi,[rbx+14]
-       lea       rcx,[r14+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r14+10],rcx
-       mov       [r14+18],edi
-       mov       [r14+1C],ecx
-M00_L06:
-       mov       [rbp-30],r14
-       cmp       qword ptr [rbp-30],0
-       je        near ptr M00_L10
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,[rbp-30]
-       cmp       [rcx],r15
-       jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],rdx
-       jne       short M00_L10
-M00_L07:
-       lea       rbx,[rcx+8]
-       mov       rdx,[rbx]
-       mov       rax,rdx
-       mov       r8d,[rbx+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
-       mov       r8d,[rbx+14]
-       cmp       r8d,[rax+10]
-       jae       near ptr M00_L19
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L18
-       mov       edx,r8d
-       mov       rdx,[rsi+rdx*8+10]
+       lea       rbx,[rax+8]
+       mov       rcx,[rbx]
+       mov       r8,rcx
+       mov       edx,[rbx+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
+       mov       rdx,[rsi+rcx*8+10]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [rbx+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       rdi,[rdx+30]
-       test      rdi,rdi
-       je        short M00_L09
-       cmp       dword ptr [rdi+8],0
-       setg      r14b
-       movzx     r14d,r14b
-M00_L08:
-       test      r14d,r14d
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       r14,[rdx+30]
+       test      r14,r14
        je        short M00_L07
-       jmp       near ptr M00_L20
-M00_L09:
-       xor       r14d,r14d
-       jmp       short M00_L08
-M00_L10:
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,[rbp-30]
-       cmp       [rcx],r15
-       je        short M00_L11
-       mov       r11,7FFF78260E80
+       cmp       dword ptr [r14+8],0
+       setg      dil
+       movzx     edi,dil
+M00_L05:
+       test      edi,edi
+       je        short M00_L04
+       jmp       near ptr M00_L17
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbx+8],rcx
+       mov       dword ptr [rbx+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
+M00_L08:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L09
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L12
-       jmp       near ptr M00_L29
-M00_L11:
-       lea       rbx,[rcx+8]
-       mov       rax,[rbx]
-       mov       edx,[rbx+10]
+       jne       short M00_L10
+       jmp       near ptr M00_L19
+M00_L09:
+       lea       rbx,[rax+8]
        mov       r8,[rbx]
-       cmp       edx,[r8+14]
-       jne       near ptr M00_L17
-       mov       r8d,[rbx+14]
-       cmp       r8d,[rax+10]
-       jae       near ptr M00_L19
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
+       mov       ecx,[rbx+10]
+       mov       rdx,[rbx]
+       cmp       ecx,[rdx+14]
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
+       mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [rbx+14]
-       mov       rcx,[rbp-30]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rsi+18],r11
-       jne       short M00_L13
-       jmp       short M00_L14
-M00_L12:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF78260E88
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rsi+18],rcx
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L13:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r14d,eax
-       mov       rcx,[rbp-30]
-       jmp       short M00_L16
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
+       mov       r14,[rdx+30]
+       test      r14,r14
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
+M00_L13:
+       cmp       dword ptr [r14+8],0
+       setg      dil
+       movzx     edi,dil
 M00_L14:
-       mov       rdi,[rdx+30]
-       test      rdi,rdi
-       jne       short M00_L15
-       xor       r14d,r14d
-       jmp       short M00_L16
+       test      edi,edi
+       je        near ptr M00_L08
+       jmp       short M00_L17
 M00_L15:
-       cmp       dword ptr [rdi+8],0
-       setg      r14b
-       movzx     r14d,r14b
-M00_L16:
-       test      r14d,r14d
-       je        near ptr M00_L10
-       jmp       short M00_L20
-M00_L17:
        call      qword ptr [7FFF7853C150]
        int       3
-M00_L18:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
+M00_L17:
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
+       mov       ebx,1
+       jmp       short M00_L24
 M00_L19:
-       xor       eax,eax
-       mov       [rbx+8],rax
-       mov       dword ptr [rbx+14],0FFFFFFFF
-       jmp       near ptr M00_L29
+       call      M00_L30
+       jmp       short M00_L23
 M00_L20:
-       cmp       [rcx],r15
-       jne       near ptr M00_L30
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
-       mov       ebx,1
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
+       cmp       ebx,edi
+       jge       short M00_L23
 M00_L22:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
-       jmp       near ptr M00_L01
+       mov       rdx,[r14+rbx*8]
+       mov       rcx,[rsi+8]
+       call      qword ptr [rsi+18]
+       test      eax,eax
+       jne       short M00_L25
+       inc       ebx
+       cmp       ebx,edi
+       jl        short M00_L22
 M00_L23:
-       mov       ebx,1
-       jmp       near ptr M00_L04
+       xor       ebx,ebx
 M00_L24:
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+60]
+       mov       [rax+4C],bl
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       rbp
+       ret
+M00_L25:
+       mov       ebx,1
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,28444000A10
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28444000A18
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FFF78537A20]
-       int       3
-M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,28444000A98
-       mov       r14,[rcx]
-       jmp       near ptr M00_L06
 M00_L27:
        mov       rcx,rbx
-       mov       r11,7FFF78260E98
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L06
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,rbx
-       mov       r11,7FFF78260E78
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L18
 M00_L29:
-       call      M00_L32
-       jmp       near ptr M00_L03
-M00_L30:
-       mov       r11,7FFF78260E90
-       call      qword ptr [r11]
-       jmp       near ptr M00_L21
-M00_L31:
        xor       ebx,ebx
-       jmp       near ptr M00_L04
-M00_L32:
+       jmp       near ptr M00_L24
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L33
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,[rbp-30]
-       cmp       [rcx],r15
-       je        short M00_L33
-       mov       r11,7FFF78260E90
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L33:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 965
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78AEC888]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF78315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmptyWithPredicate()
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        lea       rbp,[rsp+50]
        mov       [rbp+10],rcx
        mov       rbx,[rcx+278]
-       mov       rax,177F2802A10
+       mov       rax,15186800AC0
        mov       rsi,[rax]
        test      rsi,rsi
        je        near ptr M00_L26
 M00_L00:
        test      rbx,rbx
-       je        near ptr M00_L32
+       je        near ptr M00_L29
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rbx],rax
        je        near ptr M00_L20
-       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rdi
+       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],rax
        jne       short M00_L02
-       mov       r14d,[rbx+10]
-       mov       r15,[rbx+8]
-       cmp       [r15+8],r14d
+       mov       edi,[rbx+10]
+       mov       r14,[rbx+8]
+       cmp       [r14+8],edi
        jb        short M00_L01
-       add       r15,10
+       add       r14,10
        jmp       near ptr M00_L21
 M00_L01:
-       call      qword ptr [7FFF78527A20]
+       call      qword ptr [7FFF78537A20]
        int       3
 M00_L02:
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rbx],rax
-       jne       near ptr M00_L29
-       mov       rbx,[rbx+8]
-       cmp       [rbx],rdi
-       jne       near ptr M00_L28
-       cmp       dword ptr [rbx+10],0
-       je        near ptr M00_L27
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r14d,[rbx+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r14d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rbx],r11
+       jne       near ptr M00_L27
+       mov       rcx,[rbx+8]
+       mov       r11,7FFF782612E8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       mov       [rbp-30],r15
-       cmp       qword ptr [rbp-30],0
+       mov       [rbp-28],rcx
+       cmp       qword ptr [rbp-28],0
        je        near ptr M00_L08
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r15,[rbp-30]
-       cmp       [r15],rcx
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
        jne       near ptr M00_L08
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rcx
        jne       near ptr M00_L08
 M00_L04:
-       lea       rbx,[r15+8]
+       lea       rbx,[rax+8]
        mov       rcx,[rbx]
-       mov       rax,rcx
+       mov       r8,rcx
        mov       edx,[rbx+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L16
-       mov       r8d,[rbx+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rsi,[rax+8]
-       cmp       r8d,[rsi+8]
-       jae       near ptr M00_L17
-       mov       ecx,r8d
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rsi,[r8+8]
+       cmp       r10d,[rsi+8]
+       jae       near ptr M00_L16
+       mov       ecx,r10d
        mov       rdx,[rsi+rcx*8+10]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [rbx+14]
-       mov       rdx,[r15+10]
-       mov       rdi,[rdx+30]
-       test      rdi,rdi
-       je        short M00_L06
-       cmp       dword ptr [rdi+8],0
-       setg      r14b
-       movzx     r14d,r14b
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
+       mov       r14,[rdx+30]
+       test      r14,r14
+       je        short M00_L07
+       cmp       dword ptr [r14+8],0
+       setg      dil
+       movzx     edi,dil
 M00_L05:
-       test      r14d,r14d
+       test      edi,edi
        je        short M00_L04
-       jmp       near ptr M00_L18
+       jmp       near ptr M00_L17
 M00_L06:
-       xor       r14d,r14d
-       jmp       short M00_L05
-M00_L07:
        xor       ecx,ecx
        mov       [rbx+8],rcx
        mov       dword ptr [rbx+14],0FFFFFFFF
-       jmp       near ptr M00_L30
+       jmp       near ptr M00_L19
+M00_L07:
+       xor       edi,edi
+       jmp       short M00_L05
 M00_L08:
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r15,[rbp-30]
-       cmp       [r15],rcx
+       mov       rax,[rbp-28]
+       cmp       [rax],rcx
        je        short M00_L09
-       mov       rcx,r15
-       mov       r11,7FFF78251048
+       mov       rcx,rax
+       mov       r11,7FFF782612D0
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L11
-       jmp       near ptr M00_L30
+       jne       short M00_L10
+       jmp       near ptr M00_L19
 M00_L09:
-       lea       rbx,[r15+8]
-       mov       rax,[rbx]
+       lea       rbx,[rax+8]
+       mov       r8,[rbx]
        mov       ecx,[rbx+10]
        mov       rdx,[rbx]
        cmp       ecx,[rdx+14]
-       jne       near ptr M00_L16
-       mov       r8d,[rbx+14]
-       cmp       r8d,[rax+10]
-       jb        short M00_L10
-       xor       eax,eax
-       mov       [rbx+8],rax
-       mov       dword ptr [rbx+14],0FFFFFFFF
-       jmp       near ptr M00_L30
-M00_L10:
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
-       jae       short M00_L17
-       mov       edx,r8d
+       jne       near ptr M00_L15
+       mov       r10d,[rbx+14]
+       cmp       r10d,[r8+10]
+       jae       short M00_L06
+       mov       rcx,[r8+8]
+       cmp       r10d,[rcx+8]
+       jae       near ptr M00_L16
+       mov       edx,r10d
        mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [rbx+14]
-       mov       rdx,[r15+10]
+       mov       rax,[rbp-28]
+       mov       rdx,[rax+10]
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rsi+18],rcx
-       jne       short M00_L12
-       jmp       short M00_L13
-M00_L11:
-       mov       rcx,r15
-       mov       r11,7FFF78251050
+       jne       short M00_L11
+       jmp       short M00_L12
+M00_L10:
+       mov       rcx,[rbp-28]
+       mov       r11,7FFF782612D8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L12:
+M00_L11:
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
-       mov       r14d,eax
-       jmp       short M00_L15
+       mov       edi,eax
+       mov       rax,[rbp-28]
+       jmp       short M00_L14
+M00_L12:
+       mov       r14,[rdx+30]
+       test      r14,r14
+       jne       short M00_L13
+       xor       edi,edi
+       jmp       short M00_L14
 M00_L13:
-       mov       rdi,[rdx+30]
-       test      rdi,rdi
-       jne       short M00_L14
-       xor       r14d,r14d
-       jmp       short M00_L15
+       cmp       dword ptr [r14+8],0
+       setg      dil
+       movzx     edi,dil
 M00_L14:
-       cmp       dword ptr [rdi+8],0
-       setg      r14b
-       movzx     r14d,r14b
-M00_L15:
-       test      r14d,r14d
+       test      edi,edi
        je        near ptr M00_L08
-       jmp       short M00_L18
-M00_L16:
-       call      qword ptr [7FFF7852C150]
+       jmp       short M00_L17
+M00_L15:
+       call      qword ptr [7FFF7853C150]
        int       3
-M00_L17:
+M00_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L18:
+M00_L17:
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       [r15],rcx
-       jne       near ptr M00_L31
-M00_L19:
+       cmp       [rax],rcx
+       jne       near ptr M00_L28
+M00_L18:
        mov       ebx,1
        jmp       short M00_L24
+M00_L19:
+       call      M00_L30
+       jmp       short M00_L23
 M00_L20:
-       lea       r15,[rbx+10]
-       mov       r14d,[rbx+8]
+       lea       r14,[rbx+10]
+       mov       edi,[rbx+8]
 M00_L21:
        xor       ebx,ebx
-       cmp       ebx,r14d
+       cmp       ebx,edi
        jge       short M00_L23
 M00_L22:
-       mov       rdx,[r15+rbx*8]
+       mov       rdx,[r14+rbx*8]
        mov       rcx,[rsi+8]
        call      qword ptr [rsi+18]
        test      eax,eax
        jne       short M00_L25
        inc       ebx
-       cmp       ebx,r14d
+       cmp       ebx,edi
        jl        short M00_L22
 M00_L23:
        xor       ebx,ebx
 M00_L24:
        mov       rcx,[rbp+10]
        mov       rax,[rcx+60]
        mov       [rax+4C],bl
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        pop       rbp
        ret
 M00_L25:
        mov       ebx,1
        jmp       short M00_L24
 M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,177F2802A08
+       mov       rdx,15186800AB8
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFF78306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,177F2802A10
+       call      qword ptr [7FFF78316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15186800AC0
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,177F2802AF0
-       mov       r15,[rcx]
-       jmp       near ptr M00_L03
-M00_L28:
-       mov       rcx,rbx
-       mov       r11,7FFF78251060
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L03
-M00_L29:
        mov       rcx,rbx
-       mov       r11,7FFF78251040
+       mov       r11,7FFF782612C8
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L03
-M00_L30:
-       call      M00_L33
-       jmp       near ptr M00_L23
-M00_L31:
-       mov       rcx,r15
-       mov       r11,7FFF78251058
+M00_L28:
+       mov       rcx,rax
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-       jmp       near ptr M00_L19
-M00_L32:
+       jmp       near ptr M00_L18
+M00_L29:
        xor       ebx,ebx
        jmp       near ptr M00_L24
-M00_L33:
+M00_L30:
        sub       rsp,28
-       cmp       qword ptr [rbp-30],0
-       je        short M00_L34
+       cmp       qword ptr [rbp-28],0
+       je        short M00_L31
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-28]
        cmp       [rax],rcx
-       je        short M00_L34
+       je        short M00_L31
        mov       rcx,rax
-       mov       r11,7FFF78251058
+       mov       r11,7FFF782612E0
        call      qword ptr [r11]
-M00_L34:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 962
+; Total bytes of code 839
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
-       call      qword ptr [7FFF78ADC990]
+       call      qword ptr [7FFF789E5998]
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
-       jmp       qword ptr [7FFF78305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78250E30
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78230E30
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78270E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78250E30
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78240E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78250F90
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78260E30
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78230E30
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78270E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78240E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78250F90
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78230E30
+       mov       r11,7FFF78270E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78230E30
+       mov       r11,7FFF78250E30
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78230E30
+       mov       r11,7FFF78240E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78230E30
+       mov       r11,7FFF78250F90
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78230E30
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78270E28
+       mov       r11,7FFF78250E30
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78270E28
+       mov       r11,7FFF78240E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78270E28
+       mov       r11,7FFF78250F90
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78270E28
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78240E28
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78250F90
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250E30
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78240E28
+       mov       r11,7FFF78250F90
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78240E28
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF78250F90
+       mov       r11,7FFF78241280
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
