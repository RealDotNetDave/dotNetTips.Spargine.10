## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1BB75C00AE0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L05
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L31
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       jmp       short M00_L06
M00_L05:
       mov       ecx,783
       mov       rdx,7FFF801EA018
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF8076EF10]
       int       3
M00_L06:
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L18
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L18
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L18
M00_L07:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF80765500]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L33
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L09
       mov       rbx,[rdx+8]
M00_L08:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L07
       mov       edx,[rdi+8]
       cmp       dword ptr [rdi+8],0
       je        short M00_L07
       jmp       near ptr M00_L20
M00_L09:
       xor       ebx,ebx
       jmp       short M00_L08
M00_L10:
       mov       r11,7FFF7FD60D08
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF80765500]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L33
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFF7FD60D10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L16
M00_L13:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L14
       xor       ebx,ebx
       jmp       short M00_L15
M00_L14:
       mov       rbx,[rcx+8]
M00_L15:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L17
M00_L16:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L18
       jmp       short M00_L20
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L19
M00_L18:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L10
       jmp       near ptr M00_L11
M00_L19:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L18
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L34
M00_L21:
       mov       ebx,1
       jmp       short M00_L27
M00_L22:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L24
M00_L23:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L24:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L26
M00_L25:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L25
M00_L26:
       xor       ebx,ebx
M00_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L28:
       mov       ebx,1
       jmp       short M00_L27
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1BB75C00AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BB75C00AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFF800979A8]
       int       3
M00_L31:
       mov       rcx,r13
       call      qword ptr [7FFF8076ED18]
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFF7FD60D00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L33:
       call      M00_L36
       jmp       near ptr M00_L26
M00_L34:
       mov       r11,7FFF7FD60D18
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L35:
       xor       ebx,ebx
       jmp       near ptr M00_L27
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L37
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L37
       mov       rcx,r11
       mov       r11,7FFF7FD60D18
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 987
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF8076EFA0]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8076EF88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802B7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF807654D0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF808158D8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1A596C02AC0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8077D1B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD910D0
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8077D1B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD910D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
       add       r14,10
       jmp       short M00_L23
M00_L22:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L23:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L25
M00_L24:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L26
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L24
M00_L25:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L26:
       mov       ebx,1
       jmp       short M00_L20
M00_L27:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A596C02AB8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A596C02AC0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L28:
       call      qword ptr [7FFF800C79A8]
       int       3
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF808347C8]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF8083E550]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD910C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L25
M00_L33:
       mov       r11,7FFF7FD910E0
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD910E0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 983
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF8083E640]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8083E628]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D188]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF80835410]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1531C800AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8074D050]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD610D0
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8074D050]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD610D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
       add       r14,10
       jmp       short M00_L23
M00_L22:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L23:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L25
M00_L24:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L26
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L24
M00_L25:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L26:
       mov       ebx,1
       jmp       short M00_L20
M00_L27:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1531C800AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1531C800AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L28:
       call      qword ptr [7FFF800979A8]
       int       3
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF801EA018
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF80804720]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF8080E4A8]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD610C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L25
M00_L33:
       mov       r11,7FFF7FD610E0
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD610E0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 983
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF8080E598]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8080E580]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802B7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074D020]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF80805368]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1DB3B400AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8074CFA8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD610D0
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8074CFA8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD610D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
       add       r14,10
       jmp       short M00_L23
M00_L22:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L23:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L25
M00_L24:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L26
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L24
M00_L25:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L26:
       mov       ebx,1
       jmp       short M00_L20
M00_L27:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DB3B400AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DB3B400AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L28:
       call      qword ptr [7FFF800979A8]
       int       3
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF801EA018
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF80804750]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF8080E4D8]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD610C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L25
M00_L33:
       mov       r11,7FFF7FD610E0
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD610E0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 983
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF8080E5C8]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8080E5B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802B7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074CF78]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF80805398]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,15B7C400AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8075D080]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD710D0
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8075D080]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD710D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
       add       r14,10
       jmp       short M00_L23
M00_L22:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L23:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L25
M00_L24:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L26
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L24
M00_L25:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L26:
       mov       ebx,1
       jmp       short M00_L20
M00_L27:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,15B7C400AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15B7C400AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L28:
       call      qword ptr [7FFF800A79A8]
       int       3
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF801FA018
       call      qword ptr [7FFF800A7738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF80814750]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF8081E4D8]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD710C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L25
M00_L33:
       mov       r11,7FFF7FD710E0
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD710E0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 983
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rsi,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rsi
       jne       near ptr M02_L09
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L10
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L11
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M02_L08
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L17
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
M02_L01:
       test      rdi,rdi
       je        short M02_L07
M02_L02:
       movzx     ecx,byte ptr [rbx+1C]
       test      ecx,ecx
       jne       near ptr M02_L13
       mov       rbp,[rdi+10]
       mov       r14,[rdi+18]
M02_L03:
       mov       rcx,[rbx]
       mov       rdx,[rdi+8]
       cmp       [rcx],rsi
       jne       near ptr M02_L14
M02_L04:
       mov       r14,[rbx+8]
       mov       r15d,[r14+10]
       mov       rcx,[r14+8]
       cmp       [rcx+8],r15d
       jbe       near ptr M02_L15
       mov       edx,r15d
       mov       r8,rdi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r14+14]
       inc       r15d
       mov       [r14+10],r15d
M02_L05:
       mov       rdi,rbp
M02_L06:
       test      rdi,rdi
       jne       short M02_L02
M02_L07:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       call      qword ptr [7FFF8081E5C8]
       int       3
M02_L09:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8081E5B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L11:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       jmp       near ptr M02_L01
M02_L13:
       mov       rbp,[rdi+18]
       mov       r14,[rdi+10]
       jmp       near ptr M02_L03
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L16
       jmp       near ptr M02_L04
M02_L15:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFF8081E4D8]
       jmp       near ptr M02_L05
M02_L16:
       test      r14,r14
       je        near ptr M02_L05
       mov       rcx,[rbx]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L05
       mov       rdi,r14
       jmp       near ptr M02_L06
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 461
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF808153B0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1A716000AC8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8077CFC0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD910D0
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF8077CFC0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD910D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
       add       r14,10
       jmp       short M00_L23
M00_L22:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L23:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L25
M00_L24:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L26
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L24
M00_L25:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L26:
       mov       ebx,1
       jmp       short M00_L20
M00_L27:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A716000AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A716000AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L28:
       call      qword ptr [7FFF800C79A8]
       int       3
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF80834768]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF8083E4F0]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD910C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L25
M00_L33:
       mov       r11,7FFF7FD910E0
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD910E0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 983
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF8083E5E0]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8083E5C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077CF90]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF808353B0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,18749C02AF8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L28
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF806FFA50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD91330
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF806FFA50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD91338
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L22
       add       r14,10
       jmp       short M00_L24
M00_L22:
       call      qword ptr [7FFF800C79A8]
       int       3
M00_L23:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L24:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L26
M00_L25:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L27
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L25
M00_L26:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L27:
       mov       ebx,1
       jmp       short M00_L20
M00_L28:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18749C02AF0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18749C02AF8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF80654E40]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF8084F9C0]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD91328
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L26
M00_L33:
       mov       r11,7FFF7FD91340
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD91340
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 979
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF8084FAE0]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8084FAC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF806FFA20]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF8065E640]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       rax,1F30F800B70
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L28
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+24]
       mov       ecx,[rbx+20]
       inc       ecx
       or        ecx,1
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       add       r15d,r15d
       js        near ptr M00_L29
       mov       edx,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L03
M00_L01:
       mov       r15,[rdx+10]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       mov       eax,[rcx+8]
       cmp       eax,r12d
       jbe       near ptr M00_L30
       mov       eax,r12d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M00_L02:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L01
M00_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],r14d
       mov       byte ptr [rdi+24],0
M00_L04:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L16
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L16
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF808366D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L07
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L05
       mov       edx,[rdi+8]
       test      edx,edx
       je        short M00_L05
       jmp       near ptr M00_L18
M00_L07:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L08:
       mov       r11,7FFF7FD61770
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L09:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF808366D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFF7FD61778
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L14
M00_L11:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L12
       xor       ebx,ebx
       jmp       short M00_L13
M00_L12:
       mov       rbx,[rcx+8]
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L15
M00_L14:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L16
       jmp       short M00_L18
M00_L15:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L17
M00_L16:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       je        short M00_L16
M00_L18:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L33
M00_L19:
       mov       ebx,1
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
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
M00_L21:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L22
       add       r14,10
       jmp       short M00_L24
M00_L22:
       call      qword ptr [7FFF800979A8]
       int       3
M00_L23:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L24:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L26
M00_L25:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L27
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L25
M00_L26:
       xor       ebx,ebx
       jmp       short M00_L20
M00_L27:
       mov       ebx,1
       jmp       short M00_L20
M00_L28:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F30F800B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F30F800B70
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L29:
       mov       ecx,783
       mov       rdx,7FFF801EA018
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFF80646B80]
       int       3
M00_L30:
       mov       rcx,r13
       call      qword ptr [7FFF809E4660]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFF7FD61768
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L32:
       call      M00_L35
       jmp       near ptr M00_L26
M00_L33:
       mov       r11,7FFF7FD61780
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-40]
       cmp       [r11],rcx
       je        short M00_L36
       mov       rcx,r11
       mov       r11,7FFF7FD61780
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 979
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M02_L04
M02_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M02_L05
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M02_L06
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M02_L03
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M02_L15
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L07
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+18]
M02_L01:
       test      rsi,rsi
       jne       short M02_L08
M02_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFF809E4780]
       int       3
M02_L04:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF809E4768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF802B7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       xor       eax,eax
       mov       [rbx+10],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx+10]
       mov       rsi,[rcx+10]
       jmp       short M02_L01
M02_L08:
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L09
       mov       rdi,[rsi+10]
       mov       rbp,[rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rdi,[rsi+18]
       mov       rbp,[rsi+10]
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L11
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF808366A0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
       jmp       short M02_L12
M02_L11:
       test      rbp,rbp
       je        short M02_L12
       mov       rcx,[rbx]
       mov       rdx,[rbp+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M02_L13
M02_L12:
       mov       rsi,rdi
       jmp       short M02_L14
M02_L13:
       mov       rsi,rbp
M02_L14:
       test      rsi,rsi
       jne       short M02_L08
       jmp       near ptr M02_L02
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 365
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF80647888]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M00_L02
M00_L00:
       cmp       dword ptr [rsi+20],0
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
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 84
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1FF69C02AB8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF80746C80]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF8084EFE8]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD90FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8084ECB8]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8084ECB8]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8077D3E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8077D3F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8077D1E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF808052C8
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD90FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80844A20]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8084EC40]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802E59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80844A20]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8084E970]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8084E970]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8084E9A0]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD90FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FF69C02C18
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1FF69C02AB8
       mov       rcx,[rcx]
       call      qword ptr [7FFF8077D1D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       call      qword ptr [7FFF8077F918]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE4D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        short M03_L00
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,847
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8084ECD0]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       cmp       qword ptr [rdi+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L47
M05_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L20
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L21
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L23
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L24
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L25
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L26
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L27
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L28
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L28
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L33
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L33
M05_L17:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L34
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L81
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD90FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
M05_L18:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L19:
       inc       edi
       jmp       near ptr M05_L17
M05_L20:
       mov       rcx,rdx
       mov       rdx,7FFF80930A30
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFF808113F0
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFF80930D58
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFF80930A70
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFF809313D8
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFF809313F8
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFF809314E0
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFF8090D288
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF8090D320
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L29:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r14,r14
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L31
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD90FC8
       call      qword ptr [r11]
M05_L30:
       test      eax,eax
       je        short M05_L32
M05_L31:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L32:
       inc       edi
M05_L33:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L34
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L29
       mov       rcx,rdx
       mov       rdx,7FFF80930A90
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L29
M05_L34:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L35:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L41
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8077D338]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L42
M05_L37:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L43
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L38:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L39
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L39:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L40:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L41:
       mov       rcx,rdx
       mov       rdx,7FFF80930B78
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80930B98
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L43:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8077D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8077D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L44:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L45:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFF8090EDF0
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L44
M05_L47:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80515CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF808AE080
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFEE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8084F078]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF80800440]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD90FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF80930D80
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFEE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD90FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFEE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF8084EE08]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFE7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8051DFC8]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8039C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800CC1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L19
       jmp       near ptr M05_L18
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L30
M05_L74:
       test      r8,r8
       je        near ptr M05_L32
       jmp       near ptr M05_L31
M05_L75:
       call      qword ptr [7FFF8084E820]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80515CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF8084E850]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF804ACC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8084EE80]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M05_L81:
       call      qword ptr [7FFF80774D08]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807EC280
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084E9D0]
       int       3
M05_L86:
       call      qword ptr [7FFF8084ECD0]
       mov       rbx,rax
       jmp       near ptr M05_L40
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L40
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD90FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2804
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF80742190]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF80941288
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF8094128C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8077D1E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF80941290
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8084ECE8]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1D772800AC0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF80736FE0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF8083F018]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD80FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083ED00]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083ED00]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8076D230]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8076D248]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8076D038]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF807DFC00
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D2A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD80FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80834A50]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8083EC88]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802D59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80834A50]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8083E9B8]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8083E9B8]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8083E9E8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD80FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D772800C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1D772800AC0
       mov       rcx,[rcx]
       call      qword ptr [7FFF8076D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       call      qword ptr [7FFF8076F990]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE3D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        short M03_L00
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,847
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8083ED18]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       cmp       qword ptr [rdi+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L47
M05_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L20
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L21
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L23
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L24
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L25
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L26
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L27
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L28
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L28
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L33
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L33
M05_L17:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L34
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L81
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD80FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
M05_L18:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L19:
       inc       edi
       jmp       near ptr M05_L17
M05_L20:
       mov       rcx,rdx
       mov       rdx,7FFF80921F28
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFF80802680
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFF80922250
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFF80921F68
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFF809228D0
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFF809228F0
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFF809229D8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFF808FE8A8
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF808FE940
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L29:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r14,r14
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L31
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD80FC8
       call      qword ptr [r11]
M05_L30:
       test      eax,eax
       je        short M05_L32
M05_L31:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L32:
       inc       edi
M05_L33:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L34
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L29
       mov       rcx,rdx
       mov       rdx,7FFF80921F88
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L29
M05_L34:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L35:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L41
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8076D188]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L42
M05_L37:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L43
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L38:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L39
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L39:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L40:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L41:
       mov       rcx,rdx
       mov       rdx,7FFF80922070
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80922090
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L43:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8076D1E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8076D1E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L44:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L45:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFF80920300
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L44
M05_L47:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF8085E1C8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083F0A8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF807DAD78]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF80922278
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFDE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF8083EE50]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFD7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8050E478]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8038C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800BC1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L19
       jmp       near ptr M05_L18
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L30
M05_L74:
       test      r8,r8
       je        near ptr M05_L32
       jmp       near ptr M05_L31
M05_L75:
       call      qword ptr [7FFF8083E898]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF8083E8C8]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF8049CC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8083EEC8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M05_L81:
       call      qword ptr [7FFF80764AC8]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807D6E18
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA18]
       int       3
M05_L86:
       call      qword ptr [7FFF8083ED18]
       mov       rbx,rax
       jmp       near ptr M05_L40
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L40
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2804
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF80732B50]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF80930B50
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF80930B54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8076D038]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF80930B58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8083ED30]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,26CAF800AC0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF80727160]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF8081F018]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD60FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8081ED00]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8081ED00]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8074D2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8074D308]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8074D0F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF807D3EA0
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074D368]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD60FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF801EA018
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80814A50]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8081EC88]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802B59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF801EA018
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80814A50]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8081E9B8]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8081E9B8]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8081E9E8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD60FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26CAF800C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,26CAF800AC0
       mov       rcx,[rcx]
       call      qword ptr [7FFF8074D0E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       call      qword ptr [7FFF8074F990]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        short M03_L00
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,847
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074D350]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074D350]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8081ED18]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       cmp       qword ptr [rdi+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L47
M05_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L20
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L21
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L23
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L24
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L25
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L26
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L27
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L28
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L28
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L33
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L33
       jmp       short M05_L18
M05_L17:
       inc       edi
M05_L18:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L34
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L81
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD60FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M05_L17
M05_L20:
       mov       rcx,rdx
       mov       rdx,7FFF80900E30
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFF807E1838
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFF80901158
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFF80900E70
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFF809017D8
       call      qword ptr [7FFF80097AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFF809017F8
       call      qword ptr [7FFF80097AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFF809018E0
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFF808DD820
       call      qword ptr [7FFF80097AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF808DD8B8
       call      qword ptr [7FFF80097AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L29:
       mov       rax,r14
       cmp       r12d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r12d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r13,r13
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L31
       mov       rcx,r13
       mov       rdx,r8
       mov       r11,7FFF7FD60FC8
       call      qword ptr [r11]
M05_L30:
       test      eax,eax
       je        short M05_L32
M05_L31:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L32:
       inc       edi
M05_L33:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L34
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r14,[r15+8]
       mov       r8,r14
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r8+rax*8+10]
       mov       r13,rax
       lea       eax,[rdi-1]
       mov       r12d,eax
       cmp       r12d,edx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L29
       mov       rcx,rdx
       mov       rdx,7FFF80900E90
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L29
M05_L34:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L35:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L41
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8074D248]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L42
M05_L37:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L43
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L38:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L39
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074D350]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074D350]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L39:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L40:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L41:
       mov       rcx,rdx
       mov       rdx,7FFF80900F78
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80900F98
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L43:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8074D2A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8074D2A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L44:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L45:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFF808DF1F0
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L44
M05_L47:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF804E5CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF8084CBF0
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFBE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8081F0A8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF807BEFF8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF80901180
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFBE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFBE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF8081EE50]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFB7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF804EE478]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8036C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF8009C1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L73:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [r11]
       jmp       near ptr M05_L30
M05_L74:
       test      r8,r8
       je        near ptr M05_L32
       jmp       near ptr M05_L31
M05_L75:
       call      qword ptr [7FFF8081E898]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF804E5CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF8081E8C8]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF8047CC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8081EEC8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M05_L81:
       call      qword ptr [7FFF80744AB0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807BB098
       call      qword ptr [7FFF80097738]
       mov       rcx,rax
       call      qword ptr [7FFF8081EA18]
       int       3
M05_L86:
       call      qword ptr [7FFF8081ED18]
       mov       rbx,rax
       jmp       near ptr M05_L40
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L40
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2811
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF80722BF0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF80910B50
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF80910B54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8074D0F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF80910B58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8081ED30]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,2CBD6400AC0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF80747100]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF8084F018]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD90FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8084ED00]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8084ED00]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8077D308]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8077D320]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8077D110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF80803EA0
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D380]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD90FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80844A50]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8084EC88]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802E59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80844A50]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8084E9B8]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8084E9B8]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8084E9E8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD90FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2CBD6400C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,2CBD6400AC0
       mov       rcx,[rcx]
       call      qword ptr [7FFF8077D0F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       call      qword ptr [7FFF8077F948]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE4D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        short M03_L00
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,847
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D368]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D368]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8084ED18]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       cmp       qword ptr [rdi+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L47
M05_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L20
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L21
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L23
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L24
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L25
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L26
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L27
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L28
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L28
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L33
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M05_L33
M05_L17:
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jge       near ptr M05_L34
       cmp       edi,ecx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       edx,[r8+8]
       cmp       edi,edx
       jae       near ptr M05_L88
       mov       r11d,edi
       mov       r14,[r8+r11*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,ecx
       jae       near ptr M05_L81
       cmp       ebx,edx
       jae       near ptr M05_L88
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD90FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
M05_L18:
       lea       ecx,[rsi+1]
       mov       r14d,ecx
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jae       near ptr M05_L81
       mov       rdx,[r15+8]
       mov       r10,rdx
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       r8d,edi
       mov       r8,[r10+r8*8+10]
       cmp       esi,ecx
       jae       near ptr M05_L81
       mov       rcx,rdx
       movsxd    rdx,esi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L19:
       inc       edi
       jmp       near ptr M05_L17
M05_L20:
       mov       rcx,rdx
       mov       rdx,7FFF80931020
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFF80811838
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFF80931348
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFF80931060
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFF809319C0
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFF809319E0
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFF80931AC8
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFF8090D920
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF8090D9B8
       call      qword ptr [7FFF800C7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L29:
       mov       rax,r14
       cmp       r12d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r12d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r13,r13
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L31
       mov       rcx,r13
       mov       rdx,r8
       mov       r11,7FFF7FD90FC8
       call      qword ptr [r11]
M05_L30:
       test      eax,eax
       je        short M05_L32
M05_L31:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L32:
       inc       edi
M05_L33:
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jge       short M05_L34
       cmp       edi,ecx
       jae       near ptr M05_L81
       mov       r14,[r15+8]
       mov       r8,r14
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       edx,edi
       mov       rdx,[r8+rdx*8+10]
       mov       r13,rdx
       lea       edx,[rdi-1]
       mov       r12d,edx
       cmp       r12d,ecx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L29
       mov       rcx,rdx
       mov       rdx,7FFF80931080
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L29
M05_L34:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L35:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L41
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8077D260]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L42
M05_L37:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L43
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L38:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L39
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D368]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8077D368]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L39:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L40:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L41:
       mov       rcx,rdx
       mov       rdx,7FFF80931168
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80931188
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L43:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8077D2C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8077D2C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L44:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L45:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFF8090FD00
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L44
M05_L47:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80515CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF8087C960
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFEE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8084F0A8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF807EF008]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD90FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF80931370
       call      qword ptr [7FFF7FE4C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFEE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD90FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFEE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF8084EE50]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFE7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8051DFC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8039C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800CC1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L19
       jmp       near ptr M05_L18
M05_L73:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [r11]
       jmp       near ptr M05_L30
M05_L74:
       test      r8,r8
       je        near ptr M05_L32
       jmp       near ptr M05_L31
M05_L75:
       call      qword ptr [7FFF8084E898]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80515CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF8084E8C8]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF804ACC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8084EEC8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M05_L81:
       call      qword ptr [7FFF80774AE0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807EB0A8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF8084EC10]
       int       3
M05_L86:
       call      qword ptr [7FFF8084ED18]
       mov       rbx,rax
       jmp       near ptr M05_L40
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L40
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD90FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2805
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF80742DD0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF809406A0
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF809406A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8077D110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF809406A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8084ED30]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1E95F000AC0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF80737440]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF8083F000]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD80FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083ECD0]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083ECD0]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8076D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8076D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8076D0E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF807F37F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D350]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD80FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80834A38]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8083EC58]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802D59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80834A38]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8083E778]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8083E778]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8083E7D8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD80FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E95F000C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1E95F000AC0
       mov       rcx,[rcx]
       call      qword ptr [7FFF8076D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       call      qword ptr [7FFF8076F990]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE3D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M03_L01
       test      rdi,rdi
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,851
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8083ECE8]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rax,[rcx+8]
       cmp       qword ptr [rax+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L20
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L21
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L23
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L24
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L25
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L26
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L27
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L28
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L29
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L34
       jmp       short M05_L18
M05_L17:
       inc       edi
M05_L18:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L35
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L81
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD80FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M05_L17
M05_L20:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       rcx,rdx
       mov       rdx,7FFF809208C0
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFF80812080
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFF80920BE8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFF80920900
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFF80921268
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFF80921288
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFF80921370
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF808FF0A8
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFF808FF140
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r14,r14
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD80FC8
       call      qword ptr [r11]
M05_L31:
       test      eax,eax
       je        short M05_L33
M05_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L33:
       inc       edi
M05_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L35
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFF80920920
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L30
M05_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L42
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8076D230]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L43
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L41:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80920A08
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFF80920A28
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L44:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FFF808FE920
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF8086D1B8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083F090]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF807DE8F8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF80920C10
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFDE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF8083EE20]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFD7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8050DFC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8038C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800BC1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L74:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L75:
       call      qword ptr [7FFF8083EB98]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF8083EBC8]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF8049CC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8083EE98]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M05_L81:
       call      qword ptr [7FFF80764A98]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807DA998
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA60]
       int       3
M05_L86:
       call      qword ptr [7FFF8083ECE8]
       mov       rbx,rax
       jmp       near ptr M05_L41
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L41
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2810
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF80731E30]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF8091E7B8
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF8091E7BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8076D0E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF8091E7C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8083ED00]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1C782002AB8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF807373C0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF8083F078]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD80FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083EE20]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083EE20]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8076D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8076D350]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8076D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF807F3EA0
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D3B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD80FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80834AB0]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8083EDC0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802D59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80834AB0]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8083EAC0]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8083EAC0]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8083EAF0]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD80FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C782002C18
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1C782002AB8
       mov       rcx,[rcx]
       call      qword ptr [7FFF8076D128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       call      qword ptr [7FFF8076F210]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE3D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        short M03_L00
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,847
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8083ED78]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rax,[rcx+8]
       cmp       qword ptr [rax+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L20
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+70]
       test      r14,r14
       je        near ptr M05_L21
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L23
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+78]
       test      rdi,rdi
       je        near ptr M05_L24
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L25
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L26
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L27
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L28
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L29
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L34
       jmp       short M05_L18
M05_L17:
       inc       edi
M05_L18:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L35
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L81
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD80FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M05_L17
M05_L20:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       rcx,rdx
       mov       rdx,7FFF80921A20
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFF807EFCA0
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFF80921E20
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFF80921A60
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFF80922498
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFF809224B8
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFF809225A0
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF808FF0D8
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFF808FF170
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r14,r14
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD80FC8
       call      qword ptr [r11]
M05_L31:
       test      eax,eax
       je        short M05_L33
M05_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L33:
       inc       edi
M05_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L35
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFF80921A80
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L30
M05_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M05_L42
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8076D290]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M05_L43
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8076D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L41:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80921C58
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFF80921C78
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L44:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8076D2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8076D2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FFF808FE230
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF8086D178
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8083F108]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF807DEFF8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF80921E48
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFDE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF8083EF40]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFD7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8050DFC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8038C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800BC1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L74:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L75:
       call      qword ptr [7FFF8083EBF8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF8083EC28]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF8049CC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8083ECD0]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M05_L81:
       call      qword ptr [7FFF80764AE0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807DB098
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF8083EA48]
       int       3
M05_L86:
       call      qword ptr [7FFF8083ED78]
       mov       rbx,rax
       jmp       near ptr M05_L41
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L41
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD80FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2816
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF807322F0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF8091F540
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF8091F544
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8076D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF8091F548
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8083EE38]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L33
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L34
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L35
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L36
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L06
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       short M00_L06
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,2353B400AC0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF80978260]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L30
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF80A04618]
       mov       r14,rax
M00_L09:
       add       r15,8
M00_L10:
       dec       edi
       je        near ptr M00_L29
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD812C8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF80A04300]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L16
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L11
       mov       r13,[r14+18]
M00_L11:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L13:
       mov       [rsp+40],r14
M00_L14:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L08
       mov       r14,[rsp+40]
       jmp       near ptr M00_L09
M00_L15:
       mov       ecx,edx
       jmp       short M00_L12
M00_L16:
       test      r13,r13
       je        short M00_L17
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L19
M00_L18:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L13
M00_L19:
       mov       ecx,edx
       jmp       short M00_L18
M00_L20:
       test      eax,eax
       jge       near ptr M00_L27
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF80A04300]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+24],0
       je        short M00_L23
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L21
       mov       r13,[r14+10]
M00_L21:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF8074ED78]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L22:
       mov       [rsp+40],r14
       jmp       near ptr M00_L14
M00_L23:
       test      r13,r13
       je        short M00_L24
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L24:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     eax,byte ptr [rax+25]
       cmp       ecx,eax
       jl        short M00_L26
M00_L25:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       mov       rcx,[r14+18]
       add       edx,[rcx+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       jmp       short M00_L25
M00_L27:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L09
M00_L28:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8074ED90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF8074EB80]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF80817388
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074EDF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFF7FD812B8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80844AB0]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF80A04288]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802D59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFF8020A018
       call      qword ptr [7FFF800B7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80844AB0]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF8084FD98]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF8084FD98]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF8084FDC8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD812C0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2353B400C48
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,2353B400AC0
       mov       rcx,[rcx]
       call      qword ptr [7FFF8074EB68]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1915
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L01
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       jmp       short M02_L04
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       call      qword ptr [7FFF8066E928]
       int       3
M02_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE3D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M03_L01
       test      rdi,rdi
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,851
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074EDD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074EDD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF80A04318]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rax,[rcx+8]
       cmp       qword ptr [rax+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L20
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L21
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M05_L23
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L24
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L25
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L26
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0E0]
       test      rdi,rdi
       je        near ptr M05_L27
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L28
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L29
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L34
       jmp       short M05_L18
M05_L17:
       inc       edi
M05_L18:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L35
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L81
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L72
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD812E0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M05_L17
M05_L20:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       rcx,rdx
       mov       rdx,7FFF809EAC88
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFF80696C68
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFF809E2BE8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFF809EACC8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFF809EB360
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFF809EB380
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFF809EB468
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF809E9480
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFF809E9518
       call      qword ptr [7FFF800B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L73
       test      r14,r14
       je        near ptr M05_L74
       test      r8,r8
       je        short M05_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD812E0
       call      qword ptr [r11]
M05_L31:
       test      eax,eax
       je        short M05_L33
M05_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L33:
       inc       edi
M05_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L35
       cmp       edi,edx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFF809EACE8
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L30
M05_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L42
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF8074ECD0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L43
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L85
       cmp       byte ptr [r14+24],0
       jne       short M05_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074EDD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8074EDD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L41:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF809EADD0
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFF809EADF0
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L44:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF8074ED30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF8074ED30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L82
       cmp       edi,[rbx+10]
       jae       near ptr M05_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L83
       test      r14,r14
       je        near ptr M05_L84
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L89
       cmp       ecx,0FF
       ja        near ptr M05_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FFF809E8A38
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF808A06D0
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80A04690]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF80812500]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD812D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF809E2C10
       call      qword ptr [7FFF7FE3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L60
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFDE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD812D8
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFDE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF80A04450]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFD7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8050DFC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8038C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800BC1C8]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L74:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L75:
       call      qword ptr [7FFF80A041C8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80505CF8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFF80A041F8]
       int       3
M05_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF8049CC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF8084FB28]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M05_L81:
       call      qword ptr [7FFF80746688]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFF807FE590
       call      qword ptr [7FFF800B7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A04060]
       int       3
M05_L86:
       call      qword ptr [7FFF80A04318]
       mov       rbx,rax
       jmp       near ptr M05_L41
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L41
M05_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD812D8
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2810
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF809733B0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF809FF7A0
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF809FF7A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF8074EB80]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF809FF7A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF80A04330]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L35
       mov       edi,[rsi+20]
M00_L00:
       test      edi,edi
       je        near ptr M00_L41
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rsi+20]
       mov       r14d,ebp
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+10],ecx
       mov       [r15+14],r14d
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,ebp
       test      r14d,r14d
       jl        near ptr M00_L07
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L36
       mov       [r15+14],ebp
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L08
       inc       ebp
       or        ebp,1
       xor       r14d,r14d
       lzcnt     r14d,ebp
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       r14d,r14d
       js        near ptr M00_L06
       mov       edx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
M00_L01:
       mov       esi,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,esi
       jbe       near ptr M00_L37
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       esi
       mov       [rbp+10],esi
M00_L02:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L01
M00_L03:
       mov       r8d,[rbp+10]
       test      r8d,r8d
       je        near ptr M00_L08
       dec       r8d
       mov       rdx,[rbp+8]
       mov       ecx,[rdx+8]
       cmp       ecx,r8d
       jbe       near ptr M00_L39
       inc       dword ptr [rbp+14]
       mov       [rbp+10],r8d
       mov       rsi,[rdx+r8*8+10]
       xor       ecx,ecx
       mov       [rdx+r8*8+10],rcx
       mov       edx,[r15+10]
       cmp       edx,[r15+14]
       jge       near ptr M00_L08
       mov       rcx,[r15+8]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,[rsi+8]
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M00_L03
M00_L04:
       mov       r14d,[rbp+10]
       mov       rcx,[rbp+8]
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       near ptr M00_L38
       mov       edx,r14d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       inc       r14d
       mov       [rbp+10],r14d
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
       jmp       near ptr M00_L03
M00_L06:
       mov       ecx,783
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80676C58]
       int       3
M00_L07:
       mov       ecx,80B
       mov       rdx,7FFF8021A018
       call      qword ptr [7FFF800C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF80676C58]
       int       3
M00_L08:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L09:
       mov       r8,1D176800B68
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L32
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFF808F5658]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L32
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L12
M00_L10:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFF80A152C0]
       mov       r14,rax
M00_L11:
       add       r15,8
M00_L12:
       dec       edi
       je        near ptr M00_L31
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L43
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L30
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFF7FD91640
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L22
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF80A14FD8]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L16
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L18
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L13
       mov       r13,[r14+18]
M00_L13:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L44
       test      r13,r13
       je        near ptr M00_L45
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        short M00_L17
M00_L14:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L15:
       mov       [rsp+40],r14
M00_L16:
       cmp       byte ptr [rsp+60],0
       jne       near ptr M00_L10
       mov       r14,[rsp+40]
       jmp       near ptr M00_L11
M00_L17:
       mov       ecx,edx
       jmp       short M00_L14
M00_L18:
       test      r13,r13
       je        short M00_L19
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L19:
       mov       rax,[r14+10]
       movzx     ecx,byte ptr [rax+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L21
M00_L20:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       ecx,[rax+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       short M00_L15
M00_L21:
       mov       ecx,edx
       jmp       short M00_L20
M00_L22:
       test      eax,eax
       jge       near ptr M00_L29
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF80A14FD8]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L16
       cmp       byte ptr [r14+24],0
       je        short M00_L25
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L23
       mov       r13,[r14+10]
M00_L23:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rax
       mov       rdx,r12
       mov       r8,r13
       mov       r9,r14
       call      qword ptr [7FFF80856CE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L24:
       mov       [rsp+40],r14
       jmp       near ptr M00_L16
M00_L25:
       test      r13,r13
       je        short M00_L26
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     r8d,byte ptr [rax+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       add       edx,[rax+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L24
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       near ptr M00_L11
M00_L30:
       mov       dword ptr [rsp+60],1
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+25]
       add       ecx,1
       jo        near ptr M00_L47
       cmp       ecx,0FF
       ja        near ptr M00_L47
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L11
M00_L31:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF80856D00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L33
M00_L32:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFF80856AF0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L33:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFF80945E00
       cmp       [rcx],ecx
       call      qword ptr [7FFF80856D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFF7FD91630
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF80A14F60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF802E59E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFF80A14AC8]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF80A14AC8]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFF80A14AF8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF7FD91638
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D176800C80
       mov       rdi,[rcx]
       jmp       near ptr M00_L08
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L09
M00_L43:
       mov       ecx,873
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1D176800B68
       mov       rcx,[rcx]
       call      qword ptr [7FFF80856AD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       jmp       near ptr M00_L33
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1906
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
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L01
       cmp       rdx,[r8]
       je        short M02_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFF80675680]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7FE4D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M03_L01
       test      rdi,rdi
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+25]
       movzx     edx,byte ptr [rdi+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M03_L02
       cmp       ecx,0FF
       ja        short M03_L02
       mov       [rbx+25],cl
       mov       ecx,[rsi+20]
       add       ecx,[rdi+20]
       inc       ecx
       mov       [rbx+20],ecx
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+24],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,851
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,[rsi+8]
       je        near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       je        short M04_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80856D48]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80856D48]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,873
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF80A14FF0]
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rax,[rcx+8]
       cmp       qword ptr [rax+10],0
       jne       short M05_L00
       test      esi,esi
       je        near ptr M05_L20
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L21
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L48
       test      r13d,r13d
       je        near ptr M05_L49
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        near ptr M05_L22
       mov       rcx,rax
M05_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M05_L23
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L56
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L52
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L24
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L62
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L25
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L65
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L26
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L66
       cmp       [rdi+8],r13d
       jb        near ptr M05_L67
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFFDFA15D60
       cmp       dword ptr [7FFFDFD7F778],0
       jne       near ptr M05_L68
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L77
       cmp       esi,1
       jle       near ptr M05_L16
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0E0]
       test      rdi,rdi
       je        near ptr M05_L27
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L78
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L28
M05_L14:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L29
M05_L15:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,offset MT_System.Collections.Generic.GenericArraySortHelper<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M05_L72
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r8,rbx
       call      qword ptr [7FFF800AB4C0]; System.Collections.Generic.GenericArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Span`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M05_L16:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L34
       jmp       short M05_L18
M05_L17:
       inc       edi
M05_L18:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L35
       cmp       edi,edx
       jae       near ptr M05_L82
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L89
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L82
       cmp       ebx,r11d
       jae       near ptr M05_L89
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L73
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD91658
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L82
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L89
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L82
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M05_L17
M05_L20:
       mov       rax,rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       rcx,rdx
       mov       rdx,7FFF80A511C0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFF80656B88
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFF809EF1B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFF80A51200
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFF80A518A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFF80A518C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFF80A519B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFF80A2F9A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFF80A2FA38
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L89
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L74
       test      r14,r14
       je        near ptr M05_L75
       test      r8,r8
       je        short M05_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFF7FD91658
       call      qword ptr [r11]
M05_L31:
       test      eax,eax
       je        short M05_L33
M05_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L82
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L89
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L82
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M05_L33:
       inc       edi
M05_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L35
       cmp       edi,edx
       jae       near ptr M05_L82
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L89
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L82
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFF80A51220
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L30
M05_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L76
       test      ebx,ebx
       jl        near ptr M05_L77
       test      ebx,ebx
       jg        near ptr M05_L79
M05_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L42
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFF80856C40]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L43
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L81
       test      edi,edi
       jne       near ptr M05_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L88
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L87
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L86
       cmp       byte ptr [r14+24],0
       jne       short M05_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80856D48]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80856D48]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L41:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFF80A51308
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFF80A51328
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L44:
       lea       r14d,[rdi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       edi
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFF80856CA0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFF80856CA0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L83
       cmp       edi,[rbx+10]
       jae       near ptr M05_L82
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L89
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L84
       test      r14,r14
       je        near ptr M05_L85
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r15+25]
       movzx     eax,byte ptr [r14+25]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L90
       cmp       ecx,0FF
       ja        near ptr M05_L90
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FFF80A2F0A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF80515CF8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+70]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FFF806AD018
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L51:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L52:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L55
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L90
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L53
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L54
M05_L53:
       mov       edx,4
M05_L54:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFF7FFEE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80A15350]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF80940F78]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD91648
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FFF809EF1E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L59:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M05_L60
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L57
M05_L60:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF7FFEE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD91650
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L90
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L63
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L64
M05_L63:
       mov       eax,4
M05_L64:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFF7FFEE388]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFF80A15128]
       int       3
M05_L67:
       call      qword ptr [7FFF7FFE7138]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF8051DFC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFF8039C678]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFF800CC1C8]
       int       3
M05_L72:
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
       jmp       near ptr M05_L16
M05_L73:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L74:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L75:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L76:
       call      qword ptr [7FFF80A14EB8]
       int       3
M05_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFF80515CF8]
       int       3
M05_L78:
       mov       ecx,10
       call      qword ptr [7FFF80794828]
       int       3
M05_L79:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L80
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFF804ACC60]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L80:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFF80A141B0]
       jmp       near ptr M05_L36
M05_L81:
       mov       ecx,40B
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M05_L82:
       call      qword ptr [7FFF80677BE8]
       int       3
M05_L83:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L84:
       mov       ecx,847
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M05_L85:
       mov       ecx,851
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M05_L86:
       mov       ecx,873
       mov       rdx,7FFF8093CFE8
       call      qword ptr [7FFF800C7738]
       mov       rcx,rax
       call      qword ptr [7FFF80A14D80]
       int       3
M05_L87:
       call      qword ptr [7FFF80A14FF0]
       mov       rbx,rax
       jmp       near ptr M05_L41
M05_L88:
       mov       rbx,rcx
       jmp       near ptr M05_L41
M05_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L91
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD91650
       call      qword ptr [r11]
M05_L91:
       nop
       add       rsp,28
       ret
; Total bytes of code 2832
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFF7FE45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M08_L00
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rbx+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FFF808F1970]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFF80A4EA28
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFF80A4EA2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF80856AF0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFF80A4EA30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF80A15008]
; Total bytes of code 142
```

