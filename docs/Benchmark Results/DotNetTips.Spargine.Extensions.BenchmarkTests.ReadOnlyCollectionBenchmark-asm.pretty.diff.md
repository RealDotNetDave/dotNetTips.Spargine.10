## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark-20251226-020623
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
+       test      byte ptr [7FFF807B57A0],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,1BDCA402C18
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,158A5400068
+       mov       rcx,1BDCA400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,19C7944F
+       mov       r10d,8C9FD17F
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
+       mov       r11,7FFF7FD60F58
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD710D0
+       mov       r11,7FFF7FD60F50
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
+       call      qword ptr [7FFF80807E88]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE580]
+       call      qword ptr [7FFF804EE610]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80342378
+       call      qword ptr [7FFF80097738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80215D90
+       call      qword ptr [7FFF80097738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80342378
+       call      qword ptr [7FFF80097738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF80744378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF80744390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD710E8
+       mov       r11,7FFF7FD60F68
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FD60F70
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       mov       rcx,1BDCA402C18
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FD60F48
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD60F60
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD60F60
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
+       mov       rax,1FE5F2C0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF80806DD8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
+       test      byte ptr [7FFF807C9E70],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,2396E000C20
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,158A5400068
+       mov       rcx,23958000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,86B5BF34
+       mov       r10d,311E6579
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
+       mov       r11,7FFF7FD70F50
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD710D0
+       mov       r11,7FFF7FD70F48
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
+       call      qword ptr [7FFF80817E58]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE580]
+       call      qword ptr [7FFF804FE610]
        mov       ecx,5B
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
        mov       rdx,7FFF80225D90
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD710E8
+       mov       r11,7FFF7FD70F60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FD70F68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       mov       rcx,2396E000C20
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FD70F40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD70F58
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD70F58
        call      qword ptr [r11]
 M00_L30:
        nop
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
+       mov       rax,279ECEE0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF80816DA8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
+       test      byte ptr [7FFF807D1920],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,16A79C02C18
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,158A5400068
+       mov       rcx,16A79C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,2F2A3545
+       mov       r10d,534958C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
+       mov       r11,7FFF7FD90F50
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD710D0
+       mov       r11,7FFF7FD90F48
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
+       call      qword ptr [7FFF80847A38]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE580]
+       call      qword ptr [7FFF8051E058]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80372378
+       call      qword ptr [7FFF800C7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80245D90
+       call      qword ptr [7FFF800C7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80372378
+       call      qword ptr [7FFF800C7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF8066FF60]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF8066FF78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD710E8
+       mov       r11,7FFF7FD90F60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FD90F68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       mov       rcx,16A79C02C18
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FD90F40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD90F58
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD90F58
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
+       mov       rax,1AB0EB70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF80846988]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L24
+       jne       near ptr M00_L25
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L27
+       je        near ptr M00_L28
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
-       je        near ptr M00_L25
+       jne       near ptr M00_L23
+       test      byte ptr [7FFF8079FB30],1
+       je        near ptr M00_L26
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L18
+       jne       near ptr M00_L20
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L19
        mov       [rax+8],ecx
+M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L10
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L22
        mov       rsi,[rcx+r11*8+10]
-M00_L04:
+M00_L05:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L13
-       mov       rcx,158A5400068
+       je        near ptr M00_L12
+       mov       rcx,1BDD7C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L17
+       jne       near ptr M00_L18
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,0E5D4FDDC
+       mov       r10d,20BB6781
        cmp       edx,8
-       jb        near ptr M00_L09
+       jb        near ptr M00_L13
        mov       r9d,edx
        shr       r9d,3
-M00_L05:
+M00_L06:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L05
+       jne       short M00_L06
        test      dl,4
-       jne       short M00_L10
-M00_L06:
+       jne       near ptr M00_L14
+M00_L07:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L07:
+M00_L08:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L08:
+M00_L09:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L09:
-       cmp       edx,4
-       jb        short M00_L14
 M00_L10:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF807A5590]
+       int       3
+M00_L11:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        near ptr M00_L04
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D50
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L05
+M00_L12:
+       xor       r8d,r8d
+       jmp       short M00_L09
+M00_L13:
+       cmp       edx,4
+       jae       short M00_L14
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L16
+       jmp       short M00_L15
+M00_L14:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L06
-M00_L11:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       jmp       near ptr M00_L21
-M00_L12:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L04
-M00_L13:
-       xor       r8d,r8d
-       jmp       short M00_L08
-M00_L14:
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L15
+       jmp       near ptr M00_L07
+M00_L15:
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L15:
+M00_L16:
        test      dl,2
-       je        short M00_L16
+       je        short M00_L17
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L07
-M00_L16:
-       mov       ecx,r9d
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L08
 M00_L17:
+       mov       ecx,r9d
+       jmp       near ptr M00_L08
+M00_L18:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L08
-M00_L18:
-       mov       rcx,rax
-       mov       r11,7FFF7FD710D0
-       call      qword ptr [r11]
-       test      eax,eax
-       jne       near ptr M00_L12
-       jmp       near ptr M00_L29
+       jmp       near ptr M00_L09
 M00_L19:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
-       int       3
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       xor       esi,esi
+       jmp       short M00_L21
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D48
+       call      qword ptr [r11]
+       mov       esi,eax
 M00_L21:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       test      esi,esi
+       jne       near ptr M00_L11
+       jmp       near ptr M00_L30
 M00_L22:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L23:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L23:
-       call      qword ptr [7FFF804FE580]
+M00_L24:
+       call      qword ptr [7FFF80526A30]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80255D90
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF8065C870]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF8065C888]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L24:
-       mov       r11,7FFF7FD710E8
+M00_L25:
+       mov       r11,7FFF7FDA0D60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L27
+       je        short M00_L28
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FDA0D68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L27:
+M00_L28:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L28:
+M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FDA0D40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L29:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+M00_L30:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
+M00_L31:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-M00_L30:
+M00_L32:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1160
+; Total bytes of code 1204
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
+       mov       rax,1FE6CCE0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF807AFD50]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
+       test      byte ptr [7FFF807C9E70],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,158A5400068
+       mov       rcx,278FC800068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,0EF90DC4
+       mov       r10d,0E0430C69
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
+       mov       r11,7FFF7FD71110
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD710D0
+       mov       r11,7FFF7FD71108
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
+       call      qword ptr [7FFF8075EB50]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE580]
+       call      qword ptr [7FFF804FE610]
        mov       ecx,5B
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
        mov       rdx,7FFF80225D90
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD710E8
+       mov       r11,7FFF7FD71120
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FD71128
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FD71100
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
 M00_L30:
        nop
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
+       mov       rax,2B991A70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF80816F28]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
+       test      byte ptr [7FFF8080C220],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,158A5400068
+       mov       rcx,147C4000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,71E91FB3
+       mov       r10d,9BC5B61C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
+       mov       r11,7FFF7FD813C8
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD710D0
+       mov       r11,7FFF7FD813C0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
+       call      qword ptr [7FFF8074F6C0]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE580]
+       call      qword ptr [7FFF8050E628]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80235D90
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF80745E78]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF80745E90]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD710E8
+       mov       r11,7FFF7FD813D8
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FD813E0
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FD813B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
+       mov       rax,18859390008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF808275E8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C7FA0],1
+       test      byte ptr [7FFF8092B1F8],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,158A5402C18
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,158A5400068
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,5019CAB4
-       mov       r10d,137E7F2A
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710D8
+       mov       r11,7FFF7FD717A0
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD710D0
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E88]
+       call      qword ptr [7FFF808C75E8]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE580]
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
        mov       rdx,7FFF80225D90
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF806D4348]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF806D4360]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD710E8
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710F0
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,158A5402C18
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD710C8
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD710E0
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
+       lea       rdx,[rsi+0C]
        call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
+       lea       rdx,[rbx+0C]
        call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,1993A4F0008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF80816DD8]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807B57A0],1
+       test      byte ptr [7FFF807C9E70],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDCA402C18
+       mov       rcx,2396E000C20
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,1BDCA400068
+       mov       rcx,23958000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,19C7944F
-       mov       r10d,8C9FD17F
+       mov       r8d,86B5BF34
+       mov       r10d,311E6579
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F58
+       mov       r11,7FFF7FD70F50
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD60F50
+       mov       r11,7FFF7FD70F48
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80807E88]
+       call      qword ptr [7FFF80817E58]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804EE610]
+       call      qword ptr [7FFF804FE610]
        mov       ecx,5B
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80215D90
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80744378]
+       call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80744390]
+       call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD60F68
+       mov       r11,7FFF7FD70F60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F70
+       mov       r11,7FFF7FD70F68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDCA402C18
+       mov       rcx,2396E000C20
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F48
+       mov       r11,7FFF7FD70F40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD70F58
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD70F58
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE5F2C0008
+       mov       rax,279ECEE0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80806DD8]
+       call      qword ptr [7FFF80816DA8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807B57A0],1
+       test      byte ptr [7FFF807D1920],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDCA402C18
+       mov       rcx,16A79C02C18
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,1BDCA400068
+       mov       rcx,16A79C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,19C7944F
-       mov       r10d,8C9FD17F
+       mov       r8d,2F2A3545
+       mov       r10d,534958C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F58
+       mov       r11,7FFF7FD90F50
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD60F50
+       mov       r11,7FFF7FD90F48
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80807E88]
+       call      qword ptr [7FFF80847A38]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804EE610]
+       call      qword ptr [7FFF8051E058]
        mov       ecx,5B
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80372378
+       call      qword ptr [7FFF800C7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80215D90
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80245D90
+       call      qword ptr [7FFF800C7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80372378
+       call      qword ptr [7FFF800C7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80744378]
+       call      qword ptr [7FFF8066FF60]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80744390]
+       call      qword ptr [7FFF8066FF78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD60F68
+       mov       r11,7FFF7FD90F60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F70
+       mov       r11,7FFF7FD90F68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDCA402C18
+       mov       rcx,16A79C02C18
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F48
+       mov       r11,7FFF7FD90F40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD90F58
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD90F58
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE5F2C0008
+       mov       rax,1AB0EB70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80806DD8]
+       call      qword ptr [7FFF80846988]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L24
+       jne       near ptr M00_L25
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L27
+       je        near ptr M00_L28
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L22
-       test      byte ptr [7FFF807B57A0],1
-       je        near ptr M00_L25
+       jne       near ptr M00_L23
+       test      byte ptr [7FFF8079FB30],1
+       je        near ptr M00_L26
 M00_L01:
-       mov       rcx,1BDCA402C18
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L18
+       jne       near ptr M00_L20
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L19
        mov       [rax+8],ecx
+M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L10
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L22
        mov       rsi,[rcx+r11*8+10]
-M00_L04:
+M00_L05:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L13
-       mov       rcx,1BDCA400068
+       je        near ptr M00_L12
+       mov       rcx,1BDD7C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L17
+       jne       near ptr M00_L18
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,19C7944F
-       mov       r10d,8C9FD17F
+       mov       r8d,0E5D4FDDC
+       mov       r10d,20BB6781
        cmp       edx,8
-       jb        near ptr M00_L09
+       jb        near ptr M00_L13
        mov       r9d,edx
        shr       r9d,3
-M00_L05:
+M00_L06:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L05
+       jne       short M00_L06
        test      dl,4
-       jne       short M00_L10
-M00_L06:
+       jne       near ptr M00_L14
+M00_L07:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L07:
+M00_L08:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L08:
+M00_L09:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L09:
-       cmp       edx,4
-       jb        short M00_L14
 M00_L10:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF807A5590]
+       int       3
+M00_L11:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        near ptr M00_L04
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D50
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L05
+M00_L12:
+       xor       r8d,r8d
+       jmp       short M00_L09
+M00_L13:
+       cmp       edx,4
+       jae       short M00_L14
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L16
+       jmp       short M00_L15
+M00_L14:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L06
-M00_L11:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       jmp       near ptr M00_L21
-M00_L12:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F58
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L04
-M00_L13:
-       xor       r8d,r8d
-       jmp       short M00_L08
-M00_L14:
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L15
+       jmp       near ptr M00_L07
+M00_L15:
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L15:
+M00_L16:
        test      dl,2
-       je        short M00_L16
+       je        short M00_L17
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L07
-M00_L16:
-       mov       ecx,r9d
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L08
 M00_L17:
+       mov       ecx,r9d
+       jmp       near ptr M00_L08
+M00_L18:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L08
-M00_L18:
-       mov       rcx,rax
-       mov       r11,7FFF7FD60F50
-       call      qword ptr [r11]
-       test      eax,eax
-       jne       near ptr M00_L12
-       jmp       near ptr M00_L29
+       jmp       near ptr M00_L09
 M00_L19:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF80807E88]
-       int       3
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       xor       esi,esi
+       jmp       short M00_L21
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D48
+       call      qword ptr [r11]
+       mov       esi,eax
 M00_L21:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       test      esi,esi
+       jne       near ptr M00_L11
+       jmp       near ptr M00_L30
 M00_L22:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L23:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L23:
-       call      qword ptr [7FFF804EE610]
+M00_L24:
+       call      qword ptr [7FFF80526A30]
        mov       ecx,5B
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80215D90
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80255D90
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80744378]
+       call      qword ptr [7FFF8065C870]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80744390]
+       call      qword ptr [7FFF8065C888]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L24:
-       mov       r11,7FFF7FD60F68
+M00_L25:
+       mov       r11,7FFF7FDA0D60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L27
+       je        short M00_L28
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F70
+       mov       r11,7FFF7FDA0D68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L27:
+M00_L28:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDCA402C18
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L28:
+M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F48
+       mov       r11,7FFF7FDA0D40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L29:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F60
+M00_L30:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
+M00_L31:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,rax
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-M00_L30:
+M00_L32:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1160
+; Total bytes of code 1204
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE5F2C0008
+       mov       rax,1FE6CCE0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80806DD8]
+       call      qword ptr [7FFF807AFD50]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807B57A0],1
+       test      byte ptr [7FFF807C9E70],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDCA402C18
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,1BDCA400068
+       mov       rcx,278FC800068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,19C7944F
-       mov       r10d,8C9FD17F
+       mov       r8d,0EF90DC4
+       mov       r10d,0E0430C69
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F58
+       mov       r11,7FFF7FD71110
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD60F50
+       mov       r11,7FFF7FD71108
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80807E88]
+       call      qword ptr [7FFF8075EB50]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804EE610]
+       call      qword ptr [7FFF804FE610]
        mov       ecx,5B
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80215D90
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80744378]
+       call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80744390]
+       call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD60F68
+       mov       r11,7FFF7FD71120
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F70
+       mov       r11,7FFF7FD71128
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDCA402C18
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F48
+       mov       r11,7FFF7FD71100
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE5F2C0008
+       mov       rax,2B991A70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80806DD8]
+       call      qword ptr [7FFF80816F28]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807B57A0],1
+       test      byte ptr [7FFF8080C220],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDCA402C18
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,1BDCA400068
+       mov       rcx,147C4000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,19C7944F
-       mov       r10d,8C9FD17F
+       mov       r8d,71E91FB3
+       mov       r10d,9BC5B61C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F58
+       mov       r11,7FFF7FD813C8
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD60F50
+       mov       r11,7FFF7FD813C0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80807E88]
+       call      qword ptr [7FFF8074F6C0]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804EE610]
+       call      qword ptr [7FFF8050E628]
        mov       ecx,5B
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80215D90
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80235D90
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80744378]
+       call      qword ptr [7FFF80745E78]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80744390]
+       call      qword ptr [7FFF80745E90]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD60F68
+       mov       r11,7FFF7FD813D8
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F70
+       mov       r11,7FFF7FD813E0
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDCA402C18
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F48
+       mov       r11,7FFF7FD813B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE5F2C0008
+       mov       rax,18859390008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80806DD8]
+       call      qword ptr [7FFF808275E8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807B57A0],1
+       test      byte ptr [7FFF8092B1F8],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDCA402C18
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,1BDCA400068
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,19C7944F
-       mov       r10d,8C9FD17F
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F58
+       mov       r11,7FFF7FD717A0
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD60F50
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80807E88]
+       call      qword ptr [7FFF808C75E8]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804EE610]
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80215D90
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80342378
-       call      qword ptr [7FFF80097738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80744378]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80744390]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD60F68
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F70
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDCA402C18
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD60F48
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD60F60
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rsi+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rbx+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,1FE5F2C0008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF80806DD8]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C9E70],1
+       test      byte ptr [7FFF807D1920],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,2396E000C20
+       mov       rcx,16A79C02C18
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,23958000068
+       mov       rcx,16A79C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,86B5BF34
-       mov       r10d,311E6579
+       mov       r8d,2F2A3545
+       mov       r10d,534958C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F50
+       mov       r11,7FFF7FD90F50
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD70F48
+       mov       r11,7FFF7FD90F48
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E58]
+       call      qword ptr [7FFF80847A38]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE610]
+       call      qword ptr [7FFF8051E058]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80372378
+       call      qword ptr [7FFF800C7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80245D90
+       call      qword ptr [7FFF800C7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80372378
+       call      qword ptr [7FFF800C7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80754378]
+       call      qword ptr [7FFF8066FF60]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80754390]
+       call      qword ptr [7FFF8066FF78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD70F60
+       mov       r11,7FFF7FD90F60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F68
+       mov       r11,7FFF7FD90F68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2396E000C20
+       mov       rcx,16A79C02C18
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F40
+       mov       r11,7FFF7FD90F40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD90F58
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD90F58
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,279ECEE0008
+       mov       rax,1AB0EB70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DA8]
+       call      qword ptr [7FFF80846988]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L24
+       jne       near ptr M00_L25
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L27
+       je        near ptr M00_L28
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L22
-       test      byte ptr [7FFF807C9E70],1
-       je        near ptr M00_L25
+       jne       near ptr M00_L23
+       test      byte ptr [7FFF8079FB30],1
+       je        near ptr M00_L26
 M00_L01:
-       mov       rcx,2396E000C20
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L18
+       jne       near ptr M00_L20
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L19
        mov       [rax+8],ecx
+M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L10
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L22
        mov       rsi,[rcx+r11*8+10]
-M00_L04:
+M00_L05:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L13
-       mov       rcx,23958000068
+       je        near ptr M00_L12
+       mov       rcx,1BDD7C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L17
+       jne       near ptr M00_L18
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,86B5BF34
-       mov       r10d,311E6579
+       mov       r8d,0E5D4FDDC
+       mov       r10d,20BB6781
        cmp       edx,8
-       jb        near ptr M00_L09
+       jb        near ptr M00_L13
        mov       r9d,edx
        shr       r9d,3
-M00_L05:
+M00_L06:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L05
+       jne       short M00_L06
        test      dl,4
-       jne       short M00_L10
-M00_L06:
+       jne       near ptr M00_L14
+M00_L07:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L07:
+M00_L08:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L08:
+M00_L09:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L09:
-       cmp       edx,4
-       jb        short M00_L14
 M00_L10:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF807A5590]
+       int       3
+M00_L11:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        near ptr M00_L04
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D50
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L05
+M00_L12:
+       xor       r8d,r8d
+       jmp       short M00_L09
+M00_L13:
+       cmp       edx,4
+       jae       short M00_L14
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L16
+       jmp       short M00_L15
+M00_L14:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L06
-M00_L11:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       jmp       near ptr M00_L21
-M00_L12:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F50
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L04
-M00_L13:
-       xor       r8d,r8d
-       jmp       short M00_L08
-M00_L14:
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L15
+       jmp       near ptr M00_L07
+M00_L15:
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L15:
+M00_L16:
        test      dl,2
-       je        short M00_L16
+       je        short M00_L17
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L07
-M00_L16:
-       mov       ecx,r9d
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L08
 M00_L17:
+       mov       ecx,r9d
+       jmp       near ptr M00_L08
+M00_L18:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L08
-M00_L18:
-       mov       rcx,rax
-       mov       r11,7FFF7FD70F48
-       call      qword ptr [r11]
-       test      eax,eax
-       jne       near ptr M00_L12
-       jmp       near ptr M00_L29
+       jmp       near ptr M00_L09
 M00_L19:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E58]
-       int       3
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       xor       esi,esi
+       jmp       short M00_L21
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D48
+       call      qword ptr [r11]
+       mov       esi,eax
 M00_L21:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       test      esi,esi
+       jne       near ptr M00_L11
+       jmp       near ptr M00_L30
 M00_L22:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L23:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L23:
-       call      qword ptr [7FFF804FE610]
+M00_L24:
+       call      qword ptr [7FFF80526A30]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80255D90
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80754378]
+       call      qword ptr [7FFF8065C870]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80754390]
+       call      qword ptr [7FFF8065C888]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L24:
-       mov       r11,7FFF7FD70F60
+M00_L25:
+       mov       r11,7FFF7FDA0D60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L27
+       je        short M00_L28
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F68
+       mov       r11,7FFF7FDA0D68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L27:
+M00_L28:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2396E000C20
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L28:
+M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F40
+       mov       r11,7FFF7FDA0D40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L29:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F58
+M00_L30:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
+M00_L31:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,rax
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-M00_L30:
+M00_L32:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1160
+; Total bytes of code 1204
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,279ECEE0008
+       mov       rax,1FE6CCE0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DA8]
+       call      qword ptr [7FFF807AFD50]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
        test      byte ptr [7FFF807C9E70],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,2396E000C20
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,23958000068
+       mov       rcx,278FC800068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,86B5BF34
-       mov       r10d,311E6579
+       mov       r8d,0EF90DC4
+       mov       r10d,0E0430C69
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F50
+       mov       r11,7FFF7FD71110
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD70F48
+       mov       r11,7FFF7FD71108
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E58]
+       call      qword ptr [7FFF8075EB50]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        call      qword ptr [7FFF804FE610]
        mov       ecx,5B
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
        mov       rdx,7FFF80225D90
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD70F60
+       mov       r11,7FFF7FD71120
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F68
+       mov       r11,7FFF7FD71128
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2396E000C20
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F40
+       mov       r11,7FFF7FD71100
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
 M00_L30:
        nop
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,279ECEE0008
+       mov       rax,2B991A70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DA8]
+       call      qword ptr [7FFF80816F28]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C9E70],1
+       test      byte ptr [7FFF8080C220],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,2396E000C20
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,23958000068
+       mov       rcx,147C4000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,86B5BF34
-       mov       r10d,311E6579
+       mov       r8d,71E91FB3
+       mov       r10d,9BC5B61C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F50
+       mov       r11,7FFF7FD813C8
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD70F48
+       mov       r11,7FFF7FD813C0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E58]
+       call      qword ptr [7FFF8074F6C0]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE610]
+       call      qword ptr [7FFF8050E628]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80235D90
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80754378]
+       call      qword ptr [7FFF80745E78]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80754390]
+       call      qword ptr [7FFF80745E90]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD70F60
+       mov       r11,7FFF7FD813D8
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F68
+       mov       r11,7FFF7FD813E0
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2396E000C20
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F40
+       mov       r11,7FFF7FD813B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,279ECEE0008
+       mov       rax,18859390008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816DA8]
+       call      qword ptr [7FFF808275E8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C9E70],1
+       test      byte ptr [7FFF8092B1F8],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,2396E000C20
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,23958000068
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,86B5BF34
-       mov       r10d,311E6579
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F50
+       mov       r11,7FFF7FD717A0
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD70F48
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80817E58]
+       call      qword ptr [7FFF808C75E8]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE610]
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
        mov       rdx,7FFF80225D90
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80754378]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80754390]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD70F60
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F68
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2396E000C20
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD70F40
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD70F58
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
+       lea       rdx,[rsi+0C]
        call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
+       lea       rdx,[rbx+0C]
        call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,279ECEE0008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF80816DA8]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L23
+       je        near ptr M00_L24
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L28
+       jne       near ptr M00_L29
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L24
+       jne       near ptr M00_L25
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L27
+       je        near ptr M00_L28
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L26
+       jne       near ptr M00_L27
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L22
-       test      byte ptr [7FFF807D1920],1
-       je        near ptr M00_L25
+       jne       near ptr M00_L23
+       test      byte ptr [7FFF8079FB30],1
+       je        near ptr M00_L26
 M00_L01:
-       mov       rcx,16A79C02C18
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L18
+       jne       near ptr M00_L20
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L11
+       jae       near ptr M00_L19
        mov       [rax+8],ecx
+M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L10
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L20
+       jae       near ptr M00_L22
        mov       rsi,[rcx+r11*8+10]
-M00_L04:
+M00_L05:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L13
-       mov       rcx,16A79C00068
+       je        near ptr M00_L12
+       mov       rcx,1BDD7C00068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L17
+       jne       near ptr M00_L18
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,2F2A3545
-       mov       r10d,534958C
+       mov       r8d,0E5D4FDDC
+       mov       r10d,20BB6781
        cmp       edx,8
-       jb        near ptr M00_L09
+       jb        near ptr M00_L13
        mov       r9d,edx
        shr       r9d,3
-M00_L05:
+M00_L06:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L05
+       jne       short M00_L06
        test      dl,4
-       jne       short M00_L10
-M00_L06:
+       jne       near ptr M00_L14
+M00_L07:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L07:
+M00_L08:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L08:
+M00_L09:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L09:
-       cmp       edx,4
-       jb        short M00_L14
 M00_L10:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF807A5590]
+       int       3
+M00_L11:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        near ptr M00_L04
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D50
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L05
+M00_L12:
+       xor       r8d,r8d
+       jmp       short M00_L09
+M00_L13:
+       cmp       edx,4
+       jae       short M00_L14
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L16
+       jmp       short M00_L15
+M00_L14:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L06
-M00_L11:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       jmp       near ptr M00_L21
-M00_L12:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F50
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L04
-M00_L13:
-       xor       r8d,r8d
-       jmp       short M00_L08
-M00_L14:
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L15
+       jmp       near ptr M00_L07
+M00_L15:
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L15:
+M00_L16:
        test      dl,2
-       je        short M00_L16
+       je        short M00_L17
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L07
-M00_L16:
-       mov       ecx,r9d
-       jmp       near ptr M00_L07
+       jmp       near ptr M00_L08
 M00_L17:
+       mov       ecx,r9d
+       jmp       near ptr M00_L08
+M00_L18:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L08
-M00_L18:
-       mov       rcx,rax
-       mov       r11,7FFF7FD90F48
-       call      qword ptr [r11]
-       test      eax,eax
-       jne       near ptr M00_L12
-       jmp       near ptr M00_L29
+       jmp       near ptr M00_L09
 M00_L19:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF80847A38]
-       int       3
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       xor       esi,esi
+       jmp       short M00_L21
 M00_L20:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D48
+       call      qword ptr [r11]
+       mov       esi,eax
 M00_L21:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       test      esi,esi
+       jne       near ptr M00_L11
+       jmp       near ptr M00_L30
 M00_L22:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L23:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L23:
-       call      qword ptr [7FFF8051E058]
+M00_L24:
+       call      qword ptr [7FFF80526A30]
        mov       ecx,5B
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80245D90
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80255D90
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80382378
+       call      qword ptr [7FFF800D7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8066FF60]
+       call      qword ptr [7FFF8065C870]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8066FF78]
+       call      qword ptr [7FFF8065C888]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L24:
-       mov       r11,7FFF7FD90F60
+M00_L25:
+       mov       r11,7FFF7FDA0D60
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L27
+       je        short M00_L28
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L26:
+M00_L27:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F68
+       mov       r11,7FFF7FDA0D68
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L27:
+M00_L28:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16A79C02C18
+       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1BDD7C02008
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L28:
+M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F40
+       mov       r11,7FFF7FDA0D40
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L29:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F58
+M00_L30:
+       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       mov       rax,[rbp-30]
+       cmp       [rax],rcx
+       je        short M00_L31
+       mov       rcx,rax
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-       jmp       near ptr M00_L21
+M00_L31:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L30
+       je        short M00_L32
        mov       rcx,rax
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FDA0D58
        call      qword ptr [r11]
-M00_L30:
+M00_L32:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1160
+; Total bytes of code 1204
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1AB0EB70008
+       mov       rax,1FE6CCE0008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80846988]
+       call      qword ptr [7FFF807AFD50]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807D1920],1
+       test      byte ptr [7FFF807C9E70],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,16A79C02C18
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,16A79C00068
+       mov       rcx,278FC800068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,2F2A3545
-       mov       r10d,534958C
+       mov       r8d,0EF90DC4
+       mov       r10d,0E0430C69
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F50
+       mov       r11,7FFF7FD71110
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD90F48
+       mov       r11,7FFF7FD71108
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80847A38]
+       call      qword ptr [7FFF8075EB50]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF8051E058]
+       call      qword ptr [7FFF804FE610]
        mov       ecx,5B
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80245D90
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8066FF60]
+       call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8066FF78]
+       call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD90F60
+       mov       r11,7FFF7FD71120
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F68
+       mov       r11,7FFF7FD71128
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16A79C02C18
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F40
+       mov       r11,7FFF7FD71100
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1AB0EB70008
+       mov       rax,2B991A70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80846988]
+       call      qword ptr [7FFF80816F28]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807D1920],1
+       test      byte ptr [7FFF8080C220],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,16A79C02C18
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,16A79C00068
+       mov       rcx,147C4000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,2F2A3545
-       mov       r10d,534958C
+       mov       r8d,71E91FB3
+       mov       r10d,9BC5B61C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F50
+       mov       r11,7FFF7FD813C8
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD90F48
+       mov       r11,7FFF7FD813C0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80847A38]
+       call      qword ptr [7FFF8074F6C0]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF8051E058]
+       call      qword ptr [7FFF8050E628]
        mov       ecx,5B
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80245D90
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80235D90
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8066FF60]
+       call      qword ptr [7FFF80745E78]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8066FF78]
+       call      qword ptr [7FFF80745E90]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD90F60
+       mov       r11,7FFF7FD813D8
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F68
+       mov       r11,7FFF7FD813E0
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16A79C02C18
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F40
+       mov       r11,7FFF7FD813B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1AB0EB70008
+       mov       rax,18859390008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80846988]
+       call      qword ptr [7FFF808275E8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807D1920],1
+       test      byte ptr [7FFF8092B1F8],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,16A79C02C18
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,16A79C00068
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,2F2A3545
-       mov       r10d,534958C
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F50
+       mov       r11,7FFF7FD717A0
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD90F48
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF80847A38]
+       call      qword ptr [7FFF808C75E8]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF8051E058]
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80245D90
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80372378
-       call      qword ptr [7FFF800C7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE47858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8066FF60]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8066FF78]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD90F60
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F68
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16A79C02C18
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD90F40
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD90F58
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rsi+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rbx+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,1AB0EB70008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF80846988]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L24
+       je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L25
+       jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L28
+       je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L23
-       test      byte ptr [7FFF8079FB30],1
-       je        near ptr M00_L26
+       jne       near ptr M00_L22
+       test      byte ptr [7FFF807C9E70],1
+       je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDD7C02008
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L20
+       jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L11
        mov       [rax+8],ecx
-M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L10
+       jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L22
+       jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
-M00_L05:
+M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L12
-       mov       rcx,1BDD7C00068
+       je        near ptr M00_L13
+       mov       rcx,278FC800068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L18
+       jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,0E5D4FDDC
-       mov       r10d,20BB6781
+       mov       r8d,0EF90DC4
+       mov       r10d,0E0430C69
        cmp       edx,8
-       jb        near ptr M00_L13
+       jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
-M00_L06:
+M00_L05:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L06
+       jne       short M00_L05
        test      dl,4
-       jne       near ptr M00_L14
-M00_L07:
+       jne       short M00_L10
+M00_L06:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L08:
+M00_L07:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L09:
+M00_L08:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L10:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF807A5590]
-       int       3
-M00_L11:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       mov       rax,[rbp-30]
-       cmp       [rax],rcx
-       je        near ptr M00_L04
-       mov       rcx,rax
-       mov       r11,7FFF7FDA0D50
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L05
-M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L09
-M00_L13:
+M00_L09:
        cmp       edx,4
-       jae       short M00_L14
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L16
-       jmp       short M00_L15
-M00_L14:
+       jb        short M00_L14
+M00_L10:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L07
-M00_L15:
+       jmp       near ptr M00_L06
+M00_L11:
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       jmp       near ptr M00_L21
+M00_L12:
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF7FD71110
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L04
+M00_L13:
+       xor       r8d,r8d
+       jmp       short M00_L08
+M00_L14:
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L15
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L16:
+M00_L15:
        test      dl,2
-       je        short M00_L17
+       je        short M00_L16
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L08
-M00_L17:
+       jmp       near ptr M00_L07
+M00_L16:
        mov       ecx,r9d
-       jmp       near ptr M00_L08
-M00_L18:
+       jmp       near ptr M00_L07
+M00_L17:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L09
-M00_L19:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       xor       esi,esi
-       jmp       short M00_L21
-M00_L20:
+       jmp       near ptr M00_L08
+M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FDA0D48
+       mov       r11,7FFF7FD71108
        call      qword ptr [r11]
-       mov       esi,eax
-M00_L21:
-       test      esi,esi
-       jne       near ptr M00_L11
-       jmp       near ptr M00_L30
-M00_L22:
+       test      eax,eax
+       jne       near ptr M00_L12
+       jmp       near ptr M00_L29
+M00_L19:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF8075EB50]
+       int       3
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L23:
+M00_L21:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L22:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L24:
-       call      qword ptr [7FFF80526A30]
+M00_L23:
+       call      qword ptr [7FFF804FE610]
        mov       ecx,5B
-       mov       rdx,7FFF80382378
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80255D90
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80382378
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8065C870]
+       call      qword ptr [7FFF80754378]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8065C888]
+       call      qword ptr [7FFF80754390]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L25:
-       mov       r11,7FFF7FDA0D60
+M00_L24:
+       mov       r11,7FFF7FD71120
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L28
+       je        short M00_L27
        jmp       near ptr M00_L00
-M00_L26:
+M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FDA0D68
+       mov       r11,7FFF7FD71128
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L28:
+M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDD7C02008
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,27912800AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L29:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FDA0D40
+       mov       r11,7FFF7FD71100
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L30:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       mov       rax,[rbp-30]
-       cmp       [rax],rcx
-       je        short M00_L31
-       mov       rcx,rax
-       mov       r11,7FFF7FDA0D58
+M00_L29:
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
-M00_L31:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L32
+       je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L32
+       je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FDA0D58
+       mov       r11,7FFF7FD71118
        call      qword ptr [r11]
-M00_L32:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1204
+; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE6CCE0008
+       mov       rax,2B991A70008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF807AFD50]
+       call      qword ptr [7FFF80816F28]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L24
+       je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L25
+       jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L28
+       je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L23
-       test      byte ptr [7FFF8079FB30],1
-       je        near ptr M00_L26
+       jne       near ptr M00_L22
+       test      byte ptr [7FFF8080C220],1
+       je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDD7C02008
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L20
+       jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L11
        mov       [rax+8],ecx
-M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L10
+       jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L22
+       jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
-M00_L05:
+M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L12
-       mov       rcx,1BDD7C00068
+       je        near ptr M00_L13
+       mov       rcx,147C4000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L18
+       jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,0E5D4FDDC
-       mov       r10d,20BB6781
+       mov       r8d,71E91FB3
+       mov       r10d,9BC5B61C
        cmp       edx,8
-       jb        near ptr M00_L13
+       jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
-M00_L06:
+M00_L05:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L06
+       jne       short M00_L05
        test      dl,4
-       jne       near ptr M00_L14
-M00_L07:
+       jne       short M00_L10
+M00_L06:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L08:
+M00_L07:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L09:
+M00_L08:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L10:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF807A5590]
-       int       3
-M00_L11:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       mov       rax,[rbp-30]
-       cmp       [rax],rcx
-       je        near ptr M00_L04
-       mov       rcx,rax
-       mov       r11,7FFF7FDA0D50
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L05
-M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L09
-M00_L13:
+M00_L09:
        cmp       edx,4
-       jae       short M00_L14
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L16
-       jmp       short M00_L15
-M00_L14:
+       jb        short M00_L14
+M00_L10:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L07
-M00_L15:
+       jmp       near ptr M00_L06
+M00_L11:
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       jmp       near ptr M00_L21
+M00_L12:
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF7FD813C8
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L04
+M00_L13:
+       xor       r8d,r8d
+       jmp       short M00_L08
+M00_L14:
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L15
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L16:
+M00_L15:
        test      dl,2
-       je        short M00_L17
+       je        short M00_L16
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L08
-M00_L17:
+       jmp       near ptr M00_L07
+M00_L16:
        mov       ecx,r9d
-       jmp       near ptr M00_L08
-M00_L18:
+       jmp       near ptr M00_L07
+M00_L17:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L09
-M00_L19:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       xor       esi,esi
-       jmp       short M00_L21
-M00_L20:
+       jmp       near ptr M00_L08
+M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FDA0D48
+       mov       r11,7FFF7FD813C0
        call      qword ptr [r11]
-       mov       esi,eax
-M00_L21:
-       test      esi,esi
-       jne       near ptr M00_L11
-       jmp       near ptr M00_L30
-M00_L22:
+       test      eax,eax
+       jne       near ptr M00_L12
+       jmp       near ptr M00_L29
+M00_L19:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF8074F6C0]
+       int       3
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L23:
+M00_L21:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L22:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L24:
-       call      qword ptr [7FFF80526A30]
+M00_L23:
+       call      qword ptr [7FFF8050E628]
        mov       ecx,5B
-       mov       rdx,7FFF80382378
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80255D90
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80235D90
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80382378
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8065C870]
+       call      qword ptr [7FFF80745E78]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8065C888]
+       call      qword ptr [7FFF80745E90]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L25:
-       mov       r11,7FFF7FDA0D60
+M00_L24:
+       mov       r11,7FFF7FD813D8
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L28
+       je        short M00_L27
        jmp       near ptr M00_L00
-M00_L26:
+M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FDA0D68
+       mov       r11,7FFF7FD813E0
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L28:
+M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDD7C02008
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L29:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FDA0D40
+       mov       r11,7FFF7FD813B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L30:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       mov       rax,[rbp-30]
-       cmp       [rax],rcx
-       je        short M00_L31
-       mov       rcx,rax
-       mov       r11,7FFF7FDA0D58
+M00_L29:
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
-M00_L31:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L32
+       je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L32
+       je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FDA0D58
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
-M00_L32:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1204
+; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,1FE6CCE0008
+       mov       rax,18859390008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF807AFD50]
+       call      qword ptr [7FFF808275E8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
-       je        near ptr M00_L24
+       je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
-       jne       near ptr M00_L29
+       jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
-       jne       near ptr M00_L25
+       jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
-       je        near ptr M00_L28
+       je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
-       jne       near ptr M00_L27
+       jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
-       jne       near ptr M00_L23
-       test      byte ptr [7FFF8079FB30],1
-       je        near ptr M00_L26
+       jne       near ptr M00_L22
+       test      byte ptr [7FFF8092B1F8],1
+       je        near ptr M00_L25
 M00_L01:
-       mov       rcx,1BDD7C02008
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
 M00_L03:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       jne       near ptr M00_L20
+       jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L19
+       jae       near ptr M00_L11
        mov       [rax+8],ecx
-M00_L04:
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
-       jae       near ptr M00_L10
+       jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
-       jae       near ptr M00_L22
+       jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
-M00_L05:
+M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
-       je        near ptr M00_L12
-       mov       rcx,1BDD7C00068
+       je        near ptr M00_L13
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
-       jne       near ptr M00_L18
+       jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,0E5D4FDDC
-       mov       r10d,20BB6781
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
-       jb        near ptr M00_L13
+       jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
-M00_L06:
+M00_L05:
        add       r8d,[rcx]
        mov       r11d,[rcx+4]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
        add       r11d,r8d
        mov       r8d,r10d
        xor       r8d,r11d
        rol       r11d,14
        add       r11d,r8d
        rol       r8d,9
        xor       r8d,r11d
        rol       r11d,1B
        add       r11d,r8d
        rol       r8d,13
        mov       r10d,r11d
        add       rcx,8
        dec       r9d
        mov       eax,r8d
        mov       r8d,r10d
        mov       r10d,eax
-       jne       short M00_L06
+       jne       short M00_L05
        test      dl,4
-       jne       near ptr M00_L14
-M00_L07:
+       jne       short M00_L10
+M00_L06:
        mov       r9d,edx
        and       r9,7
        mov       ecx,[rcx+r9-4]
        shr       ecx,8
        or        ecx,80000000
        not       edx
        shl       edx,3
        shrx      ecx,ecx,edx
-M00_L08:
+M00_L07:
        add       ecx,r8d
        mov       edx,r10d
        xor       edx,ecx
        rol       ecx,14
        add       ecx,edx
        rol       edx,9
        xor       edx,ecx
        rol       ecx,1B
        add       ecx,edx
        rol       edx,13
        xor       edx,ecx
        mov       r8d,ecx
        rol       r8d,14
        add       r8d,edx
        rol       edx,9
        xor       edx,r8d
        rol       r8d,1B
        add       r8d,edx
        mov       r10d,edx
        rol       r10d,13
        xor       r8d,r10d
-M00_L09:
+M00_L08:
        mov       ecx,edi
        shl       ecx,5
        xor       ecx,edi
        mov       edi,ecx
        xor       edi,r8d
        jmp       near ptr M00_L03
-M00_L10:
-       mov       ecx,[rax+8]
-       call      qword ptr [7FFF807A5590]
-       int       3
-M00_L11:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       mov       rax,[rbp-30]
-       cmp       [rax],rcx
-       je        near ptr M00_L04
-       mov       rcx,rax
-       mov       r11,7FFF7FDA0D50
-       call      qword ptr [r11]
-       mov       rsi,rax
-       mov       rax,[rbp-30]
-       jmp       near ptr M00_L05
-M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L09
-M00_L13:
+M00_L09:
        cmp       edx,4
-       jae       short M00_L14
-       mov       r9d,80
-       test      dl,1
-       je        short M00_L16
-       jmp       short M00_L15
-M00_L14:
+       jb        short M00_L14
+M00_L10:
        add       r8d,[rcx]
        xor       r10d,r8d
        rol       r8d,14
        add       r8d,r10d
        rol       r10d,9
        xor       r10d,r8d
        rol       r8d,1B
        add       r8d,r10d
        rol       r10d,13
-       jmp       near ptr M00_L07
-M00_L15:
+       jmp       near ptr M00_L06
+M00_L11:
+       mov       ecx,[rax+0C]
+       mov       [rax+8],ecx
+       jmp       near ptr M00_L21
+M00_L12:
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF7FD717A0
+       call      qword ptr [r11]
+       mov       rsi,rax
+       mov       rax,[rbp-30]
+       jmp       near ptr M00_L04
+M00_L13:
+       xor       r8d,r8d
+       jmp       short M00_L08
+M00_L14:
+       mov       r9d,80
+       test      dl,1
+       je        short M00_L15
        mov       r9d,edx
        and       r9,2
        movzx     r9d,byte ptr [rcx+r9]
        or        r9d,8000
-M00_L16:
+M00_L15:
        test      dl,2
-       je        short M00_L17
+       je        short M00_L16
        shl       r9d,10
        movzx     ecx,word ptr [rcx]
        or        r9d,ecx
        mov       ecx,r9d
-       jmp       near ptr M00_L08
-M00_L17:
+       jmp       near ptr M00_L07
+M00_L16:
        mov       ecx,r9d
-       jmp       near ptr M00_L08
-M00_L18:
+       jmp       near ptr M00_L07
+M00_L17:
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
-       jmp       near ptr M00_L09
-M00_L19:
-       mov       ecx,[rax+0C]
-       mov       [rax+8],ecx
-       xor       esi,esi
-       jmp       short M00_L21
-M00_L20:
+       jmp       near ptr M00_L08
+M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FDA0D48
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
-       mov       esi,eax
-M00_L21:
-       test      esi,esi
-       jne       near ptr M00_L11
-       jmp       near ptr M00_L30
-M00_L22:
+       test      eax,eax
+       jne       near ptr M00_L12
+       jmp       near ptr M00_L29
+M00_L19:
+       mov       ecx,[rax+8]
+       call      qword ptr [7FFF808C75E8]
+       int       3
+M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M00_L23:
+M00_L21:
+       mov       rax,[rbx+18]
+       mov       [rax+38],edi
+       add       rsp,28
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M00_L22:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
-M00_L24:
-       call      qword ptr [7FFF80526A30]
+M00_L23:
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
-       mov       rdx,7FFF80382378
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80255D90
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80382378
-       call      qword ptr [7FFF800D7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE57858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF8065C870]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF8065C888]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M00_L25:
-       mov       r11,7FFF7FDA0D60
+M00_L24:
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
-       je        short M00_L28
+       je        short M00_L27
        jmp       near ptr M00_L00
-M00_L26:
+M00_L25:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
-M00_L27:
+M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FDA0D68
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L28:
+M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFF7FE55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1BDD7C02008
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
-M00_L29:
+M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FDA0D40
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
-M00_L30:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       mov       rax,[rbp-30]
-       cmp       [rax],rcx
-       je        short M00_L31
-       mov       rcx,rax
-       mov       r11,7FFF7FDA0D58
+M00_L29:
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
-M00_L31:
-       mov       rax,[rbx+18]
-       mov       [rax+38],edi
-       add       rsp,28
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
+       jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
-       je        short M00_L32
+       je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
-       je        short M00_L32
+       je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FDA0D58
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
-M00_L32:
+M00_L30:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1204
+; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rsi+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rbx+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,1FE6CCE0008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF807AFD50]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C9E70],1
+       test      byte ptr [7FFF8080C220],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,27912800AC8
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,278FC800068
+       mov       rcx,147C4000068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,0EF90DC4
-       mov       r10d,0E0430C69
+       mov       r8d,71E91FB3
+       mov       r10d,9BC5B61C
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD71110
+       mov       r11,7FFF7FD813C8
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD71108
+       mov       r11,7FFF7FD813C0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF8075EB50]
+       call      qword ptr [7FFF8074F6C0]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE610]
+       call      qword ptr [7FFF8050E628]
        mov       ecx,5B
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80225D90
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80235D90
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80352378
-       call      qword ptr [7FFF800A7738]
+       mov       rdx,7FFF80362378
+       call      qword ptr [7FFF800B7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80754378]
+       call      qword ptr [7FFF80745E78]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80754390]
+       call      qword ptr [7FFF80745E90]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD71120
+       mov       r11,7FFF7FD813D8
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD71128
+       mov       r11,7FFF7FD813E0
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,27912800AC8
+       mov       rcx,147DA000AC8
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD71100
+       mov       r11,7FFF7FD813B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD71118
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD71118
+       mov       r11,7FFF7FD813D0
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
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
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
        lea       r13,[r15+0C]
        mov       rcx,r13
        mov       r8d,edi
        add       r8,r8
        lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
        lea       rcx,[r13+rcx*2]
        mov       r8d,ebp
        add       r8,r8
        lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
        test      rsi,rsi
        je        short M01_L02
        mov       ebp,[rsi+8]
        test      ebp,ebp
        sete      al
        movzx     eax,al
        test      eax,eax
        je        short M01_L03
 M01_L02:
-       mov       rax,2B991A70008
+       mov       rax,18859390008
        add       rsp,20
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FFF80816F28]
+       call      qword ptr [7FFF808275E8]
        int       3
 ; Total bytes of code 244
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF807C9E70],1
+       test      byte ptr [7FFF8092B1F8],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,27912800AC8
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,278FC800068
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,0EF90DC4
-       mov       r10d,0E0430C69
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD71110
+       mov       r11,7FFF7FD717A0
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD71108
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF8075EB50]
+       call      qword ptr [7FFF808C75E8]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF804FE610]
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
        mov       rdx,7FFF80225D90
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFF80352378
        call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80754378]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80754390]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD71120
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD71128
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,27912800AC8
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD71100
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD71118
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD71118
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
+       lea       rdx,[rsi+0C]
        call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
+       lea       rdx,[rbx+0C]
        call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,2B991A70008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF80816F28]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
```
**Diff for GenerateHashCode method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+50]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
        test      rsi,rsi
        je        near ptr M00_L23
        mov       edi,1997
        mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rsi],rcx
        jne       near ptr M00_L28
        mov       rcx,[rsi+8]
        mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rcx],r11
        jne       near ptr M00_L24
        mov       r14d,[rcx+8]
        test      r14d,r14d
        je        near ptr M00_L27
 M00_L00:
        mov       rsi,[rsi+8]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       [rsi],rcx
        jne       near ptr M00_L26
        mov       r14d,[rsi+8]
        test      r14d,r14d
        jne       near ptr M00_L22
-       test      byte ptr [7FFF8080C220],1
+       test      byte ptr [7FFF8092B1F8],1
        je        near ptr M00_L25
 M00_L01:
-       mov       rcx,147DA000AC8
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
 M00_L02:
        mov       [rbp-30],rcx
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        jne       near ptr M00_L18
        mov       ecx,[rax+8]
        inc       ecx
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L11
        mov       [rax+8],ecx
        mov       ecx,[rax+8]
        cmp       ecx,[rax+0C]
        jae       near ptr M00_L19
        mov       rcx,[rax+10]
        mov       r11d,[rax+8]
        cmp       r11d,[rcx+8]
        jae       near ptr M00_L20
        mov       rsi,[rcx+r11*8+10]
 M00_L04:
        test      rsi,rsi
        je        short M00_L03
        mov       rdx,[rsi+28]
        test      rdx,rdx
        je        near ptr M00_L13
-       mov       rcx,147C4000068
+       mov       rcx,1AA3D400068
        mov       rcx,[rcx]
        mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [rcx],r8
        jne       near ptr M00_L17
        lea       rcx,[rdx+0C]
        mov       edx,[rdx+8]
        add       edx,edx
-       mov       r8d,71E91FB3
-       mov       r10d,9BC5B61C
+       mov       r8d,2870C7BD
+       mov       r10d,835E2A62
        cmp       edx,8
        jb        near ptr M00_L09
        mov       r9d,edx
        shr       r9d,3
        mov       ecx,[rax+0C]
        mov       [rax+8],ecx
        jmp       near ptr M00_L21
 M00_L12:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD813C8
+       mov       r11,7FFF7FD717A0
        call      qword ptr [r11]
        mov       rsi,rax
        mov       rax,[rbp-30]
        jmp       near ptr M00_L04
        mov       r8,[rcx]
        mov       r8,[r8+48]
        call      qword ptr [r8+18]
        mov       r8d,eax
        jmp       near ptr M00_L08
 M00_L18:
        mov       rcx,rax
-       mov       r11,7FFF7FD813C0
+       mov       r11,7FFF7FD71798
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M00_L12
        jmp       near ptr M00_L29
 M00_L19:
        mov       ecx,[rax+8]
-       call      qword ptr [7FFF8074F6C0]
+       call      qword ptr [7FFF808C75E8]
        int       3
 M00_L20:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       dword ptr [r15+8],0FFFFFFFF
        mov       [r15+0C],r14d
        lea       rcx,[r15+10]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,r15
        jmp       near ptr M00_L02
 M00_L23:
-       call      qword ptr [7FFF8050E628]
+       call      qword ptr [7FFF804FE748]
        mov       ecx,5B
-       mov       rdx,7FFF80362378
-       call      qword ptr [7FFF800B7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rbx,rax
        mov       ecx,1B61
-       mov       rdx,7FFF80235D90
-       call      qword ptr [7FFF800B7738]
+       mov       rdx,7FFF80225D90
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFF80362378
-       call      qword ptr [7FFF800B7738]
+       mov       rdx,7FFF80352378
+       call      qword ptr [7FFF800A7738]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFF7FE37858]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF7FE27858]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFF80745E78]
+       call      qword ptr [7FFF80656688]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFF80745E90]
+       call      qword ptr [7FFF806566A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M00_L24:
-       mov       r11,7FFF7FD813D8
+       mov       r11,7FFF7FD717B0
        call      qword ptr [r11]
        mov       r14d,eax
        test      r14d,r14d
        je        short M00_L27
        jmp       near ptr M00_L00
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        jmp       near ptr M00_L01
 M00_L26:
        mov       rcx,rsi
-       mov       r11,7FFF7FD813E0
+       mov       r11,7FFF7FD717B8
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,147DA000AC8
+       mov       rcx,1AA53400B88
        mov       rcx,[rcx]
        jmp       near ptr M00_L02
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFF7FD813B8
+       mov       r11,7FFF7FD71790
        call      qword ptr [r11]
        mov       rcx,rax
        jmp       near ptr M00_L02
 M00_L29:
        mov       rcx,[rbp-30]
-       mov       r11,7FFF7FD813D0
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
        jmp       near ptr M00_L21
        sub       rsp,28
        cmp       qword ptr [rbp-30],0
        je        short M00_L30
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        mov       rax,[rbp-30]
        cmp       [rax],rcx
        je        short M00_L30
        mov       rcx,rax
-       mov       r11,7FFF7FD813D0
+       mov       r11,7FFF7FD717A8
        call      qword ptr [r11]
 M00_L30:
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1160
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
-       push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
-       mov       rbx,rcx
-       mov       rsi,rdx
-       test      rbx,rbx
-       je        near ptr M01_L01
-       mov       edi,[rbx+8]
-       test      edi,edi
-       je        near ptr M01_L01
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       rbx,rdx
        test      rsi,rsi
+       je        near ptr M01_L00
+       mov       edi,[rsi+8]
+       test      edi,edi
        je        short M01_L00
-       mov       ebp,[rsi+8]
+       test      rbx,rbx
+       je        near ptr M01_L03
+       mov       ebp,[rbx+8]
        test      ebp,ebp
-       je        short M01_L00
+       je        near ptr M01_L03
        mov       r14d,edi
        lea       edx,[r14+rbp]
        test      edx,edx
        jl        near ptr M01_L04
        movsxd    rdx,edx
        mov       rcx,offset MT_System.String
        call      00007FFFDFA68D20
        mov       r15,rax
        cmp       [r15],r15b
-       lea       r13,[r15+0C]
-       mov       rcx,r13
+       lea       rcx,[r15+0C]
        mov       r8d,edi
        add       r8,r8
-       lea       rdx,[rbx+0C]
-       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rsi+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,r14d
-       lea       rcx,[r13+rcx*2]
+       lea       rcx,[r15+rcx*2+0C]
        mov       r8d,ebp
        add       r8,r8
-       lea       rdx,[rsi+0C]
-       call      qword ptr [7FFF7FE35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       lea       rdx,[rbx+0C]
+       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L00:
-       mov       rax,rbx
-       add       rsp,20
+       test      rbx,rbx
+       je        short M01_L01
+       mov       ebp,[rbx+8]
+       test      ebp,ebp
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       je        short M01_L02
+M01_L01:
+       mov       rax,1EAD2450008
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
-M01_L01:
-       test      rsi,rsi
-       je        short M01_L02
-       mov       ebp,[rsi+8]
-       test      ebp,ebp
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M01_L03
 M01_L02:
-       mov       rax,18859390008
-       add       rsp,20
+       mov       rax,rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L03:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r13
        pop       r14
        pop       r15
        ret
 M01_L04:
-       call      qword ptr [7FFF808275E8]
+       call      qword ptr [7FFF8077F498]
        int       3
-; Total bytes of code 244
+; Total bytes of code 235
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFF7FE25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD81090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD81088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD81090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD81088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD81090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD81088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD81378
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD81370
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD90CC8
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD90CC0
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD81378
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD81370
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD81378
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD81370
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD91090
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD91088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD81378
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD81370
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81090
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81088
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD91090
+       mov       r11,7FFF7FD81378
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD91088
+       mov       r11,7FFF7FD81370
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD91090
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD91088
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD91090
+       mov       r11,7FFF7FD81378
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD91088
+       mov       r11,7FFF7FD81370
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD91090
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD91088
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFF7FD81378
+       mov       r11,7FFF7FD81720
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L03:
-       mov       r11,7FFF7FD81370
+       mov       r11,7FFF7FD81718
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
