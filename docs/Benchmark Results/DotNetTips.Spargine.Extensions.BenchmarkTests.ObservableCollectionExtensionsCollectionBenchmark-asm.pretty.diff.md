## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20260419-033629
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
-       mov       r11,7FF92DE41020
+       mov       rcx,rdi
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E11C9F0]
+       call      qword ptr [7FF92E13C150]
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2861EC02000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE41030
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE41018
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
 M00_L18:
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
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
-       mov       r11,7FF92DE41020
+       mov       rcx,rdi
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E11C9F0]
+       call      qword ptr [7FF92E13C150]
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BDDE402000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE41030
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE41018
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
 M00_L18:
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
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
-       mov       r11,7FF92DE41020
+       mov       rcx,rdi
+       mov       r11,7FF92DE70D90
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E11C9F0]
+       call      qword ptr [7FF92E14C150]
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1D6FDC02000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE41030
+       mov       r11,7FF92DE70DA0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE41018
+       mov       r11,7FF92DE70D88
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE70D98
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
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE70D98
        call      qword ptr [r11]
 M00_L18:
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
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E14C150]
+       int       3
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FF92DE41020
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F38
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E11C9F0]
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
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2304CC02000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE70F30
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F40
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
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
-       mov       r11,7FF92DE41030
+       mov       r11,7FF92DE70F40
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE41018
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
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
-       mov       r11,7FF92DE41028
-       call      qword ptr [r11]
-M00_L18:
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
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E11C150]
+       int       3
 M00_L06:
-       mov       rcx,r14
-       mov       r11,7FF92DE41020
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DB8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E11C9F0]
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
+       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20003802000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE40DB0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC0
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
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
-       mov       r11,7FF92DE41030
+       mov       r11,7FF92DE40DC0
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE41018
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
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
-       mov       r11,7FF92DE41028
-       call      qword ptr [r11]
-M00_L18:
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
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
-       jne       near ptr M00_L07
-       mov       r8d,[rdi+14]
+       jne       near ptr M00_L06
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
-       jne       short M00_L06
-       lea       rdi,[r14+8]
-       mov       rcx,[rdi]
+       cmp       [rdi],r14
+       jne       short M00_L07
+       lea       r15,[rdi+8]
+       mov       rcx,[r15]
        mov       rax,rcx
-       mov       edx,[rdi+10]
+       mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
-       mov       r8d,[rdi+14]
+       jne       short M00_L06
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
-       mov       r11,7FF92DE41020
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L07:
+       mov       rcx,rdi
+       mov       r11,7FF92DE61190
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
-M00_L07:
-       call      qword ptr [7FF92E11C9F0]
-       int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
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
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
+       mov       rcx,138A7800A98
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE41030
+       mov       r11,7FF92DE611A0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE41018
+       mov       r11,7FF92DE61188
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
        jmp       short M00_L11
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
-       mov       r11,7FF92DE41028
+       mov       rcx,rdi
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 591
+; Total bytes of code 595
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       mov       r11,7FF92DE41020
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E11C9F0]
+       call      qword ptr [7FF92E14C150]
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20A2DC02AA0
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE41030
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE41018
+       mov       r11,7FF92DE71938
        call      qword ptr [r11]
-       mov       r14,rax
+       mov       rcx,rax
        jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,r14
-       mov       r11,7FF92DE41028
+M00_L14:
+       mov       r11,7FF92DE71948
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
-       mov       r11,7FF92DE41028
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
        call      qword ptr [r11]
-M00_L18:
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
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2861EC02000
+       mov       rcx,1BDDE402000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE70D90
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E13C150]
+       call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2861EC02000
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1D6FDC02000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE70DA0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE60F10
+       mov       r11,7FF92DE70D88
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE70D98
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE70D98
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E14C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE70F38
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E13C150]
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
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2304CC02000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE70F30
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F40
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2861EC02000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F28
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE60F10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE70F40
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E11C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE40DB8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E13C150]
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
+       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20003802000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE40DB0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC0
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2861EC02000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F28
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE60F10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE40DC0
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
+       jne       near ptr M00_L06
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
        mov       rdi,[rbp-38]
        cmp       [rdi],edi
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
        cmp       [rdi],r14
-       jne       short M00_L06
+       jne       short M00_L07
        lea       r15,[rdi+8]
        mov       rcx,[r15]
        mov       rax,rcx
        mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
+       jne       short M00_L06
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
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L07:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE61190
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
-M00_L07:
-       call      qword ptr [7FF92E13C150]
-       int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2861EC02000
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,138A7800A98
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE611A0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE60F10
+       mov       r11,7FF92DE61188
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
-       jmp       near ptr M00_L11
+       jmp       short M00_L11
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 595
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E13C150]
+       call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2861EC02000
-       mov       r14,[rcx]
+       mov       r11,7FF92DE71938
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE71948
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FF92DE60F10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE60F20
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE70D90
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E13C150]
+       call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDDE402000
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1D6FDC02000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE70DA0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE60F10
+       mov       r11,7FF92DE70D88
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE70D98
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE70D98
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E14C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE70F38
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E13C150]
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
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2304CC02000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE70F30
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F40
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDDE402000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F28
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE60F10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE70F40
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E11C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE40DB8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E13C150]
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
+       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20003802000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE40DB0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC0
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDDE402000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F28
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE60F10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE40DC0
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
+       jne       near ptr M00_L06
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
        mov       rdi,[rbp-38]
        cmp       [rdi],edi
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
        cmp       [rdi],r14
-       jne       short M00_L06
+       jne       short M00_L07
        lea       r15,[rdi+8]
        mov       rcx,[r15]
        mov       rax,rcx
        mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
+       jne       short M00_L06
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
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L07:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE61190
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
-M00_L07:
-       call      qword ptr [7FF92E13C150]
-       int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDDE402000
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,138A7800A98
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE611A0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE60F10
+       mov       r11,7FF92DE61188
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
-       jmp       near ptr M00_L11
+       jmp       short M00_L11
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
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 595
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
-       call      qword ptr [7FF92E13C150]
+       call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDDE402000
-       mov       r14,[rcx]
+       mov       r11,7FF92DE71938
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE71948
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FF92DE60F10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE60F20
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
-       mov       r11,7FF92DE60F20
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E14C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE70D90
+       mov       r11,7FF92DE70F38
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E14C150]
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
+       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2304CC02000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F48
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE70F30
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE70F40
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
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1D6FDC02000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70DA0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE70D88
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70D98
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
-       mov       r11,7FF92DE70D98
+       mov       r11,7FF92DE70F40
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       call      qword ptr [7FF92E11C150]
+       int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE70D90
+       mov       r11,7FF92DE40DB8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L10
+       jmp       short M00_L13
 M00_L07:
-       call      qword ptr [7FF92E14C150]
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
+       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20003802000
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
 M00_L11:
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC8
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L12:
+       mov       r11,7FF92DE40DB0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L13:
+       cmp       [rdi],r14
+       je        short M00_L14
+       mov       rcx,rdi
+       mov       r11,7FF92DE40DC0
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
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1D6FDC02000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70DA0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE70D88
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70D98
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
-       mov       r11,7FF92DE70D98
+       mov       r11,7FF92DE40DC0
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
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
+       jne       near ptr M00_L06
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
        mov       rdi,[rbp-38]
        cmp       [rdi],edi
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
        cmp       [rdi],r14
-       jne       short M00_L06
+       jne       short M00_L07
        lea       r15,[rdi+8]
        mov       rcx,[r15]
        mov       rax,rcx
        mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L07
+       jne       short M00_L06
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
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
        jmp       short M00_L10
 M00_L06:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L07:
        mov       rcx,rdi
-       mov       r11,7FF92DE70D90
+       mov       r11,7FF92DE61190
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
        jmp       short M00_L10
-M00_L07:
-       call      qword ptr [7FF92E14C150]
-       int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
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
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1D6FDC02000
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,138A7800A98
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L14:
        mov       rcx,rdi
-       mov       r11,7FF92DE70DA0
+       mov       r11,7FF92DE611A0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L15:
-       mov       r11,7FF92DE70D88
+       mov       r11,7FF92DE61188
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L16:
        mov       rcx,rdi
-       mov       r11,7FF92DE70D98
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
-       jmp       near ptr M00_L11
+       jmp       short M00_L11
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
-       mov       r11,7FF92DE70D98
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
 M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 599
+; Total bytes of code 595
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       mov       r11,7FF92DE70D90
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
 M00_L07:
        call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1D6FDC02000
-       mov       r14,[rcx]
+       mov       r11,7FF92DE71938
+       call      qword ptr [r11]
+       mov       rcx,rax
        jmp       near ptr M00_L00
 M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70DA0
+       mov       r11,7FF92DE71948
        call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
+       jmp       short M00_L11
 M00_L15:
-       mov       r11,7FF92DE70D88
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70D98
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
-       mov       r11,7FF92DE70D98
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
add       rsi,1
        jo        short M00_L08
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FF92E14C150]
+       call      qword ptr [7FF92E11C150]
        int       3
 M00_L06:
        mov       rcx,rdi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE40DB8
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
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2304CC02000
+       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20003802000
        mov       r14,[rcx]
        jmp       near ptr M00_L00
 M00_L11:
        mov       rcx,rdi
-       mov       r11,7FF92DE70F48
+       mov       r11,7FF92DE40DC8
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L12:
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE40DB0
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M00_L00
 M00_L13:
        cmp       [rdi],r14
        je        short M00_L14
        mov       rcx,rdi
-       mov       r11,7FF92DE70F40
+       mov       r11,7FF92DE40DC0
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
-       mov       r11,7FF92DE70F40
+       mov       r11,7FF92DE40DC0
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
-       je        near ptr M00_L15
+       je        near ptr M00_L17
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L12
+       jne       near ptr M00_L15
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L11
+       jne       near ptr M00_L14
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L10
+       je        near ptr M00_L13
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
-       jne       near ptr M00_L05
+       jne       near ptr M00_L06
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L09
+       jae       near ptr M00_L05
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L07
+       jae       near ptr M00_L08
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L08
+       jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
        mov       rdi,[rbp-38]
        cmp       [rdi],edi
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
        cmp       [rdi],r14
-       jne       short M00_L06
+       jne       short M00_L07
        lea       r15,[rdi+8]
        mov       rcx,[r15]
        mov       rax,rcx
        mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L05
+       jne       short M00_L06
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L09
+       jae       short M00_L05
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L07
+       jae       short M00_L08
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L08
+       jo        short M00_L09
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FF92E14C150]
-       int       3
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L07:
        mov       rcx,rdi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE61190
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L13
-M00_L07:
+       jmp       short M00_L10
+M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L08:
+M00_L09:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L09:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L13
 M00_L10:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2304CC02000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70F48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FF92DE70F30
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
        cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FF92DE70F40
-       call      qword ptr [r11]
-M00_L14:
+       jne       short M00_L16
+M00_L11:
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
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
+M00_L13:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,138A7800A98
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       rcx,rdi
+       mov       r11,7FF92DE611A0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L15:
+       mov       r11,7FF92DE61188
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L16:
+       mov       rcx,rdi
+       mov       r11,7FF92DE61198
+       call      qword ptr [r11]
+       jmp       short M00_L11
+M00_L17:
+       xor       eax,eax
+       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L17
+       je        short M00_L18
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L17
+       je        short M00_L18
        mov       rcx,rdi
-       mov       r11,7FF92DE70F40
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
-M00_L17:
+M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 594
+; Total bytes of code 595
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       call      qword ptr [7FF92E14C150]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DF25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2304CC02000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FF92DE70F48
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FF92DE70F30
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FF92DE70F40
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
+       mov       r11,7FF92DE71938
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FF92DE71948
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
-       mov       r11,7FF92DE70F40
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
-       je        near ptr M00_L15
+       je        near ptr M00_L17
        xor       esi,esi
        mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rcx],rax
-       jne       near ptr M00_L12
+       jne       near ptr M00_L15
        mov       rdi,[rcx+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rdi],rcx
-       jne       near ptr M00_L11
+       jne       near ptr M00_L14
        cmp       dword ptr [rdi+10],0
-       je        near ptr M00_L10
+       je        near ptr M00_L13
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
-       jne       near ptr M00_L05
+       jne       near ptr M00_L06
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L09
+       jae       near ptr M00_L05
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       near ptr M00_L07
+       jae       near ptr M00_L08
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        add       rsi,1
-       jo        near ptr M00_L08
+       jo        near ptr M00_L09
        jmp       short M00_L01
 M00_L02:
        mov       rdi,[rbp-38]
        mov       rdi,[rbp-38]
        cmp       [rdi],edi
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
 M00_L03:
        cmp       [rdi],r14
-       jne       short M00_L06
+       jne       short M00_L07
        lea       r15,[rdi+8]
        mov       rcx,[r15]
        mov       rax,rcx
        mov       edx,[r15+10]
        cmp       edx,[rcx+14]
-       jne       short M00_L05
+       jne       short M00_L06
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L09
+       jae       short M00_L05
        mov       r13,[rax+8]
        cmp       r8d,[r13+8]
-       jae       short M00_L07
+       jae       short M00_L08
        mov       ecx,r8d
        mov       rdx,[r13+rcx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
 M00_L04:
        add       rsi,1
-       jo        short M00_L08
+       jo        short M00_L09
        jmp       short M00_L03
 M00_L05:
-       call      qword ptr [7FF92E11C150]
-       int       3
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L07:
        mov       rcx,rdi
-       mov       r11,7FF92DE40DB8
+       mov       r11,7FF92DE61190
        call      qword ptr [r11]
        test      eax,eax
        jne       short M00_L04
-       jmp       short M00_L13
-M00_L07:
+       jmp       short M00_L10
+M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L08:
+M00_L09:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L09:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L13
 M00_L10:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20003802000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FF92DE40DC8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FF92DE40DB0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
        cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FF92DE40DC0
-       call      qword ptr [r11]
-M00_L14:
+       jne       short M00_L16
+M00_L11:
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
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
+M00_L13:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,138A7800A98
+       mov       r14,[rcx]
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       rcx,rdi
+       mov       r11,7FF92DE611A0
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L15:
+       mov       r11,7FF92DE61188
+       call      qword ptr [r11]
+       mov       r14,rax
+       jmp       near ptr M00_L00
+M00_L16:
+       mov       rcx,rdi
+       mov       r11,7FF92DE61198
+       call      qword ptr [r11]
+       jmp       short M00_L11
+M00_L17:
+       xor       eax,eax
+       jmp       short M00_L12
        sub       rsp,28
        cmp       qword ptr [rbp-38],0
-       je        short M00_L17
+       je        short M00_L18
        mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rdi,[rbp-38]
        cmp       [rdi],r14
-       je        short M00_L17
+       je        short M00_L18
        mov       rcx,rdi
-       mov       r11,7FF92DE40DC0
+       mov       r11,7FF92DE61198
        call      qword ptr [r11]
-M00_L17:
+M00_L18:
        nop
        add       rsp,28
        ret
-; Total bytes of code 594
+; Total bytes of code 595
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M01_L00
        ret
 M01_L00:
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       call      qword ptr [7FF92E11C150]
-       int       3
+       xor       eax,eax
+       mov       [r14+8],rax
+       mov       dword ptr [r14+14],0FFFFFFFF
+       jmp       short M00_L10
 M00_L06:
-       mov       rcx,rdi
-       mov       r11,7FF92DE40DB8
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
-       jmp       short M00_L13
+       jne       short M00_L03
+       jmp       short M00_L10
 M00_L07:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FF92E14C150]
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
-       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,20003802000
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       jne       short M00_L14
 M00_L11:
-       mov       rcx,rdi
-       mov       r11,7FF92DE40DC8
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L12:
-       mov       r11,7FF92DE40DB0
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L13:
-       cmp       [rdi],r14
-       je        short M00_L14
-       mov       rcx,rdi
-       mov       r11,7FF92DE40DC0
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
+       mov       r11,7FF92DE71938
+       call      qword ptr [r11]
+       mov       rcx,rax
+       jmp       near ptr M00_L00
+M00_L14:
+       mov       r11,7FF92DE71948
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
-       mov       r11,7FF92DE40DC0
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
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
-       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithCount method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
+       mov       r11,7FF92DE71950
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
-       jne       near ptr M00_L06
-       mov       r8d,[r15+14]
+       lea       r14,[rcx+8]
+       mov       rdx,[r14]
+       mov       rax,rdx
+       mov       r8d,[r14+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L07
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
-       jne       short M00_L07
-       lea       r15,[rdi+8]
-       mov       rcx,[r15]
-       mov       rax,rcx
-       mov       edx,[r15+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L06
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
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L07:
-       mov       rcx,rdi
-       mov       r11,7FF92DE61190
+       mov       r11,7FF92DE71940
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M00_L04
+       jne       short M00_L03
        jmp       short M00_L10
+M00_L07:
+       call      qword ptr [7FF92E14C150]
+       int       3
 M00_L08:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
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
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,138A7800A98
-       mov       r14,[rcx]
-       jmp       near ptr M00_L00
-M00_L14:
-       mov       rcx,rdi
-       mov       r11,7FF92DE611A0
+       mov       r11,7FF92DE71938
        call      qword ptr [r11]
-       mov       r14,rax
+       mov       rcx,rax
        jmp       near ptr M00_L00
-M00_L15:
-       mov       r11,7FF92DE61188
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M00_L00
-M00_L16:
-       mov       rcx,rdi
-       mov       r11,7FF92DE61198
+M00_L14:
+       mov       r11,7FF92DE71948
        call      qword ptr [r11]
        jmp       short M00_L11
-M00_L17:
+M00_L15:
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
-       mov       r11,7FF92DE61198
+       cmp       qword ptr [rbp-30],0
+       je        short M00_L16
+       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       rcx,[rbp-30]
+       cmp       [rcx],rdi
+       je        short M00_L16
+       mov       r11,7FF92DE71948
        call      qword ptr [r11]
-M00_L18:
+M00_L16:
        nop
        add       rsp,28
        ret
-; Total bytes of code 595
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M01_L00
-       ret
-M01_L00:
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
+; Total bytes of code 472
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,1AF208009F8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L23
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L07
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        near ptr M00_L24
        add       r13,10
 M00_L01:
        xor       esi,esi
        cmp       esi,r15d
        jl        short M00_L03
-       jmp       near ptr M00_L20
+       jmp       short M00_L05
 M00_L02:
        inc       esi
        cmp       esi,r15d
-       jge       near ptr M00_L20
+       jge       short M00_L05
 M00_L03:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L02
        inc       r14d
        jmp       short M00_L02
 M00_L04:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L05:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L06:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L07:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L08:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
+       je        near ptr M00_L13
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
+       jne       near ptr M00_L13
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
+       jne       near ptr M00_L13
+M00_L09:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L16
+       jne       near ptr M00_L19
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L14
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
+       jae       near ptr M00_L20
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L12
+       je        near ptr M00_L15
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L07:
+M00_L10:
        test      eax,eax
-       je        short M00_L06
+       je        short M00_L09
        add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
+       jo        near ptr M00_L21
+       jmp       short M00_L09
+M00_L11:
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
+       jae       near ptr M00_L20
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],r11
-       jne       near ptr M00_L14
+       jne       near ptr M00_L17
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L15
+       je        near ptr M00_L18
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L09:
+M00_L12:
        test      eax,eax
-       je        short M00_L10
+       je        short M00_L13
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
+       jo        near ptr M00_L21
+M00_L13:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rax,[r15]
-       mov       edx,[r15+10]
-       mov       r8,[r15]
-       cmp       edx,[r8+14]
        jne       short M00_L16
+       lea       r15,[rcx+8]
+       mov       rdx,[r15]
+       mov       rax,rdx
+       mov       r8d,[r15+10]
+       cmp       r8d,[rdx+14]
+       jne       short M00_L19
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
+       jb        near ptr M00_L11
+M00_L14:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
+       jmp       near ptr M00_L04
+M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE70F20
+       jmp       near ptr M00_L10
+M00_L16:
+       mov       r11,7FF92DE50F20
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
+       je        near ptr M00_L04
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
+       mov       r11,7FF92DE50F28
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L17:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
-M00_L15:
+       jmp       near ptr M00_L12
+M00_L18:
        xor       eax,eax
-       jmp       near ptr M00_L09
-M00_L16:
-       call      qword ptr [7FF92E14C150]
+       jmp       near ptr M00_L12
+M00_L19:
+       call      qword ptr [7FF92E12C150]
        int       3
-M00_L17:
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L18:
+M00_L21:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L19:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
-M00_L20:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L21:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
 M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
 M00_L23:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,1AF208009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1AF208009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L24:
-       call      qword ptr [7FF92E147A20]
+       call      qword ptr [7FF92E127A20]
        int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
+       mov       rcx,1AF0A802000
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L08
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE50F38
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L08
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE50F18
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L08
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE50F30
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
+       jmp       near ptr M00_L05
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L06
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE50F30
        call      qword ptr [r11]
 M00_L30:
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E6FE9B8]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,155A4C009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L05
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       jl        short M00_L04
+       jmp       near ptr M00_L21
 M00_L02:
+       inc       r14d
+M00_L03:
        inc       esi
        cmp       esi,r15d
-       jge       near ptr M00_L20
-M00_L03:
+       jge       near ptr M00_L21
+M00_L04:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
+M00_L05:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L06:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
+       je        near ptr M00_L11
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
+       jne       near ptr M00_L11
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
+       jne       near ptr M00_L11
+M00_L07:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L16
+       jne       near ptr M00_L17
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L12
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L12
+       je        near ptr M00_L13
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L07:
+M00_L08:
        test      eax,eax
-       je        short M00_L06
+       je        short M00_L07
        add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
+       jo        near ptr M00_L19
+       jmp       short M00_L07
+M00_L09:
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],r11
-       jne       near ptr M00_L14
+       jne       near ptr M00_L15
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L15
+       je        near ptr M00_L16
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L09:
+M00_L10:
        test      eax,eax
-       je        short M00_L10
+       je        short M00_L11
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
+       jo        near ptr M00_L19
+M00_L11:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
+       jne       short M00_L14
        lea       r15,[rcx+8]
-       mov       rax,[r15]
-       mov       edx,[r15+10]
-       mov       r8,[r15]
-       cmp       edx,[r8+14]
-       jne       short M00_L16
+       mov       rdx,[r15]
+       mov       rax,rdx
+       mov       r8d,[r15+10]
+       cmp       r8d,[rdx+14]
+       jne       short M00_L17
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
+       jb        near ptr M00_L09
+M00_L12:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
-       xor       eax,eax
-       jmp       near ptr M00_L07
+       jmp       short M00_L20
 M00_L13:
-       mov       r11,7FF92DE70F20
+       xor       eax,eax
+       jmp       near ptr M00_L08
+M00_L14:
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
+       je        short M00_L20
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L15:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
-M00_L15:
-       xor       eax,eax
-       jmp       near ptr M00_L09
+       jmp       near ptr M00_L10
 M00_L16:
-       call      qword ptr [7FF92E14C150]
-       int       3
+       xor       eax,eax
+       jmp       near ptr M00_L10
 M00_L17:
-       call      CORINFO_HELP_RNGCHKFAIL
+       call      qword ptr [7FF92E13C150]
        int       3
 M00_L18:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L19:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
+       call      CORINFO_HELP_OVERFLOW
+       int       3
 M00_L20:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L21:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L21:
+M00_L22:
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
-M00_L22:
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,155A4C009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,155A4C009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E147A20]
-       int       3
 M00_L25:
+       call      qword ptr [7FF92E137A20]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
+       mov       rcx,1558EC02000
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
+       jmp       near ptr M00_L06
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE60F38
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
-M00_L27:
+       jmp       near ptr M00_L06
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
-M00_L28:
+       jmp       near ptr M00_L06
+M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
-M00_L29:
-       xor       eax,eax
        jmp       near ptr M00_L21
+M00_L30:
+       xor       eax,eax
+       jmp       near ptr M00_L22
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE70F30
+       je        short M00_L31
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1008
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E70E9E8]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,1CB300029F0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L23
        test      eax,eax
        je        short M00_L10
        add       r14d,1
        jo        near ptr M00_L18
 M00_L10:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        jne       short M00_L13
        lea       r15,[rcx+8]
-       mov       rax,[r15]
-       mov       edx,[r15+10]
-       mov       r8,[r15]
-       cmp       edx,[r8+14]
+       mov       rdx,[r15]
+       mov       rax,rdx
+       mov       r8d,[r15+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L08
        xor       eax,eax
        jmp       near ptr M00_L07
 M00_L13:
-       mov       r11,7FF92DE70F20
+       mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L19
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
+       mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L14:
        xor       eax,eax
        jmp       near ptr M00_L09
 M00_L16:
-       call      qword ptr [7FF92E14C150]
+       call      qword ptr [7FF92E13C150]
        int       3
 M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
 M00_L23:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,1CB300029E8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1CB300029F0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L24:
-       call      qword ptr [7FF92E147A20]
+       call      qword ptr [7FF92E137A20]
        int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1CB30001FC0
        mov       r15,[rcx]
        jmp       near ptr M00_L05
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L05
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE60C90
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L05
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
        jmp       near ptr M00_L20
 M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1009
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E70EFA0]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,237278009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       jmp       short M00_L04
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
+       inc       r14d
 M00_L03:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
+M00_L04:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
+M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L07:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L13
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L13
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L13
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L20
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
-       add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L16
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L11:
+       test      r8d,r8d
        je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L21
+       jmp       short M00_L10
+M00_L12:
+       add       r14d,1
+       jo        near ptr M00_L21
+M00_L13:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rax,[r15]
-       mov       edx,[r15+10]
-       mov       r8,[r15]
-       cmp       edx,[r8+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L17
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L20
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L18
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L19
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L14:
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
+M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE70F20
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
+M00_L16:
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
+M00_L17:
+       mov       rcx,r15
+       mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L18:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
-M00_L15:
-       xor       eax,eax
-       jmp       near ptr M00_L09
-M00_L16:
-       call      qword ptr [7FF92E14C150]
-       int       3
-M00_L17:
+       mov       r8d,eax
+       jmp       short M00_L14
+M00_L19:
+       xor       r8d,r8d
+       jmp       short M00_L14
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L18:
+M00_L21:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L19:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
-M00_L20:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L21:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
 M00_L22:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,237278009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237278009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E147A20]
-       int       3
 M00_L25:
+       call      qword ptr [7FF92E137A20]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,23711801FC8
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE70F38
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L09
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       rcx,rsi
+       mov       r11,7FF92DE60C90
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
+       mov       r15,rax
+       jmp       near ptr M00_L09
 M00_L29:
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA8
+       call      qword ptr [r11]
+       jmp       near ptr M00_L06
+M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE70F30
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1018
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E6FCAF8]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,1C5B28009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       jmp       short M00_L04
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
+       inc       r14d
 M00_L03:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
+M00_L04:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
+M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L07:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L13
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L13
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L13
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
        jne       near ptr M00_L16
-       mov       r8d,[r15+14]
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L21
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
-       add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L17
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L11:
+       test      r8d,r8d
        je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L22
+       jmp       short M00_L10
+M00_L12:
+       add       r14d,1
+       jo        near ptr M00_L22
+M00_L13:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rax,[r15]
-       mov       edx,[r15+10]
-       mov       r8,[r15]
-       cmp       edx,[r8+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L18
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
-       xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE70F20
-       call      qword ptr [r11]
-       test      eax,eax
-       je        short M00_L19
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
-       call      qword ptr [r11]
-       mov       rdx,rax
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L21
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L19
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L20
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L14:
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
 M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L09
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
 M00_L16:
-       call      qword ptr [7FF92E14C150]
+       call      qword ptr [7FF92E13C150]
        int       3
 M00_L17:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
 M00_L18:
-       call      CORINFO_HELP_OVERFLOW
-       int       3
+       mov       rcx,r15
+       mov       r11,7FF92DE60F18
+       call      qword ptr [r11]
+       test      eax,eax
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60F20
+       call      qword ptr [r11]
+       mov       rdx,rax
 M00_L19:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       mov       r8d,eax
+       jmp       short M00_L14
 M00_L20:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
+       xor       r8d,r8d
+       jmp       short M00_L14
 M00_L21:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
 M00_L22:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,1C5B28009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1C5B28009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E147A20]
-       int       3
 M00_L25:
+       call      qword ptr [7FF92E137A20]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
+       mov       rcx,1C59C802000
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE70F38
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L09
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       rcx,rsi
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
+       mov       r15,rax
+       jmp       near ptr M00_L09
 M00_L29:
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
+       call      qword ptr [r11]
+       jmp       near ptr M00_L06
+M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE70F30
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1017
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E70E9E8]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,19D09000A38
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       call      qword ptr [7FF92E127A20]
+       int       3
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
-M00_L03:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L02
-       inc       r14d
-       jmp       short M00_L02
-M00_L04:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L03:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L07
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
+       jne       near ptr M00_L07
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L07
+M00_L04:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
        jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L16
-       mov       r8d,[r15+14]
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L09
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L15
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L05:
+       test      r8d,r8d
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
-       je        short M00_L10
+       jo        near ptr M00_L16
+       jmp       short M00_L04
+M00_L06:
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L16
+M00_L07:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rax,[r15]
-       mov       edx,[r15+10]
-       mov       r8,[r15]
-       cmp       edx,[r8+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L12
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L10
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
+       jae       short M00_L09
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L15
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L13
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L14
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L08:
+       test      r8d,r8d
+       je        near ptr M00_L07
+       jmp       near ptr M00_L06
+M00_L09:
        xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       short M00_L17
+M00_L10:
+       call      qword ptr [7FF92E12C150]
+       int       3
+M00_L11:
+       xor       r8d,r8d
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE70F20
+       mov       rcx,r15
+       mov       r11,7FF92DE511A0
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
+       je        short M00_L17
+       mov       rcx,r15
+       mov       r11,7FF92DE511A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L13:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
+       mov       r8d,eax
+       jmp       short M00_L08
+M00_L14:
+       xor       r8d,r8d
+       jmp       short M00_L08
 M00_L15:
-       xor       eax,eax
-       jmp       near ptr M00_L09
-M00_L16:
-       call      qword ptr [7FF92E14C150]
-       int       3
-M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L18:
+M00_L16:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L19:
+M00_L17:
        cmp       rsi,r13
        jne       near ptr M00_L28
-M00_L20:
+M00_L18:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L21:
+M00_L19:
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
-M00_L22:
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       test      r15d,r15d
+       jle       short M00_L18
+       xor       esi,esi
+       jmp       short M00_L23
+M00_L22:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L18
 M00_L23:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L22
+       inc       r14d
+       jmp       short M00_L22
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,19D09000A30
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19D09000A38
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E147A20]
-       int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
+       mov       rcx,19D09000AA8
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L03
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F38
+       mov       r11,7FF92DE511B8
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L03
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE51198
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
+       jmp       near ptr M00_L18
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L19
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE70F30
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E6F4DF8]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,25EC84029F0
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L23
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       call      qword ptr [7FF92E137A20]
+       int       3
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
-M00_L03:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L02
-       inc       r14d
-       jmp       short M00_L02
-M00_L04:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
-       jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
-M00_L05:
-       mov       [rbp-40],r15
+       mov       rcx,[rsi+8]
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
+M00_L03:
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
+       je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
+       jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
+       jne       short M00_L06
+M00_L04:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
        jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L17
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
-       add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
+       je        short M00_L08
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L09:
+M00_L05:
        test      eax,eax
-       je        short M00_L10
+       je        short M00_L04
        add       r14d,1
        jo        near ptr M00_L18
-M00_L10:
+       jmp       short M00_L04
+M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
+       jne       short M00_L09
        lea       r15,[rcx+8]
        mov       rax,[r15]
        mov       edx,[r15+10]
        mov       r8,[r15]
        cmp       edx,[r8+14]
-       jne       short M00_L16
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
+       jb        short M00_L10
+M00_L07:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
+       jmp       near ptr M00_L19
+M00_L08:
        xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE70F20
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L17
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r15+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F28
+       mov       r11,7FF92DE618E8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L12:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
-M00_L15:
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
        xor       eax,eax
-       jmp       near ptr M00_L09
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L15:
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
 M00_L16:
-       call      qword ptr [7FF92E14C150]
+       call      qword ptr [7FF92E13C150]
        int       3
 M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
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
 M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
 M00_L23:
+       test      r15d,r15d
+       jle       short M00_L20
+       xor       esi,esi
+       jmp       short M00_L25
+M00_L24:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L20
+M00_L25:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L24
+       inc       r14d
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25EC84029E8
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,25EC84029F0
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E147A20]
-       int       3
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25EC8402000
-       mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE70F38
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE70F18
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
        jmp       near ptr M00_L20
 M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE70F30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E71E988]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1AF208009F8
+       mov       rcx,155A4C009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L07
+       jne       short M00_L05
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L03
-       jmp       short M00_L05
+       jl        short M00_L04
+       jmp       near ptr M00_L21
 M00_L02:
+       inc       r14d
+M00_L03:
        inc       esi
        cmp       esi,r15d
-       jge       short M00_L05
-M00_L03:
+       jge       near ptr M00_L21
+M00_L04:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
 M00_L05:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L06:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L07:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L08:
+M00_L06:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
+       je        near ptr M00_L11
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
+       jne       near ptr M00_L11
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L13
-M00_L09:
+       jne       near ptr M00_L11
+M00_L07:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
+       jne       near ptr M00_L17
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L14
+       jae       near ptr M00_L12
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L15
+       je        near ptr M00_L13
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L10:
+M00_L08:
        test      eax,eax
-       je        short M00_L09
+       je        short M00_L07
        add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L09
-M00_L11:
+       jo        near ptr M00_L19
+       jmp       short M00_L07
+M00_L09:
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L18
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],r11
-       jne       near ptr M00_L17
+       jne       near ptr M00_L15
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L18
+       je        near ptr M00_L16
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L12:
+M00_L10:
        test      eax,eax
-       je        short M00_L13
+       je        short M00_L11
        add       r14d,1
-       jo        near ptr M00_L21
-M00_L13:
+       jo        near ptr M00_L19
+M00_L11:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L16
+       jne       short M00_L14
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       short M00_L19
+       jne       short M00_L17
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L11
-M00_L14:
+       jb        near ptr M00_L09
+M00_L12:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       near ptr M00_L04
-M00_L15:
+       jmp       short M00_L20
+M00_L13:
        xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L16:
-       mov       r11,7FF92DE50F20
+       jmp       near ptr M00_L08
+M00_L14:
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L04
+       je        short M00_L20
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F28
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L17:
+M00_L15:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L12
-M00_L18:
+       jmp       near ptr M00_L10
+M00_L16:
        xor       eax,eax
-       jmp       near ptr M00_L12
-M00_L19:
-       call      qword ptr [7FF92E12C150]
+       jmp       near ptr M00_L10
+M00_L17:
+       call      qword ptr [7FF92E13C150]
        int       3
-M00_L20:
+M00_L18:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L19:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L20:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L21:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
 M00_L22:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1AF208009F0
+       mov       rdx,155A4C009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AF208009F8
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,155A4C009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E127A20]
-       int       3
 M00_L25:
+       call      qword ptr [7FF92E137A20]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AF0A802000
+       mov       rcx,1558EC02000
        mov       r15,[rcx]
-       jmp       near ptr M00_L08
-M00_L26:
+       jmp       near ptr M00_L06
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F38
+       mov       r11,7FF92DE60F38
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
-M00_L27:
+       jmp       near ptr M00_L06
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F18
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
-M00_L28:
+       jmp       near ptr M00_L06
+M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F30
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
-       jmp       near ptr M00_L05
-M00_L29:
+       jmp       near ptr M00_L21
+M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L22
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
+       je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE50F30
+       je        short M00_L31
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1008
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
-       call      qword ptr [7FF92E6FE9B8]
+       call      qword ptr [7FF92E70E9E8]
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
-       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1AF208009F8
+       mov       rcx,1CB300029F0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L23
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L07
+       jne       short M00_L04
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        near ptr M00_L24
        add       r13,10
 M00_L01:
        xor       esi,esi
        cmp       esi,r15d
        jl        short M00_L03
-       jmp       short M00_L05
+       jmp       near ptr M00_L20
 M00_L02:
        inc       esi
        cmp       esi,r15d
-       jge       short M00_L05
+       jge       near ptr M00_L20
 M00_L03:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L02
        inc       r14d
        jmp       short M00_L02
 M00_L04:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
-M00_L05:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L06:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L07:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L08:
+M00_L05:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
+       je        near ptr M00_L10
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L13
-M00_L09:
+       jne       near ptr M00_L10
+M00_L06:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L14
+       jae       near ptr M00_L11
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L17
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L15
+       je        near ptr M00_L12
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L10:
+M00_L07:
        test      eax,eax
-       je        short M00_L09
+       je        short M00_L06
        add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L09
-M00_L11:
+       jo        near ptr M00_L18
+       jmp       short M00_L06
+M00_L08:
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L17
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],r11
-       jne       near ptr M00_L17
+       jne       near ptr M00_L14
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L18
+       je        near ptr M00_L15
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L12:
+M00_L09:
        test      eax,eax
-       je        short M00_L13
+       je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L21
-M00_L13:
+       jo        near ptr M00_L18
+M00_L10:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L16
+       jne       short M00_L13
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       short M00_L19
+       jne       short M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L11
-M00_L14:
+       jb        near ptr M00_L08
+M00_L11:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       near ptr M00_L04
-M00_L15:
+       jmp       short M00_L19
+M00_L12:
        xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L16:
-       mov       r11,7FF92DE50F20
+       jmp       near ptr M00_L07
+M00_L13:
+       mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L04
+       je        short M00_L19
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F28
+       mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L17:
+M00_L14:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L12
-M00_L18:
+       jmp       near ptr M00_L09
+M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L12
-M00_L19:
-       call      qword ptr [7FF92E12C150]
+       jmp       near ptr M00_L09
+M00_L16:
+       call      qword ptr [7FF92E13C150]
        int       3
-M00_L20:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L18:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L19:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L20:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L21:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
 M00_L23:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1AF208009F0
+       mov       rdx,1CB300029E8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AF208009F8
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1CB300029F0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L24:
-       call      qword ptr [7FF92E127A20]
+       call      qword ptr [7FF92E137A20]
        int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AF0A802000
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1CB30001FC0
        mov       r15,[rcx]
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L05
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F38
+       mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L05
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F18
+       mov       r11,7FF92DE60C90
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L05
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F30
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L20
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE50F30
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1009
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
-       call      qword ptr [7FF92E6FE9B8]
+       call      qword ptr [7FF92E70EFA0]
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
-       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1AF208009F8
+       mov       rcx,237278009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L07
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       short M00_L05
+       jmp       short M00_L04
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L05
+       inc       r14d
 M00_L03:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
+M00_L04:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
 M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L06:
+M00_L07:
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
-M00_L07:
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L08:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L13
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        jne       near ptr M00_L13
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
        jne       near ptr M00_L13
-M00_L09:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[r15+14]
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L14
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L09
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L16
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L11:
+       test      r8d,r8d
+       je        short M00_L10
        add       r14d,1
        jo        near ptr M00_L21
-       jmp       short M00_L09
-M00_L11:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L17
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L18
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       jmp       short M00_L10
 M00_L12:
-       test      eax,eax
-       je        short M00_L13
        add       r14d,1
        jo        near ptr M00_L21
 M00_L13:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L16
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L19
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L17
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L11
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L20
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L18
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L19
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L14:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       near ptr M00_L04
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
 M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L10
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
 M00_L16:
-       mov       r11,7FF92DE50F20
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
+M00_L17:
+       mov       rcx,r15
+       mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L04
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F28
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L17:
+M00_L18:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L12
-M00_L18:
-       xor       eax,eax
-       jmp       near ptr M00_L12
+       mov       r8d,eax
+       jmp       short M00_L14
 M00_L19:
-       call      qword ptr [7FF92E12C150]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L14
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L22:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1AF208009F0
+       mov       rdx,237278009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AF208009F8
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237278009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E127A20]
-       int       3
 M00_L25:
+       call      qword ptr [7FF92E137A20]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AF0A802000
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,23711801FC8
        mov       r15,[rcx]
-       jmp       near ptr M00_L08
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE50F38
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F18
+       mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L09
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F30
+       mov       rcx,rsi
+       mov       r11,7FF92DE60C90
        call      qword ptr [r11]
-       jmp       near ptr M00_L05
+       mov       r15,rax
+       jmp       near ptr M00_L09
 M00_L29:
-       xor       eax,eax
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA8
+       call      qword ptr [r11]
        jmp       near ptr M00_L06
+M00_L30:
+       xor       eax,eax
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE50F30
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1018
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
-       call      qword ptr [7FF92E6FE9B8]
+       call      qword ptr [7FF92E6FCAF8]
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
-       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1AF208009F8
+       mov       rcx,1C5B28009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L07
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       short M00_L05
+       jmp       short M00_L04
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L05
+       inc       r14d
 M00_L03:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
+M00_L04:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
 M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L06:
+M00_L07:
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
-M00_L07:
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L08:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L13
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        jne       near ptr M00_L13
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
        jne       near ptr M00_L13
-M00_L09:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[r15+14]
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L14
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L21
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L09
-       add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L09
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L17
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L11:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L17
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L18
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       test      r8d,r8d
+       je        short M00_L10
+       add       r14d,1
+       jo        near ptr M00_L22
+       jmp       short M00_L10
 M00_L12:
-       test      eax,eax
-       je        short M00_L13
        add       r14d,1
-       jo        near ptr M00_L21
+       jo        near ptr M00_L22
 M00_L13:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L16
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L19
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L18
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L11
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L21
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L19
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L20
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L14:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       near ptr M00_L04
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
 M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L10
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
 M00_L16:
-       mov       r11,7FF92DE50F20
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L17:
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
+M00_L18:
+       mov       rcx,r15
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L04
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F28
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L17:
+M00_L19:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L12
-M00_L18:
-       xor       eax,eax
-       jmp       near ptr M00_L12
-M00_L19:
-       call      qword ptr [7FF92E12C150]
-       int       3
+       mov       r8d,eax
+       jmp       short M00_L14
 M00_L20:
+       xor       r8d,r8d
+       jmp       short M00_L14
+M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L22:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L22:
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1AF208009F0
+       mov       rdx,1C5B28009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AF208009F8
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1C5B28009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E127A20]
-       int       3
 M00_L25:
+       call      qword ptr [7FF92E137A20]
+       int       3
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AF0A802000
+       mov       rcx,1C59C802000
        mov       r15,[rcx]
-       jmp       near ptr M00_L08
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE50F38
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F18
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L09
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F30
+       mov       rcx,rsi
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
-       jmp       near ptr M00_L05
+       mov       r15,rax
+       jmp       near ptr M00_L09
 M00_L29:
-       xor       eax,eax
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
+       call      qword ptr [r11]
        jmp       near ptr M00_L06
+M00_L30:
+       xor       eax,eax
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE50F30
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1017
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
-       call      qword ptr [7FF92E6FE9B8]
+       call      qword ptr [7FF92E70E9E8]
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
-       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1AF208009F8
+       mov       rcx,19D09000A38
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L07
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       short M00_L05
+       call      qword ptr [7FF92E127A20]
+       int       3
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L05
-M00_L03:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L02
-       inc       r14d
-       jmp       short M00_L02
-M00_L04:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
-M00_L05:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L06:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L07:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L08:
+M00_L03:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L07
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L13
-M00_L09:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L07
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L07
+M00_L04:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L10
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L14
+       jae       near ptr M00_L09
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L15
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L09
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L05:
+       test      r8d,r8d
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L09
-M00_L11:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L17
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L18
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L12:
-       test      eax,eax
-       je        short M00_L13
+       jo        near ptr M00_L16
+       jmp       short M00_L04
+M00_L06:
        add       r14d,1
-       jo        near ptr M00_L21
-M00_L13:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L16
+M00_L07:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L16
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L19
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L12
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L10
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L11
-M00_L14:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       near ptr M00_L04
-M00_L15:
+       jae       short M00_L09
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L15
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L13
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L14
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L08:
+       test      r8d,r8d
+       je        near ptr M00_L07
+       jmp       near ptr M00_L06
+M00_L09:
        xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L16:
-       mov       r11,7FF92DE50F20
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       short M00_L17
+M00_L10:
+       call      qword ptr [7FF92E12C150]
+       int       3
+M00_L11:
+       xor       r8d,r8d
+       jmp       near ptr M00_L05
+M00_L12:
+       mov       rcx,r15
+       mov       r11,7FF92DE511A0
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L04
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F28
+       je        short M00_L17
+       mov       rcx,r15
+       mov       r11,7FF92DE511A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L17:
+M00_L13:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L12
-M00_L18:
-       xor       eax,eax
-       jmp       near ptr M00_L12
-M00_L19:
-       call      qword ptr [7FF92E12C150]
-       int       3
-M00_L20:
+       mov       r8d,eax
+       jmp       short M00_L08
+M00_L14:
+       xor       r8d,r8d
+       jmp       short M00_L08
+M00_L15:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L16:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L22:
+M00_L17:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L18:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L19:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       test      r15d,r15d
+       jle       short M00_L18
+       xor       esi,esi
+       jmp       short M00_L23
+M00_L22:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L18
 M00_L23:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L22
+       inc       r14d
+       jmp       short M00_L22
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1AF208009F0
+       mov       rdx,19D09000A30
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AF208009F8
+       mov       rcx,19D09000A38
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E127A20]
-       int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AF0A802000
+       mov       rcx,19D09000AA8
        mov       r15,[rcx]
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L03
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F38
+       mov       r11,7FF92DE511B8
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L03
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F18
+       mov       r11,7FF92DE51198
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L08
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F30
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L18
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L19
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE50F30
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
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
-       call      qword ptr [7FF92E6FE9B8]
+       call      qword ptr [7FF92E6F4DF8]
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1AF208009F8
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L07
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L23
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       short M00_L05
+       call      qword ptr [7FF92E137A20]
+       int       3
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L05
-M00_L03:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L02
-       inc       r14d
-       jmp       short M00_L02
-M00_L04:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
-M00_L05:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L06:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L07:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
-       jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
-M00_L08:
-       mov       [rbp-40],r15
+       mov       rcx,[rsi+8]
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
+M00_L03:
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
+       je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
+       jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L13
-M00_L09:
+       jne       short M00_L06
+M00_L04:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L19
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L14
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L17
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L09
-       add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L09
-M00_L11:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L20
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L17
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L18
+       je        short M00_L08
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L12:
+M00_L05:
        test      eax,eax
-       je        short M00_L13
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L21
-M00_L13:
+       jo        near ptr M00_L18
+       jmp       short M00_L04
+M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L16
+       jne       short M00_L09
        lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L19
+       mov       rax,[r15]
+       mov       edx,[r15+10]
+       mov       r8,[r15]
+       cmp       edx,[r8+14]
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L11
-M00_L14:
+       jb        short M00_L10
+M00_L07:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       near ptr M00_L04
-M00_L15:
+       jmp       near ptr M00_L19
+M00_L08:
        xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L16:
-       mov       r11,7FF92DE50F20
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L04
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L17
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r15+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F28
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618E8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L17:
+M00_L12:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L12
-M00_L18:
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
        xor       eax,eax
-       jmp       near ptr M00_L12
-M00_L19:
-       call      qword ptr [7FF92E12C150]
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L15:
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
+M00_L16:
+       call      qword ptr [7FF92E13C150]
        int       3
-M00_L20:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L18:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L19:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L20:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L21:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
 M00_L23:
+       test      r15d,r15d
+       jle       short M00_L20
+       xor       esi,esi
+       jmp       short M00_L25
+M00_L24:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L20
+M00_L25:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L24
+       inc       r14d
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1AF208009F0
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AF208009F8
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E127A20]
-       int       3
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AF0A802000
-       mov       r15,[rcx]
-       jmp       near ptr M00_L08
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE50F38
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L08
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE50F18
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L08
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE50F30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L20
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE50F30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E6FE9B8]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,155A4C009F8
+       mov       rcx,1CB300029F0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L23
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L05
+       jne       short M00_L04
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        near ptr M00_L24
        add       r13,10
 M00_L01:
        xor       esi,esi
        cmp       esi,r15d
-       jl        short M00_L04
-       jmp       near ptr M00_L21
+       jl        short M00_L03
+       jmp       near ptr M00_L20
 M00_L02:
-       inc       r14d
-M00_L03:
        inc       esi
        cmp       esi,r15d
-       jge       near ptr M00_L21
-M00_L04:
+       jge       near ptr M00_L20
+M00_L03:
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L03
+       je        short M00_L02
+       inc       r14d
        jmp       short M00_L02
-M00_L05:
+M00_L04:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L06:
+M00_L05:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L11
+       je        near ptr M00_L10
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L11
+       jne       near ptr M00_L10
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
+       jne       near ptr M00_L10
+M00_L06:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L11
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L18
+       jae       near ptr M00_L17
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L13
+       je        near ptr M00_L12
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L08:
+M00_L07:
        test      eax,eax
-       je        short M00_L07
+       je        short M00_L06
        add       r14d,1
-       jo        near ptr M00_L19
-       jmp       short M00_L07
-M00_L09:
+       jo        near ptr M00_L18
+       jmp       short M00_L06
+M00_L08:
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
+       jae       near ptr M00_L17
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],r11
-       jne       near ptr M00_L15
+       jne       near ptr M00_L14
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L16
+       je        near ptr M00_L15
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L10:
+M00_L09:
        test      eax,eax
-       je        short M00_L11
+       je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L19
-M00_L11:
+       jo        near ptr M00_L18
+M00_L10:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L14
+       jne       short M00_L13
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       short M00_L17
+       jne       short M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L09
-M00_L12:
+       jb        near ptr M00_L08
+M00_L11:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L20
-M00_L13:
+       jmp       short M00_L19
+M00_L12:
        xor       eax,eax
-       jmp       near ptr M00_L08
-M00_L14:
-       mov       r11,7FF92DE60F20
+       jmp       near ptr M00_L07
+M00_L13:
+       mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L20
+       je        short M00_L19
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L14:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L10
-M00_L16:
+       jmp       near ptr M00_L09
+M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L17:
+       jmp       near ptr M00_L09
+M00_L16:
        call      qword ptr [7FF92E13C150]
        int       3
-M00_L18:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L19:
+M00_L18:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L20:
+M00_L19:
        cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L21:
+       jne       near ptr M00_L28
+M00_L20:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L22:
+M00_L21:
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
-M00_L23:
+M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L24:
+M00_L23:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,155A4C009F0
+       mov       rdx,1CB300029E8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,155A4C009F8
+       mov       rcx,1CB300029F0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L24:
        call      qword ptr [7FF92E137A20]
        int       3
-M00_L26:
+M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1558EC02000
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1CB30001FC0
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L27:
+       jmp       near ptr M00_L05
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F38
+       mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L28:
+       jmp       near ptr M00_L05
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE60C90
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
+       jmp       near ptr M00_L05
+M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F30
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
-M00_L30:
+       jmp       near ptr M00_L20
+M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
-       mov       r11,7FF92DE60F30
+       je        short M00_L30
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1009
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
-       call      qword ptr [7FF92E70E9E8]
+       call      qword ptr [7FF92E70EFA0]
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,155A4C009F8
+       mov       rcx,237278009F8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L05
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L04
-       jmp       near ptr M00_L21
+       jmp       short M00_L04
 M00_L02:
        inc       r14d
 M00_L03:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L21
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
 M00_L04:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L03
        jmp       short M00_L02
 M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L07:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L06:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L13
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L13
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L13
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L18
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L20
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L13
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L08:
-       test      eax,eax
-       je        short M00_L07
-       add       r14d,1
-       jo        near ptr M00_L19
-       jmp       short M00_L07
-M00_L09:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L15
-       mov       r12,[rdx+30]
-       test      r12,r12
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
        je        near ptr M00_L16
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L11
-       add       r14d,1
-       jo        near ptr M00_L19
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L11:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       test      r8d,r8d
+       je        short M00_L10
+       add       r14d,1
+       jo        near ptr M00_L21
+       jmp       short M00_L10
+M00_L12:
+       add       r14d,1
+       jo        near ptr M00_L21
+M00_L13:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L14
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L17
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L17
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L09
-M00_L12:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L20
-M00_L13:
-       xor       eax,eax
-       jmp       near ptr M00_L08
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L20
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L18
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L19
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L14:
-       mov       r11,7FF92DE60F20
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
+M00_L15:
+       xor       eax,eax
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
+M00_L16:
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
+M00_L17:
+       mov       rcx,r15
+       mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L20
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F28
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L18:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L10
-M00_L16:
-       xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L17:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L18:
+       mov       r8d,eax
+       jmp       short M00_L14
+M00_L19:
+       xor       r8d,r8d
+       jmp       short M00_L14
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L19:
+M00_L21:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L20:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L21:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
 M00_L22:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       call      qword ptr [7FF92E13C150]
+       int       3
 M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,155A4C009F0
+       mov       rdx,237278009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,155A4C009F8
+       mov       rcx,237278009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FF92E137A20]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1558EC02000
+       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,23711801FC8
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F38
+       mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L09
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE60C90
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L09
 M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F30
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L06
 M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FF92DE60F30
+       mov       rcx,r15
+       mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1018
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
-       call      qword ptr [7FF92E70E9E8]
+       call      qword ptr [7FF92E6FCAF8]
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,155A4C009F8
+       mov       rcx,1C5B28009F8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L05
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L04
-       jmp       near ptr M00_L21
+       jmp       short M00_L04
 M00_L02:
        inc       r14d
 M00_L03:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L21
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
 M00_L04:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L03
        jmp       short M00_L02
 M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L07:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L06:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L13
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L13
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L13
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L18
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L21
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L13
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L08:
-       test      eax,eax
-       je        short M00_L07
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L17
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L11:
+       test      r8d,r8d
+       je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L19
-       jmp       short M00_L07
-M00_L09:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L15
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L16
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L11
+       jo        near ptr M00_L22
+       jmp       short M00_L10
+M00_L12:
        add       r14d,1
-       jo        near ptr M00_L19
-M00_L11:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L22
+M00_L13:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L14
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L17
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L18
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L09
-M00_L12:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L20
-M00_L13:
-       xor       eax,eax
-       jmp       near ptr M00_L08
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L21
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L19
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L20
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L14:
-       mov       r11,7FF92DE60F20
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
+M00_L15:
+       xor       eax,eax
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
+M00_L16:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L17:
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
+M00_L18:
+       mov       rcx,r15
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L20
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F28
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L19:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L10
-M00_L16:
-       xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L17:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L18:
+       mov       r8d,eax
+       jmp       short M00_L14
+M00_L20:
+       xor       r8d,r8d
+       jmp       short M00_L14
+M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L19:
+M00_L22:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L20:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L21:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L22:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
 M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,155A4C009F0
+       mov       rdx,1C5B28009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,155A4C009F8
+       mov       rcx,1C5B28009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FF92E137A20]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1558EC02000
+       mov       rcx,1C59C802000
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F38
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L09
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
+       jmp       near ptr M00_L09
 M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F30
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L06
 M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FF92DE60F30
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 1017
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,155A4C009F8
+       mov       rcx,19D09000A38
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r13,10
-M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L04
        jmp       near ptr M00_L21
+M00_L01:
+       call      qword ptr [7FF92E127A20]
+       int       3
 M00_L02:
-       inc       r14d
-M00_L03:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L21
-M00_L04:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L03
-       jmp       short M00_L02
-M00_L05:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L06:
+M00_L03:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L11
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L07
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L11
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L07
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L07
+M00_L04:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L10
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L09
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L18
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L15
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L13
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L08:
-       test      eax,eax
-       je        short M00_L07
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L05:
+       test      r8d,r8d
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L19
-       jmp       short M00_L07
-M00_L09:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L15
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L16
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
-       test      eax,eax
-       je        short M00_L11
+       jo        near ptr M00_L16
+       jmp       short M00_L04
+M00_L06:
        add       r14d,1
-       jo        near ptr M00_L19
-M00_L11:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L16
+M00_L07:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L14
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L17
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L12
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L10
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L09
-M00_L12:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L20
-M00_L13:
+       jae       short M00_L09
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L15
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L13
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L14
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L08:
+       test      r8d,r8d
+       je        near ptr M00_L07
+       jmp       near ptr M00_L06
+M00_L09:
        xor       eax,eax
-       jmp       near ptr M00_L08
-M00_L14:
-       mov       r11,7FF92DE60F20
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       short M00_L17
+M00_L10:
+       call      qword ptr [7FF92E12C150]
+       int       3
+M00_L11:
+       xor       r8d,r8d
+       jmp       near ptr M00_L05
+M00_L12:
+       mov       rcx,r15
+       mov       r11,7FF92DE511A0
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L20
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F28
+       je        short M00_L17
+       mov       rcx,r15
+       mov       r11,7FF92DE511A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L13:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L10
-M00_L16:
-       xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L17:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L18:
+       mov       r8d,eax
+       jmp       short M00_L08
+M00_L14:
+       xor       r8d,r8d
+       jmp       short M00_L08
+M00_L15:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L19:
+M00_L16:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L20:
+M00_L17:
        cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L21:
+       jne       near ptr M00_L28
+M00_L18:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L22:
+M00_L19:
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
-M00_L23:
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       test      r15d,r15d
+       jle       short M00_L18
+       xor       esi,esi
+       jmp       short M00_L23
+M00_L22:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L18
+M00_L23:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L22
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,155A4C009F0
+       mov       rdx,19D09000A30
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,155A4C009F8
+       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19D09000A38
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1558EC02000
+       mov       rcx,19D09000AA8
        mov       r15,[rcx]
-       jmp       near ptr M00_L06
-M00_L27:
+       jmp       near ptr M00_L03
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F38
+       mov       r11,7FF92DE511B8
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L28:
+       jmp       near ptr M00_L03
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE51198
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F30
+       jmp       near ptr M00_L03
+M00_L28:
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
-M00_L30:
+       jmp       near ptr M00_L18
+M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L19
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L30
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
-       mov       r11,7FF92DE60F30
+       je        short M00_L30
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
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
-       call      qword ptr [7FF92E70E9E8]
+       call      qword ptr [7FF92E6F4DF8]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,155A4C009F8
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L05
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L23
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L04
-       jmp       near ptr M00_L21
+       call      qword ptr [7FF92E137A20]
+       int       3
 M00_L02:
-       inc       r14d
-M00_L03:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L21
-M00_L04:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L03
-       jmp       short M00_L02
-M00_L05:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
        jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
-M00_L06:
-       mov       [rbp-40],r15
+       mov       rcx,[rsi+8]
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
+M00_L03:
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L11
+       je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L11
+       jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L11
-M00_L07:
+       jne       short M00_L06
+M00_L04:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
-       jne       near ptr M00_L17
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L12
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L18
+       jae       near ptr M00_L17
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L13
+       je        short M00_L08
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L08:
-       test      eax,eax
-       je        short M00_L07
-       add       r14d,1
-       jo        near ptr M00_L19
-       jmp       short M00_L07
-M00_L09:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L18
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L15
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L16
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L10:
+M00_L05:
        test      eax,eax
-       je        short M00_L11
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L19
-M00_L11:
+       jo        near ptr M00_L18
+       jmp       short M00_L04
+M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L14
+       jne       short M00_L09
        lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L17
+       mov       rax,[r15]
+       mov       edx,[r15+10]
+       mov       r8,[r15]
+       cmp       edx,[r8+14]
+       jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L09
-M00_L12:
+       jb        short M00_L10
+M00_L07:
        xor       eax,eax
        mov       [r15+8],rax
        mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L20
-M00_L13:
+       jmp       near ptr M00_L19
+M00_L08:
        xor       eax,eax
-       jmp       near ptr M00_L08
-M00_L14:
-       mov       r11,7FF92DE60F20
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L20
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L17
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r15+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE618E8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L15:
+M00_L12:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L10
-M00_L16:
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
        xor       eax,eax
-       jmp       near ptr M00_L10
-M00_L17:
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L15:
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
+M00_L16:
        call      qword ptr [7FF92E13C150]
        int       3
-M00_L18:
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L19:
+M00_L18:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L20:
+M00_L19:
        cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L21:
+       jne       near ptr M00_L28
+M00_L20:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L22:
+M00_L21:
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
-M00_L23:
+M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L23:
+       test      r15d,r15d
+       jle       short M00_L20
+       xor       esi,esi
+       jmp       short M00_L25
 M00_L24:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L20
+M00_L25:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L24
+       inc       r14d
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,155A4C009F0
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,155A4C009F8
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1558EC02000
-       mov       r15,[rcx]
-       jmp       near ptr M00_L06
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F38
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,rsi
-       mov       r11,7FF92DE60F18
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L06
-M00_L29:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60F30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
-M00_L30:
+       jmp       near ptr M00_L20
+M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L22
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
-       mov       r11,7FF92DE60F30
+       je        short M00_L30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1008
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E70E9E8]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1CB300029F0
+       mov       rcx,237278009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       jmp       short M00_L04
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
+       inc       r14d
 M00_L03:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
+M00_L04:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
+M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L07:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L13
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L13
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L13
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L20
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
-       add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L16
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L11:
+       test      r8d,r8d
        je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L21
+       jmp       short M00_L10
+M00_L12:
+       add       r14d,1
+       jo        near ptr M00_L21
+M00_L13:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L17
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L22
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L20
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L18
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L19
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L14:
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
+M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
+M00_L16:
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
+M00_L17:
+       mov       rcx,r15
        mov       r11,7FF92DE60C98
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
-       mov       rcx,[rbp-40]
+       je        near ptr M00_L05
+       mov       rcx,r15
        mov       r11,7FF92DE60CA0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L18:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
-M00_L15:
-       xor       eax,eax
-       jmp       near ptr M00_L09
-M00_L16:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L17:
+       mov       r8d,eax
+       jmp       short M00_L14
+M00_L19:
+       xor       r8d,r8d
+       jmp       short M00_L14
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L18:
+M00_L21:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L19:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
-M00_L20:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L21:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
 M00_L22:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1CB300029E8
+       mov       rdx,237278009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CB300029F0
+       mov       rcx,237278009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
+M00_L25:
        call      qword ptr [7FF92E137A20]
        int       3
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CB30001FC0
+       mov       rcx,23711801FC8
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
+       jmp       near ptr M00_L09
+M00_L27:
        mov       rcx,rsi
        mov       r11,7FF92DE60CB0
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
-M00_L27:
+       jmp       near ptr M00_L09
+M00_L28:
        mov       rcx,rsi
        mov       r11,7FF92DE60C90
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
-M00_L28:
-       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L09
+M00_L29:
+       mov       rcx,r15
        mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
-M00_L29:
+       jmp       near ptr M00_L06
+M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
+       je        short M00_L31
+       mov       rcx,r15
        mov       r11,7FF92DE60CA8
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1009
+; Total bytes of code 1018
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
-       call      qword ptr [7FF92E70EFA0]
+       call      qword ptr [7FF92E6FCAF8]
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1CB300029F0
+       mov       rcx,1C5B28009F8
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L29
+       je        near ptr M00_L30
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L23
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L08
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        near ptr M00_L25
        add       r13,10
 M00_L01:
+       test      r15d,r15d
+       jle       short M00_L06
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       jmp       short M00_L04
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
+       inc       r14d
 M00_L03:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L06
+M00_L04:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L02
-       inc       r14d
+       je        short M00_L03
        jmp       short M00_L02
-M00_L04:
+M00_L05:
+       cmp       rsi,r13
+       jne       near ptr M00_L29
+M00_L06:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L07:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L28
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L09:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L13
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L13
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L13
+M00_L10:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
        jne       near ptr M00_L16
-       mov       r8d,[r15+14]
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L21
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
-       add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L17
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L11:
+       test      r8d,r8d
        je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L22
+       jmp       short M00_L10
+M00_L12:
+       add       r14d,1
+       jo        near ptr M00_L22
+M00_L13:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L18
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
-       xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE60C98
-       call      qword ptr [r11]
-       test      eax,eax
-       je        short M00_L19
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60CA0
-       call      qword ptr [r11]
-       mov       rdx,rax
+       jae       short M00_L15
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L21
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L19
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L20
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L14:
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
+       test      r8d,r8d
+       je        near ptr M00_L13
+       jmp       near ptr M00_L12
 M00_L15:
        xor       eax,eax
-       jmp       near ptr M00_L09
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       near ptr M00_L05
 M00_L16:
        call      qword ptr [7FF92E13C150]
        int       3
 M00_L17:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       xor       r8d,r8d
+       jmp       near ptr M00_L11
 M00_L18:
-       call      CORINFO_HELP_OVERFLOW
-       int       3
+       mov       rcx,r15
+       mov       r11,7FF92DE60F18
+       call      qword ptr [r11]
+       test      eax,eax
+       je        near ptr M00_L05
+       mov       rcx,r15
+       mov       r11,7FF92DE60F20
+       call      qword ptr [r11]
+       mov       rdx,rax
 M00_L19:
-       cmp       rsi,r13
-       jne       near ptr M00_L28
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       mov       r8d,eax
+       jmp       short M00_L14
 M00_L20:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
+       xor       r8d,r8d
+       jmp       short M00_L14
 M00_L21:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
 M00_L22:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
-M00_L23:
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1CB300029E8
+       mov       rdx,1C5B28009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CB300029F0
+       mov       rcx,1C5B28009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
+M00_L25:
        call      qword ptr [7FF92E137A20]
        int       3
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CB30001FC0
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1C59C802000
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE60CB0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60C90
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L09
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60CA8
+       mov       rcx,rsi
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
+       mov       r15,rax
+       jmp       near ptr M00_L09
 M00_L29:
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
+       call      qword ptr [r11]
+       jmp       near ptr M00_L06
+M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        short M00_L31
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L30
-       mov       r11,7FF92DE60CA8
+       je        short M00_L31
+       mov       rcx,r15
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
-M00_L30:
+M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1009
+; Total bytes of code 1017
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
-       call      qword ptr [7FF92E70EFA0]
+       call      qword ptr [7FF92E70E9E8]
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1CB300029F0
+       mov       rcx,19D09000A38
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L22
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L21
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       call      qword ptr [7FF92E127A20]
+       int       3
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
-M00_L03:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L02
-       inc       r14d
-       jmp       short M00_L02
-M00_L04:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L05:
+M00_L03:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       je        near ptr M00_L07
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
+       jne       near ptr M00_L07
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L07
+M00_L04:
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
        jne       near ptr M00_L10
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L16
-       mov       r8d,[r15+14]
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L09
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L17
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r15+8]
+       jae       near ptr M00_L15
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L12
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L07:
-       test      eax,eax
-       je        short M00_L06
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L11
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L05:
+       test      r8d,r8d
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L18
-       jmp       short M00_L06
-M00_L08:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L17
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r15+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r15+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
-       je        short M00_L10
+       jo        near ptr M00_L16
+       jmp       short M00_L04
+M00_L06:
        add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       jo        near ptr M00_L16
+M00_L07:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
+       jne       near ptr M00_L12
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L10
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
-M00_L11:
+       jae       short M00_L09
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L15
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L13
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L14
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L08:
+       test      r8d,r8d
+       je        near ptr M00_L07
+       jmp       near ptr M00_L06
+M00_L09:
        xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
+       jmp       short M00_L17
+M00_L10:
+       call      qword ptr [7FF92E12C150]
+       int       3
+M00_L11:
+       xor       r8d,r8d
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE60C98
+       mov       rcx,r15
+       mov       r11,7FF92DE511A0
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L19
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60CA0
+       je        short M00_L17
+       mov       rcx,r15
+       mov       r11,7FF92DE511A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L13:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
+       mov       r8d,eax
+       jmp       short M00_L08
+M00_L14:
+       xor       r8d,r8d
+       jmp       short M00_L08
 M00_L15:
-       xor       eax,eax
-       jmp       near ptr M00_L09
-M00_L16:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L18:
+M00_L16:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L19:
+M00_L17:
        cmp       rsi,r13
        jne       near ptr M00_L28
-M00_L20:
+M00_L18:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L21:
+M00_L19:
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
-M00_L22:
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       test      r15d,r15d
+       jle       short M00_L18
+       xor       esi,esi
+       jmp       short M00_L23
+M00_L22:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L18
 M00_L23:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L22
+       inc       r14d
+       jmp       short M00_L22
+M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1CB300029E8
+       mov       rdx,19D09000A30
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CB300029F0
+       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19D09000A38
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E137A20]
-       int       3
 M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CB30001FC0
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,19D09000AA8
        mov       r15,[rcx]
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L03
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE60CB0
+       mov       r11,7FF92DE511B8
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L03
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60C90
+       mov       r11,7FF92DE51198
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L05
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60CA8
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-       jmp       near ptr M00_L20
+       jmp       near ptr M00_L18
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L19
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE60CA8
+       mov       rcx,r15
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1009
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
-       call      qword ptr [7FF92E70EFA0]
+       call      qword ptr [7FF92E6F4DF8]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1CB300029F0
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L23
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
        je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L04
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L24
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L23
 M00_L01:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L03
-       jmp       near ptr M00_L20
+       call      qword ptr [7FF92E137A20]
+       int       3
 M00_L02:
-       inc       esi
-       cmp       esi,r15d
-       jge       near ptr M00_L20
-M00_L03:
-       mov       rdx,[r13+rsi*8]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L02
-       inc       r14d
-       jmp       short M00_L02
-M00_L04:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
-       jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
-M00_L05:
-       mov       [rbp-40],r15
+       mov       rcx,[rsi+8]
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
+M00_L03:
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L10
+       je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L10
+       jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
-       jne       near ptr M00_L10
-M00_L06:
+       jne       short M00_L06
+M00_L04:
        lea       r15,[rcx+8]
        mov       rdx,[r15]
        mov       rax,rdx
        mov       r8d,[r15+10]
        cmp       r8d,[rdx+14]
        jne       near ptr M00_L16
        mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L17
        mov       edx,r8d
        mov       rdx,[rdi+rdx*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r12,[rdx+30]
        test      r12,r12
-       je        near ptr M00_L12
+       je        short M00_L08
        cmp       dword ptr [r12+8],0
        setg      al
        movzx     eax,al
-M00_L07:
+M00_L05:
        test      eax,eax
-       je        short M00_L06
+       je        short M00_L04
        add       r14d,1
        jo        near ptr M00_L18
-       jmp       short M00_L06
+       jmp       short M00_L04
+M00_L06:
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       short M00_L09
+       lea       r15,[rcx+8]
+       mov       rax,[r15]
+       mov       edx,[r15+10]
+       mov       r8,[r15]
+       cmp       edx,[r8+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r15+14]
+       cmp       r8d,[rax+10]
+       jb        short M00_L10
+M00_L07:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       near ptr M00_L19
 M00_L08:
+       xor       eax,eax
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
+       call      qword ptr [r11]
+       test      eax,eax
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
        mov       rdx,[rax+8]
        cmp       r8d,[rdx+8]
        jae       near ptr M00_L17
        mov       eax,r8d
        mov       rdx,[rdx+rax*8+10]
        lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r15+14]
        mov       rcx,[rbp-40]
        mov       rdx,[rcx+10]
        mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],r11
-       jne       near ptr M00_L14
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L15
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L09:
-       test      eax,eax
-       je        short M00_L10
-       add       r14d,1
-       jo        near ptr M00_L18
-M00_L10:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       short M00_L13
-       lea       r15,[rcx+8]
-       mov       rdx,[r15]
-       mov       rax,rdx
-       mov       r8d,[r15+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L16
-       mov       r8d,[r15+14]
-       cmp       r8d,[rax+10]
-       jb        near ptr M00_L08
+       jne       short M00_L12
+       jmp       short M00_L13
 M00_L11:
-       xor       eax,eax
-       mov       [r15+8],rax
-       mov       dword ptr [r15+14],0FFFFFFFF
-       jmp       short M00_L19
-M00_L12:
-       xor       eax,eax
-       jmp       near ptr M00_L07
-M00_L13:
-       mov       r11,7FF92DE60C98
-       call      qword ptr [r11]
-       test      eax,eax
-       je        short M00_L19
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60CA0
+       mov       r11,7FF92DE618E8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L14:
+M00_L12:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       rcx,[rbp-40]
-       jmp       near ptr M00_L09
-M00_L15:
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
        xor       eax,eax
-       jmp       near ptr M00_L09
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L15:
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
 M00_L16:
        call      qword ptr [7FF92E13C150]
        int       3
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
 M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
 M00_L23:
+       test      r15d,r15d
+       jle       short M00_L20
+       xor       esi,esi
+       jmp       short M00_L25
+M00_L24:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L20
+M00_L25:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L24
+       inc       r14d
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1CB300029E8
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1CB300029F0
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L24:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1CB30001FC0
-       mov       r15,[rcx]
-       jmp       near ptr M00_L05
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE60CB0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60C90
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L05
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FF92DE60CA8
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
        jmp       near ptr M00_L20
 M00_L29:
        xor       eax,eax
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       r11,7FF92DE60CA8
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1009
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E70EFA0]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,237278009F8
+       mov       rcx,1C5B28009F8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L13
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        jne       near ptr M00_L13
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
        jne       near ptr M00_L13
 M00_L10:
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L22
+       jne       near ptr M00_L16
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L15
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L21
        mov       ecx,r8d
        mov       rdx,[rdi+rcx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rax,[rdx+30]
        test      rax,rax
-       je        near ptr M00_L16
+       je        near ptr M00_L17
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
 M00_L11:
        test      r8d,r8d
        je        short M00_L10
        add       r14d,1
-       jo        near ptr M00_L21
+       jo        near ptr M00_L22
        jmp       short M00_L10
 M00_L12:
        add       r14d,1
-       jo        near ptr M00_L21
+       jo        near ptr M00_L22
 M00_L13:
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L17
+       jne       near ptr M00_L18
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L22
+       jne       near ptr M00_L16
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       short M00_L15
        mov       rcx,[rax+8]
        cmp       r8d,[rcx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L21
        mov       edx,r8d
        mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       short M00_L18
+       jne       short M00_L19
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M00_L19
+       je        short M00_L20
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
        jmp       near ptr M00_L05
 M00_L16:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L17:
        xor       r8d,r8d
        jmp       near ptr M00_L11
-M00_L17:
+M00_L18:
        mov       rcx,r15
-       mov       r11,7FF92DE60C98
+       mov       r11,7FF92DE60F18
        call      qword ptr [r11]
        test      eax,eax
        je        near ptr M00_L05
        mov       rcx,r15
-       mov       r11,7FF92DE60CA0
+       mov       r11,7FF92DE60F20
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L18:
+M00_L19:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       r8d,eax
        jmp       short M00_L14
-M00_L19:
+M00_L20:
        xor       r8d,r8d
        jmp       short M00_L14
-M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
 M00_L21:
-       call      CORINFO_HELP_OVERFLOW
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
-       call      qword ptr [7FF92E13C150]
+       call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L23:
        lea       r13,[rsi+10]
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
        jmp       near ptr M00_L01
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,237278009F0
+       mov       rdx,1C5B28009F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,237278009F8
+       mov       rcx,1C5B28009F8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FF92E137A20]
        int       3
 M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23711801FC8
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1C59C802000
        mov       r15,[rcx]
        jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60CB0
+       mov       r11,7FF92DE60F30
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L09
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FF92DE60C90
+       mov       r11,7FF92DE60F10
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L09
 M00_L29:
        mov       rcx,r15
-       mov       r11,7FF92DE60CA8
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
        jmp       near ptr M00_L06
 M00_L30:
        xor       eax,eax
        jmp       near ptr M00_L07
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L31
        mov       rcx,r15
-       mov       r11,7FF92DE60CA8
+       mov       r11,7FF92DE60F28
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1018
+; Total bytes of code 1017
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
-       call      qword ptr [7FF92E6FCAF8]
+       call      qword ptr [7FF92E70E9E8]
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,237278009F8
+       mov       rcx,19D09000A38
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L08
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L21
 M00_L01:
-       test      r15d,r15d
-       jle       short M00_L06
-       xor       esi,esi
-       jmp       short M00_L04
+       call      qword ptr [7FF92E127A20]
+       int       3
 M00_L02:
-       inc       r14d
-M00_L03:
-       add       rsi,8
-       dec       r15d
-       je        short M00_L06
-M00_L04:
-       mov       rdx,[rsi+r13]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L03
-       jmp       short M00_L02
-M00_L05:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L06:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L07:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L09:
+M00_L03:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
+       je        near ptr M00_L07
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
+       jne       near ptr M00_L07
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       near ptr M00_L13
-M00_L10:
+       jne       near ptr M00_L07
+M00_L04:
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L22
+       jne       near ptr M00_L10
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L15
+       jae       near ptr M00_L09
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L15
        mov       ecx,r8d
        mov       rdx,[rdi+rcx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rax,[rdx+30]
        test      rax,rax
-       je        near ptr M00_L16
+       je        near ptr M00_L11
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
-M00_L11:
+M00_L05:
        test      r8d,r8d
-       je        short M00_L10
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L10
-M00_L12:
+       jo        near ptr M00_L16
+       jmp       short M00_L04
+M00_L06:
        add       r14d,1
-       jo        near ptr M00_L21
-M00_L13:
+       jo        near ptr M00_L16
+M00_L07:
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L17
+       jne       near ptr M00_L12
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L22
+       jne       short M00_L10
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L15
+       jae       short M00_L09
        mov       rcx,[rax+8]
        cmp       r8d,[rcx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L15
        mov       edx,r8d
        mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       short M00_L18
+       jne       short M00_L13
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M00_L19
+       je        short M00_L14
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
-M00_L14:
+M00_L08:
        test      r8d,r8d
-       je        near ptr M00_L13
-       jmp       near ptr M00_L12
-M00_L15:
+       je        near ptr M00_L07
+       jmp       near ptr M00_L06
+M00_L09:
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
-       jmp       near ptr M00_L05
-M00_L16:
+       jmp       short M00_L17
+M00_L10:
+       call      qword ptr [7FF92E12C150]
+       int       3
+M00_L11:
        xor       r8d,r8d
-       jmp       near ptr M00_L11
-M00_L17:
+       jmp       near ptr M00_L05
+M00_L12:
        mov       rcx,r15
-       mov       r11,7FF92DE60C98
+       mov       r11,7FF92DE511A0
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L05
+       je        short M00_L17
        mov       rcx,r15
-       mov       r11,7FF92DE60CA0
+       mov       r11,7FF92DE511A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L18:
+M00_L13:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       r8d,eax
-       jmp       short M00_L14
-M00_L19:
+       jmp       short M00_L08
+M00_L14:
        xor       r8d,r8d
-       jmp       short M00_L14
-M00_L20:
+       jmp       short M00_L08
+M00_L15:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L16:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L22:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L23:
+M00_L17:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L18:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L19:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       test      r15d,r15d
+       jle       short M00_L18
+       xor       esi,esi
+       jmp       short M00_L23
+M00_L22:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L18
+M00_L23:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L22
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,237278009F0
+       mov       rdx,19D09000A30
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,237278009F8
+       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19D09000A38
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23711801FC8
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,19D09000AA8
        mov       r15,[rcx]
-       jmp       near ptr M00_L09
-M00_L27:
+       jmp       near ptr M00_L03
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE60CB0
+       mov       r11,7FF92DE511B8
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L09
-M00_L28:
+       jmp       near ptr M00_L03
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60C90
+       mov       r11,7FF92DE51198
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L09
-M00_L29:
+       jmp       near ptr M00_L03
+M00_L28:
        mov       rcx,r15
-       mov       r11,7FF92DE60CA8
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-       jmp       near ptr M00_L06
-M00_L30:
+       jmp       near ptr M00_L18
+M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L19
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
-       mov       r11,7FF92DE60CA8
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1018
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
-       call      qword ptr [7FF92E6FCAF8]
+       call      qword ptr [7FF92E6F4DF8]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,237278009F8
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L08
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L23
 M00_L01:
-       test      r15d,r15d
-       jle       short M00_L06
-       xor       esi,esi
-       jmp       short M00_L04
+       call      qword ptr [7FF92E137A20]
+       int       3
 M00_L02:
-       inc       r14d
-M00_L03:
-       add       rsi,8
-       dec       r15d
-       je        short M00_L06
-M00_L04:
-       mov       rdx,[rsi+r13]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L03
-       jmp       short M00_L02
-M00_L05:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L06:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L07:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
        jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
-M00_L09:
-       mov       [rbp-40],r15
+       mov       rcx,[rsi+8]
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
+M00_L03:
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L13
-M00_L10:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L22
-       mov       r8d,[r12+14]
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       short M00_L06
+M00_L04:
+       lea       r15,[rcx+8]
+       mov       rdx,[r15]
+       mov       rax,rdx
+       mov       r8d,[r15+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L15
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L20
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       jae       near ptr M00_L17
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L16
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
-M00_L11:
-       test      r8d,r8d
-       je        short M00_L10
-       add       r14d,1
-       jo        near ptr M00_L21
-       jmp       short M00_L10
-M00_L12:
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        short M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L21
-M00_L13:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       jo        near ptr M00_L18
+       jmp       short M00_L04
+M00_L06:
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L17
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L22
-       mov       r8d,[r12+14]
+       jne       short M00_L09
+       lea       r15,[rcx+8]
+       mov       rax,[r15]
+       mov       edx,[r15+10]
+       mov       r8,[r15]
+       cmp       edx,[r8+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L15
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
-       jae       near ptr M00_L20
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L18
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L19
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
-M00_L14:
-       test      r8d,r8d
-       je        near ptr M00_L13
-       jmp       near ptr M00_L12
-M00_L15:
+       jb        short M00_L10
+M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
-       jmp       near ptr M00_L05
-M00_L16:
-       xor       r8d,r8d
-       jmp       near ptr M00_L11
-M00_L17:
-       mov       rcx,r15
-       mov       r11,7FF92DE60C98
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L08:
+       xor       eax,eax
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L05
-       mov       rcx,r15
-       mov       r11,7FF92DE60CA0
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L17
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r15+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618E8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L18:
+M00_L12:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L14
-M00_L19:
-       xor       r8d,r8d
-       jmp       short M00_L14
-M00_L20:
+       mov       rcx,[rbp-40]
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
+       xor       eax,eax
+       jmp       short M00_L15
+M00_L14:
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L15:
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
+M00_L16:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L21:
+M00_L18:
        call      CORINFO_HELP_OVERFLOW
        int       3
+M00_L19:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L20:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L21:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L22:
-       call      qword ptr [7FF92E13C150]
-       int       3
-M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L23:
+       test      r15d,r15d
+       jle       short M00_L20
+       xor       esi,esi
+       jmp       short M00_L25
 M00_L24:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L20
+M00_L25:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L24
+       inc       r14d
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,237278009F0
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,237278009F8
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23711801FC8
-       mov       r15,[rcx]
-       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60CB0
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L09
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,rsi
-       mov       r11,7FF92DE60C90
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L09
+       jmp       near ptr M00_L20
 M00_L29:
-       mov       rcx,r15
-       mov       r11,7FF92DE60CA8
-       call      qword ptr [r11]
-       jmp       near ptr M00_L06
-M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       je        short M00_L30
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FF92DE60CA8
+       je        short M00_L30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1018
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E6FCAF8]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1C5B28009F8
+       mov       rcx,19D09000A38
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L08
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L21
 M00_L01:
-       test      r15d,r15d
-       jle       short M00_L06
-       xor       esi,esi
-       jmp       short M00_L04
+       call      qword ptr [7FF92E127A20]
+       int       3
 M00_L02:
-       inc       r14d
-M00_L03:
-       add       rsi,8
-       dec       r15d
-       je        short M00_L06
-M00_L04:
-       mov       rdx,[rsi+r13]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L03
-       jmp       short M00_L02
-M00_L05:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L06:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L07:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L27
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
+       je        near ptr M00_L25
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r13
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
-M00_L09:
+M00_L03:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
+       je        near ptr M00_L07
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
+       jne       near ptr M00_L07
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       near ptr M00_L13
-M00_L10:
+       jne       near ptr M00_L07
+M00_L04:
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L16
+       jne       near ptr M00_L10
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L15
+       jae       near ptr M00_L09
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L21
+       jae       near ptr M00_L15
        mov       ecx,r8d
        mov       rdx,[rdi+rcx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rax,[rdx+30]
        test      rax,rax
-       je        near ptr M00_L17
+       je        near ptr M00_L11
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
-M00_L11:
+M00_L05:
        test      r8d,r8d
-       je        short M00_L10
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L22
-       jmp       short M00_L10
-M00_L12:
+       jo        near ptr M00_L16
+       jmp       short M00_L04
+M00_L06:
        add       r14d,1
-       jo        near ptr M00_L22
-M00_L13:
+       jo        near ptr M00_L16
+M00_L07:
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L18
+       jne       near ptr M00_L12
        lea       r12,[r15+8]
        mov       rcx,[r12]
        mov       rax,rcx
        mov       edx,[r12+10]
        cmp       edx,[rcx+14]
-       jne       near ptr M00_L16
+       jne       short M00_L10
        mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L15
+       jae       short M00_L09
        mov       rcx,[rax+8]
        cmp       r8d,[rcx+8]
-       jae       near ptr M00_L21
+       jae       near ptr M00_L15
        mov       edx,r8d
        mov       rdx,[rcx+rdx*8+10]
        lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
        inc       dword ptr [r12+14]
        mov       rdx,[r15+10]
        mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rcx
-       jne       short M00_L19
+       jne       short M00_L13
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M00_L20
+       je        short M00_L14
        cmp       dword ptr [rax+8],0
        setg      r8b
        movzx     r8d,r8b
-M00_L14:
+M00_L08:
        test      r8d,r8d
-       je        near ptr M00_L13
-       jmp       near ptr M00_L12
-M00_L15:
+       je        near ptr M00_L07
+       jmp       near ptr M00_L06
+M00_L09:
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
-       jmp       near ptr M00_L05
-M00_L16:
-       call      qword ptr [7FF92E13C150]
+       jmp       short M00_L17
+M00_L10:
+       call      qword ptr [7FF92E12C150]
        int       3
-M00_L17:
+M00_L11:
        xor       r8d,r8d
-       jmp       near ptr M00_L11
-M00_L18:
+       jmp       near ptr M00_L05
+M00_L12:
        mov       rcx,r15
-       mov       r11,7FF92DE60F18
+       mov       r11,7FF92DE511A0
        call      qword ptr [r11]
        test      eax,eax
-       je        near ptr M00_L05
+       je        short M00_L17
        mov       rcx,r15
-       mov       r11,7FF92DE60F20
+       mov       r11,7FF92DE511A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L19:
+M00_L13:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        mov       r8d,eax
-       jmp       short M00_L14
-M00_L20:
+       jmp       short M00_L08
+M00_L14:
        xor       r8d,r8d
-       jmp       short M00_L14
-M00_L21:
+       jmp       short M00_L08
+M00_L15:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L22:
+M00_L16:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L23:
+M00_L17:
+       cmp       rsi,r13
+       jne       near ptr M00_L28
+M00_L18:
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
+M00_L19:
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L21:
+       test      r15d,r15d
+       jle       short M00_L18
+       xor       esi,esi
+       jmp       short M00_L23
+M00_L22:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L18
+M00_L23:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L22
+       inc       r14d
+       jmp       short M00_L22
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C5B28009F0
+       mov       rdx,19D09000A30
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1C5B28009F8
+       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,19D09000A38
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
 M00_L25:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C59C802000
+       mov       rcx,19D09000AA8
        mov       r15,[rcx]
-       jmp       near ptr M00_L09
-M00_L27:
+       jmp       near ptr M00_L03
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F30
+       mov       r11,7FF92DE511B8
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L09
-M00_L28:
+       jmp       near ptr M00_L03
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F10
+       mov       r11,7FF92DE51198
        call      qword ptr [r11]
        mov       r15,rax
-       jmp       near ptr M00_L09
-M00_L29:
+       jmp       near ptr M00_L03
+M00_L28:
        mov       rcx,r15
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-       jmp       near ptr M00_L06
-M00_L30:
+       jmp       near ptr M00_L18
+M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L19
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
-       mov       r11,7FF92DE60F28
+       mov       r11,7FF92DE511B0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1017
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
-       call      qword ptr [7FF92E70E9E8]
+       call      qword ptr [7FF92E6F4DF8]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,1C5B28009F8
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L30
+       je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L23
+       je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
-       jne       short M00_L08
+       jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L25
+       jb        short M00_L01
        add       r13,10
+       jmp       near ptr M00_L23
 M00_L01:
-       test      r15d,r15d
-       jle       short M00_L06
-       xor       esi,esi
-       jmp       short M00_L04
+       call      qword ptr [7FF92E137A20]
+       int       3
 M00_L02:
-       inc       r14d
-M00_L03:
-       add       rsi,8
-       dec       r15d
-       je        short M00_L06
-M00_L04:
-       mov       rdx,[rsi+r13]
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       test      eax,eax
-       je        short M00_L03
-       jmp       short M00_L02
-M00_L05:
-       cmp       rsi,r13
-       jne       near ptr M00_L29
-M00_L06:
-       test      r14d,r14d
-       setg      al
-       movzx     eax,al
-M00_L07:
-       mov       rcx,[rbx+60]
-       mov       [rcx+4C],al
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M00_L08:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
        jne       near ptr M00_L27
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L26
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
-M00_L09:
-       mov       [rbp-40],r15
+       mov       rcx,[rsi+8]
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
+M00_L03:
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L13
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L13
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L13
-M00_L10:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       short M00_L06
+M00_L04:
+       lea       r15,[rcx+8]
+       mov       rdx,[r15]
+       mov       rax,rdx
+       mov       r8d,[r15+10]
+       cmp       r8d,[rdx+14]
        jne       near ptr M00_L16
-       mov       r8d,[r12+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L15
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L21
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       jae       near ptr M00_L17
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L17
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
-M00_L11:
-       test      r8d,r8d
-       je        short M00_L10
-       add       r14d,1
-       jo        near ptr M00_L22
-       jmp       short M00_L10
-M00_L12:
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        short M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L22
-M00_L13:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       jo        near ptr M00_L18
+       jmp       short M00_L04
+M00_L06:
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L18
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
+       jne       short M00_L09
+       lea       r15,[rcx+8]
+       mov       rax,[r15]
+       mov       edx,[r15+10]
+       mov       r8,[r15]
+       cmp       edx,[r8+14]
        jne       near ptr M00_L16
-       mov       r8d,[r12+14]
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L15
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
-       jae       near ptr M00_L21
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       jb        short M00_L10
+M00_L07:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       near ptr M00_L19
+M00_L08:
+       xor       eax,eax
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
+       call      qword ptr [r11]
+       test      eax,eax
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L17
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L19
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L20
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618E8
+       call      qword ptr [r11]
+       mov       rdx,rax
+M00_L12:
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       mov       rcx,[rbp-40]
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
+       xor       eax,eax
+       jmp       short M00_L15
 M00_L14:
-       test      r8d,r8d
-       je        near ptr M00_L13
-       jmp       near ptr M00_L12
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L15:
-       xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
-       jmp       near ptr M00_L05
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
 M00_L16:
        call      qword ptr [7FF92E13C150]
        int       3
 M00_L17:
-       xor       r8d,r8d
-       jmp       near ptr M00_L11
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
 M00_L18:
-       mov       rcx,r15
-       mov       r11,7FF92DE60F18
-       call      qword ptr [r11]
-       test      eax,eax
-       je        near ptr M00_L05
-       mov       rcx,r15
-       mov       r11,7FF92DE60F20
-       call      qword ptr [r11]
-       mov       rdx,rax
+       call      CORINFO_HELP_OVERFLOW
+       int       3
 M00_L19:
-       mov       rcx,[rdi+8]
-       call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L14
+       cmp       rsi,r13
+       jne       near ptr M00_L28
 M00_L20:
-       xor       r8d,r8d
-       jmp       short M00_L14
+       test      r14d,r14d
+       setg      al
+       movzx     eax,al
 M00_L21:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,[rbx+60]
+       mov       [rcx+4C],al
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
 M00_L22:
-       call      CORINFO_HELP_OVERFLOW
-       int       3
-M00_L23:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-       jmp       near ptr M00_L01
+M00_L23:
+       test      r15d,r15d
+       jle       short M00_L20
+       xor       esi,esi
+       jmp       short M00_L25
 M00_L24:
+       add       rsi,8
+       dec       r15d
+       je        short M00_L20
+M00_L25:
+       mov       rdx,[rsi+r13]
+       mov       rcx,[rdi+8]
+       call      qword ptr [rdi+18]
+       test      eax,eax
+       je        short M00_L24
+       inc       r14d
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C5B28009F0
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1C5B28009F8
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       call      qword ptr [7FF92E137A20]
-       int       3
-M00_L26:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1C59C802000
-       mov       r15,[rcx]
-       jmp       near ptr M00_L09
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE60F30
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L09
+       mov       rcx,rax
+       jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,rsi
-       mov       r11,7FF92DE60F10
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L09
+       jmp       near ptr M00_L20
 M00_L29:
-       mov       rcx,r15
-       mov       r11,7FF92DE60F28
-       call      qword ptr [r11]
-       jmp       near ptr M00_L06
-M00_L30:
        xor       eax,eax
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       je        short M00_L30
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FF92DE60F28
+       je        short M00_L30
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-M00_L31:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1017
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E70E9E8]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmptyWithPredicate method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
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
        mov       rsi,[rbx+278]
-       mov       rcx,19D09000A38
+       mov       rcx,20BC6400B68
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L26
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L29
        xor       r14d,r14d
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rax
-       je        near ptr M00_L20
+       je        near ptr M00_L22
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rax
        jne       short M00_L02
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        short M00_L01
        add       r13,10
-       jmp       near ptr M00_L21
+       jmp       near ptr M00_L23
 M00_L01:
-       call      qword ptr [7FF92E127A20]
+       call      qword ptr [7FF92E137A20]
        int       3
 M00_L02:
        mov       rcx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L27
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
-       jne       near ptr M00_L26
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L25
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r13
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
+       mov       r11,7FF92DE618F8
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L03:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L07
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L07
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L07
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       short M00_L06
 M00_L04:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L10
-       mov       r8d,[r12+14]
+       lea       r15,[rcx+8]
+       mov       rdx,[r15]
+       mov       rax,rdx
+       mov       r8d,[r15+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       near ptr M00_L09
+       jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
-       jae       near ptr M00_L15
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       jae       near ptr M00_L17
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r15+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L11
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        short M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L05:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L04
        add       r14d,1
-       jo        near ptr M00_L16
+       jo        near ptr M00_L18
        jmp       short M00_L04
 M00_L06:
-       add       r14d,1
-       jo        near ptr M00_L16
-M00_L07:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
-       jne       near ptr M00_L12
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L10
-       mov       r8d,[r12+14]
+       jne       short M00_L09
+       lea       r15,[rcx+8]
+       mov       rax,[r15]
+       mov       edx,[r15+10]
+       mov       r8,[r15]
+       cmp       edx,[r8+14]
+       jne       near ptr M00_L16
+       mov       r8d,[r15+14]
        cmp       r8d,[rax+10]
-       jae       short M00_L09
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
-       jae       near ptr M00_L15
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L13
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L14
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       jb        short M00_L10
+M00_L07:
+       xor       eax,eax
+       mov       [r15+8],rax
+       mov       dword ptr [r15+14],0FFFFFFFF
+       jmp       near ptr M00_L19
 M00_L08:
-       test      r8d,r8d
-       je        near ptr M00_L07
-       jmp       near ptr M00_L06
-M00_L09:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
-       jmp       short M00_L17
-M00_L10:
-       call      qword ptr [7FF92E12C150]
-       int       3
-M00_L11:
-       xor       r8d,r8d
-       jmp       near ptr M00_L05
-M00_L12:
-       mov       rcx,r15
-       mov       r11,7FF92DE511A0
+       jmp       short M00_L05
+M00_L09:
+       mov       r11,7FF92DE618E0
        call      qword ptr [r11]
        test      eax,eax
-       je        short M00_L17
-       mov       rcx,r15
-       mov       r11,7FF92DE511A8
+       jne       short M00_L11
+       jmp       near ptr M00_L19
+M00_L10:
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
+       jae       near ptr M00_L17
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r15+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r15+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       short M00_L12
+       jmp       short M00_L13
+M00_L11:
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618E8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L13:
+M00_L12:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L08
+       mov       rcx,[rbp-40]
+       jmp       short M00_L15
+M00_L13:
+       mov       r12,[rdx+30]
+       test      r12,r12
+       jne       short M00_L14
+       xor       eax,eax
+       jmp       short M00_L15
 M00_L14:
-       xor       r8d,r8d
-       jmp       short M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L15:
+       test      eax,eax
+       je        near ptr M00_L06
+       add       r14d,1
+       jo        short M00_L18
+       jmp       near ptr M00_L06
+M00_L16:
+       call      qword ptr [7FF92E13C150]
+       int       3
+M00_L17:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L16:
+M00_L18:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M00_L17:
+M00_L19:
        cmp       rsi,r13
        jne       near ptr M00_L28
-M00_L18:
+M00_L20:
        test      r14d,r14d
        setg      al
        movzx     eax,al
-M00_L19:
+M00_L21:
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
-M00_L20:
+M00_L22:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L21:
+M00_L23:
        test      r15d,r15d
-       jle       short M00_L18
+       jle       short M00_L20
        xor       esi,esi
-       jmp       short M00_L23
-M00_L22:
+       jmp       short M00_L25
+M00_L24:
        add       rsi,8
        dec       r15d
-       je        short M00_L18
-M00_L23:
+       je        short M00_L20
+M00_L25:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
+       je        short M00_L24
        inc       r14d
-       jmp       short M00_L22
-M00_L24:
+       jmp       short M00_L24
+M00_L26:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,19D09000A30
+       mov       rdx,20BC6400B60
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<IsNotEmptyWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FF92DF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,19D09000A38
+       call      qword ptr [7FF92DF16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20BC6400B68
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,19D09000AA8
-       mov       r15,[rcx]
-       jmp       near ptr M00_L03
-M00_L26:
-       mov       rcx,rsi
-       mov       r11,7FF92DE511B8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L03
 M00_L27:
        mov       rcx,rsi
-       mov       r11,7FF92DE51198
+       mov       r11,7FF92DE618D8
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L03
 M00_L28:
-       mov       rcx,r15
-       mov       r11,7FF92DE511B0
+       mov       rcx,[rbp-40]
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
-       jmp       near ptr M00_L18
+       jmp       near ptr M00_L20
 M00_L29:
        xor       eax,eax
-       jmp       near ptr M00_L19
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L30
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L30
-       mov       rcx,r15
-       mov       r11,7FF92DE511B0
+       mov       r11,7FF92DE618F0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1002
+; Total bytes of code 867
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
-       call      qword ptr [7FF92E6F4DF8]
+       call      qword ptr [7FF92E617918]
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
-       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50C60
+       mov       r11,7FF92DE70C60
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50C60
+       mov       r11,7FF92DE40EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50C60
+       mov       r11,7FF92DE40EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50C60
+       mov       r11,7FF92DE50EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50C60
+       mov       r11,7FF92DE70C60
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50C60
+       mov       r11,7FF92DE51228
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE50C60
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE70C60
+       mov       r11,7FF92DE40EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE70C60
+       mov       r11,7FF92DE40EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE70C60
+       mov       r11,7FF92DE50EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE70C60
+       mov       r11,7FF92DE51228
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE70C60
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE40EF0
+       mov       r11,7FF92DE50EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE40EF0
+       mov       r11,7FF92DE70C60
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE40EF0
+       mov       r11,7FF92DE51228
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE40EF0
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE40EF0
+       mov       r11,7FF92DE50EF0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE40EF0
+       mov       r11,7FF92DE70C60
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE40EF0
+       mov       r11,7FF92DE51228
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE40EF0
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50EF0
+       mov       r11,7FF92DE70C60
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE50EF0
+       mov       r11,7FF92DE51228
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE50EF0
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+60]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FF92DE70C60
+       mov       r11,7FF92DE51228
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for IsNotEmpty method between:**
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE70C60
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
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.IsNotEmpty()
-       push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+278]
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
+       mov       r11,7FF92DE418E8
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
-       mov       r11,7FF92DE51228
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
