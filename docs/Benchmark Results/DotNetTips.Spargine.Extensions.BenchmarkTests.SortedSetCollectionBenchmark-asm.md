## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1D4DF402B10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C7DA10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF917341160
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C7DA10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF917341168
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L25
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L25:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L27
M00_L26:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L28:
       mov       ebx,1
       jmp       short M00_L22
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D4DF402B08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D4DF402B10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF91767C1F8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF91771A018
       call      qword ptr [7FF917677F78]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917D24EE8]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917D2E940]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF917341158
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF917341170
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF917341170
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917D2EA30]
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
       call      qword ptr [7FF917D2EA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177BC150]
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
       call      qword ptr [7FF917C7D9E0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917A1EB68]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1AA55C00AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917BCD098]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF9173210D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917BCD098]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF9173210D8
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L25
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L25:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L27
M00_L26:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L28:
       mov       ebx,1
       jmp       short M00_L22
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1AA55C00AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AA55C00AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF9176579A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF9176EA018
       call      qword ptr [7FF917657738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917D04828]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917D0E5B0]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF9173210C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF9173210E0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF9173210E0
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917D0E6A0]
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
       call      qword ptr [7FF917D0E688]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177C7900]
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
       call      qword ptr [7FF917BCD068]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917D05470]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,21642C02AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C5D158]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF9173310D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C5D158]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF9173310D8
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L25
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L25:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L27
M00_L26:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L28:
       mov       ebx,1
       jmp       short M00_L22
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,21642C02AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21642C02AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF9176679A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF9176FA018
       call      qword ptr [7FF917667738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917D14810]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917D1E598]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF9173310C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF9173310E0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF9173310E0
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917D1E688]
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
       call      qword ptr [7FF917D1E670]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177D7900]
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
       call      qword ptr [7FF917C5D128]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917D15458]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1B918400AE0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C75548]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF917330D08
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C75548]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF917330D10
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L25
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L25:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L27
M00_L26:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L28:
       mov       ebx,1
       jmp       short M00_L22
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1B918400AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B918400AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF9176679A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF9176FA018
       call      qword ptr [7FF917667738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917C7EE08]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917C7EDA8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF917330D00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF917330D18
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF917330D18
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917C7EE98]
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
       call      qword ptr [7FF917C7EE80]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177D7900]
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
       call      qword ptr [7FF917C75518]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917D259E0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,2258EC00AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917BCD188]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF9173210D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917BCD188]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF9173210D8
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L25
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L25:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L27
M00_L26:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L28:
       mov       ebx,1
       jmp       short M00_L22
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2258EC00AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2258EC00AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF9176579A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF9176EA018
       call      qword ptr [7FF917657738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917D04840]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917D0E5C8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF9173210C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF9173210E0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF9173210E0
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917D0E6B8]
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
       call      qword ptr [7FF917D0E6A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177C7900]
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
       call      qword ptr [7FF917D0E5C8]
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
       call      qword ptr [7FF917D05488]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1DEC7800AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C4D1D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF9173210D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917C4D1D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF9173210D8
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
       jmp       short M00_L25
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L25:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L27
M00_L26:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L28:
       mov       ebx,1
       jmp       short M00_L22
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DEC7800AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DEC7800AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF9176579A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF9176EA018
       call      qword ptr [7FF917657738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917D04888]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917D0E5F8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF9173210C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF9173210E0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF9173210E0
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917D0E6E8]
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
       call      qword ptr [7FF917D0E6D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177C7900]
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
       call      qword ptr [7FF917C4D1A0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917D054D0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,20A90400AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917BAE268]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF917321338
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917BAE268]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF917321340
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L24
       add       r14,10
       jmp       short M00_L26
M00_L24:
       call      qword ptr [7FF9176579A8]
       int       3
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L26:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L28
M00_L27:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L29
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L27
M00_L28:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L29:
       mov       ebx,1
       jmp       short M00_L22
M00_L30:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20A90400AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20A90400AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       mov       ecx,783
       mov       rdx,7FF9176EA018
       call      qword ptr [7FF917657738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917D048D0]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917D0FB10]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF917321330
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L35:
       mov       r11,7FF917321348
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF917321348
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 995
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917D0FC00]
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
       call      qword ptr [7FF917D0FBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177C7900]
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
       call      qword ptr [7FF917BAE238]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917D05518]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,2E4CA400B80
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L33
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
       js        near ptr M00_L31
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
       jbe       near ptr M00_L32
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
       je        short M00_L10
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L10
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917D468E0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L08
       mov       rbx,[rdx+8]
M00_L06:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L09
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L07:
       test      r14d,r14d
       je        short M00_L05
       jmp       near ptr M00_L20
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L06
M00_L09:
       xor       r14d,r14d
       jmp       short M00_L07
M00_L10:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L11
       mov       r11,7FF917341770
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF917D468E0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF917341778
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
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L19
M00_L17:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L18
       xor       r14d,r14d
       jmp       short M00_L19
M00_L18:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L19:
       test      r14d,r14d
       je        near ptr M00_L10
M00_L20:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L35
M00_L21:
       mov       ebx,1
M00_L22:
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
M00_L23:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L24
       add       r14,10
       jmp       short M00_L26
M00_L24:
       call      qword ptr [7FF9176779A8]
       int       3
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L26:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L28
M00_L27:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L29
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L27
M00_L28:
       xor       ebx,ebx
       jmp       short M00_L22
M00_L29:
       mov       ebx,1
       jmp       short M00_L22
M00_L30:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2E4CA400B78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9173F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2E4CA400B80
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       mov       ecx,783
       mov       rdx,7FF91770A018
       call      qword ptr [7FF917677738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF917B66D30]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF917F04888]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF917341768
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L35:
       mov       r11,7FF917341780
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FF917341780
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 995
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF917F04978]
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
       call      qword ptr [7FF917F04960]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9177E7900]
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
       call      qword ptr [7FF917D468B0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF917B67A38]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,2094E400AD0
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D3B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D3B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,2094E400AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917D2F258]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C5D0B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C5D050]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,2094E400AD0
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917CE5248
       call      qword ptr [7FF917C5D0F8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C27080]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D2F108]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917E23AF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D3B0]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D3B0]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917E23AFC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L49
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L80
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A0]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L50
M02_L02:
       test      rax,rax
       je        near ptr M02_L52
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L51
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L79
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L69
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L62
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L63
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L68
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L66
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L67
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917854808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L79
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0C8]
       test      r14,r14
       je        near ptr M02_L28
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L29
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L30
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L30
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L35
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L35
M02_L18:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       edx,[r8+8]
       cmp       r14d,edx
       jae       near ptr M02_L100
       mov       r11d,r14d
       mov       r15,[r8+r11*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,edx
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L19
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917330FC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L20
M02_L19:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rsi+8]
       mov       r10,rdx
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       r8d,r14d
       mov       r8,[r10+r8*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,rdx
       movsxd    rdx,edi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L20:
       inc       r14d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917E129C8
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917E12FE8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917E13488
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917E10BF8
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917E10C38
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917CF2300
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917E10C50
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF917E13E50
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF917DEDFB0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF917DEE048
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L31:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r15,r15
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L33
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917330FC0
       call      qword ptr [r11]
M02_L32:
       test      eax,eax
       je        short M02_L34
M02_L33:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L34:
       inc       r14d
M02_L35:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       edx,r14d
       mov       r15,[r8+rdx*8+10]
       lea       edx,[r14-1]
       mov       r13d,edx
       cmp       r13d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L31
       mov       rdx,7FF917E13498
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L31
M02_L36:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L37:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L43
       mov       rcx,rax
M02_L38:
       mov       rdx,rsi
       call      qword ptr [7FF917C5D2D8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L44
M02_L39:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       jne       near ptr M02_L45
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M02_L40:
       mov       rdx,[rbp+10]
       cmp       r14,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [r14+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [r14+24],0
       jne       short M02_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D3B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D3B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M02_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L42:
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
M02_L43:
       mov       rdx,7FF917E134E0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF917E12F28
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L45:
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C5D308]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C5D308]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L48
M02_L46:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L47:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       mov       rdx,7FF917DEF538
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF917330FA8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L52:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L53
       jmp       short M02_L54
M02_L53:
       mov       rcx,rsi
       mov       rdx,7FF917E13628
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L54:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L57
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rsi
       mov       rdx,7FF917E13810
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L56:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L57:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917E13748
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L59:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L60
       jmp       short M02_L61
M02_L60:
       mov       rcx,rsi
       mov       rdx,7FF917E137F8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L61:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L79
M02_L62:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L63:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FF917D8EEB0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L65:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L66:
       mov       ecx,80B
       mov       rdx,7FF9176FA018
       call      qword ptr [7FF917667738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D24A98]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917D2F168]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177D5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L68:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L69:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FF917D8EEB0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L71:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FF917E10C08
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917E10C20
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L77
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L74
M02_L77:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91758E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FB8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L79:
       mov       rax,[rbp+10]
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
M02_L80:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        short M02_L81
       jmp       short M02_L82
M02_L81:
       mov       rcx,rdx
       mov       rdx,7FF917E13488
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B54CF0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917AA6010]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91766C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L20
       jmp       near ptr M02_L19
M02_L85:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L86:
       test      r8,r8
       je        near ptr M02_L34
       jmp       near ptr M02_L33
M02_L87:
       call      qword ptr [7FF917D2E880]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF9179F5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917D2E8B0]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       edx,[rsi+10]
       sub       edx,edi
       mov       [rsp+20],edx
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91798CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D2EF70]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M02_L93:
       call      qword ptr [7FF917C54BD0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917D2F018]
       mov       rbx,rax
       jmp       near ptr M02_L42
M02_L99:
       mov       rbx,rdx
       jmp       near ptr M02_L42
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FB8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3278
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C5D380]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917E12A18
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917E12F18
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917D2F258]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C5D0B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C5D050]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CCB098
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2E9B8]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917E129C8
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917E12FE8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C5D0F8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C273E0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D2F108]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917330FC8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917E13628
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917E13810
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917E13748
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917E137F8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,2D047C00AD0
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,2D047C00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917D2F228]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C5D098]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C5D038]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,2D047C00AD0
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917CE51F0
       call      qword ptr [7FF917C5D0E0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C26760]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D2ED90]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917E2AE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D398]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D398]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917E2AE94
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L49
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L80
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L50
M02_L02:
       test      rax,rax
       je        near ptr M02_L52
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L51
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L79
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L69
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L62
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L63
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L68
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L66
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L67
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917854808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L79
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0C8]
       test      r14,r14
       je        near ptr M02_L28
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L29
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L30
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L30
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L35
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L35
M02_L18:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r14d,r11d
       jae       near ptr M02_L100
       mov       r10d,r14d
       mov       r15,[r8+r10*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,r11d
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L19
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917330FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L20
M02_L19:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L20:
       inc       r14d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917E11228
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917E11B80
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917E12020
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917E12C48
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917E12C88
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917CF2B48
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917E12CA0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF917E133E8
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF917DEE348
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF917DEE3E0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L31:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r15,r15
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L33
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917330FB0
       call      qword ptr [r11]
M02_L32:
       test      eax,eax
       je        short M02_L34
M02_L33:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L34:
       inc       r14d
M02_L35:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       r15,[r8+rax*8+10]
       lea       eax,[r14-1]
       mov       r13d,eax
       cmp       r13d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L31
       mov       rdx,7FF917E12030
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L31
M02_L36:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L37:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L43
       mov       rcx,rax
M02_L38:
       mov       rdx,rsi
       call      qword ptr [7FF917C5D2C0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L44
M02_L39:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       jne       near ptr M02_L45
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M02_L40:
       mov       rdx,[rbp+10]
       cmp       r14,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [r14+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [r14+24],0
       jne       short M02_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M02_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L42:
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
M02_L43:
       mov       rdx,7FF917E12078
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF917E11AC0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L45:
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C5D2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C5D2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L48
M02_L46:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L47:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       mov       rdx,7FF917DEFD18
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF917330F98
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L52:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L53
       jmp       short M02_L54
M02_L53:
       mov       rcx,rsi
       mov       rdx,7FF917E121C0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L54:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L57
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rsi
       mov       rdx,7FF917E123A8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L56:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L57:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917E122E0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L59:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L60
       jmp       short M02_L61
M02_L60:
       mov       rcx,rsi
       mov       rdx,7FF917E12390
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L61:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L79
M02_L62:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L63:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FF917D5E0A0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L65:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L66:
       mov       ecx,80B
       mov       rdx,7FF9176FA018
       call      qword ptr [7FF917667738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D24A98]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917D2F0D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177D5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L68:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L69:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FF917D5E0A0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L71:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FF917E12C58
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917E12C70
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L77
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L74
M02_L77:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91758E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L79:
       mov       rax,[rbp+10]
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
M02_L80:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        short M02_L81
       jmp       short M02_L82
M02_L81:
       mov       rcx,rdx
       mov       rdx,7FF917E12020
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B54CA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917AA5FE0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91766C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L20
       jmp       near ptr M02_L19
M02_L85:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L86:
       test      r8,r8
       je        near ptr M02_L34
       jmp       near ptr M02_L33
M02_L87:
       call      qword ptr [7FF917D2E898]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF9179F5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917D2E8C8]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       r8d,[rsi+10]
       sub       r8d,edi
       mov       [rsp+20],r8d
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91798CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D2F150]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M02_L93:
       call      qword ptr [7FF917C54B88]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917D2F1C8]
       mov       rbx,rax
       jmp       near ptr M02_L42
M02_L99:
       mov       rbx,rdx
       jmp       near ptr M02_L42
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3285
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C5D368]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917E11278
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917E11778
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917D2F228]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C5D098]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C5D038]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CCAEC8
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EA18]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917E11228
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917E11B80
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C5D0E0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C26AC0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D2ED90]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917330FB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917E121C0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917E123A8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917E122E0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917E12390
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,1F734C00AD0
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C4D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C4D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,1F734C00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917D1F258]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C4D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C4CFC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,1F734C00AD0
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917CD12B0
       call      qword ptr [7FF917C4D068]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C162E0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D1EDC0]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917E1AE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C4D320]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C4D320]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917E1AE94
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L49
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L80
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L50
M02_L02:
       test      rax,rax
       je        near ptr M02_L52
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L51
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L79
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L69
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L62
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L63
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L68
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L66
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L67
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917844808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L79
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0C8]
       test      r14,r14
       je        near ptr M02_L28
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L29
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L30
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L30
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L35
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L35
M02_L18:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r14d,r11d
       jae       near ptr M02_L100
       mov       r10d,r14d
       mov       r15,[r8+r10*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,r11d
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L19
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917320FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L20
M02_L19:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L20:
       inc       r14d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917E01D60
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917E026B8
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917E02B58
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917E03780
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917E037C0
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917CE3150
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917E037D8
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF917E03F20
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF917DDEE88
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF917DDEF20
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L31:
       mov       rax,r15
       cmp       r12d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r12d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r13,r13
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L33
       mov       rcx,r13
       mov       rdx,r8
       mov       r11,7FF917320FB0
       call      qword ptr [r11]
M02_L32:
       test      eax,eax
       je        short M02_L34
M02_L33:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L34:
       inc       r14d
M02_L35:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r15,[rsi+8]
       mov       r8,r15
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r8+rax*8+10]
       mov       r13,rax
       lea       eax,[r14-1]
       mov       r12d,eax
       cmp       r12d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L31
       mov       rdx,7FF917E02B68
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L31
M02_L36:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L37:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L45
       mov       rcx,rax
M02_L38:
       mov       rdx,rsi
       call      qword ptr [7FF917C4D248]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L46
M02_L39:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       je        near ptr M02_L48
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C4D278]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C4D278]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L47
M02_L40:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L41:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M02_L42:
       mov       rdx,[rbp+10]
       cmp       rbx,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [rbx+24],0
       jne       short M02_L43
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C4D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C4D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M02_L43:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L44:
       mov       rax,rsi
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
M02_L45:
       mov       rdx,7FF917E02BB0
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L46:
       mov       rdx,7FF917E025F8
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rdi
       mov       rdx,7FF917E00858
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L42
M02_L49:
       mov       ecx,885
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF917320F98
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L52:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L53
       jmp       short M02_L54
M02_L53:
       mov       rcx,rsi
       mov       rdx,7FF917E02CF8
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L54:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L57
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rsi
       mov       rdx,7FF917E02EE0
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L56:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L57:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917E02E18
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L59:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L60
       jmp       short M02_L61
M02_L60:
       mov       rcx,rsi
       mov       rdx,7FF917E02EC8
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L61:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L79
M02_L62:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L63:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FF917D4E4D0
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L65:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L66:
       mov       ecx,80B
       mov       rdx,7FF9176EA018
       call      qword ptr [7FF917657738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D14AC8]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917D1F108]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177C5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L68:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L69:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FF917D4E4D0
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L71:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FF917E03790
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF917320FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917E037A8
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L77
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L74
M02_L77:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91757E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF917320FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L79:
       mov       rax,[rbp+10]
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
M02_L80:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        short M02_L81
       jmp       short M02_L82
M02_L81:
       mov       rcx,rdx
       mov       rdx,7FF917E02B58
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B44CD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917A95FC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91765C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L20
       jmp       near ptr M02_L19
M02_L85:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L86:
       test      r8,r8
       je        near ptr M02_L34
       jmp       near ptr M02_L33
M02_L87:
       call      qword ptr [7FF917D1E8C8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF9179E5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917D1E8F8]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       r8d,[rsi+10]
       sub       r8d,edi
       mov       [rsp+20],r8d
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91797CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D1F180]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M02_L93:
       call      qword ptr [7FF917C44BB8]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L41
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917D1F1F8]
       mov       rsi,rax
       jmp       near ptr M02_L44
M02_L99:
       mov       rsi,rdx
       jmp       near ptr M02_L44
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917320FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3285
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C4D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917E01DB0
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917E022B0
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917D1F258]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C4D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C4CFC0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CB6E18
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917D1EA48]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917E01D60
       call      qword ptr [7FF9173DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917E026B8
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C4D068]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C16640]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D1EDC0]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917320FB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917E02CF8
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917E02EE0
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917E02E18
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917E02EC8
       call      qword ptr [7FF917657AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,2017BC00AD0
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C7D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C7D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,2017BC00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917D4F258]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C7D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C7CFC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,2017BC00AD0
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917D012B0
       call      qword ptr [7FF917C7D068]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C46270]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D4EDC0]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917E4AE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C7D320]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C7D320]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917E4AE94
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L49
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L80
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L50
M02_L02:
       test      rax,rax
       je        near ptr M02_L52
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L51
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L79
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L69
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L62
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L63
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L68
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L66
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L67
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917874808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L79
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0C8]
       test      r14,r14
       je        near ptr M02_L28
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L29
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L30
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L30
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L35
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L35
M02_L18:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r14d,r11d
       jae       near ptr M02_L100
       mov       r10d,r14d
       mov       r15,[r8+r10*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,r11d
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L19
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917350FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L20
M02_L19:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L20:
       inc       r14d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917E31EA8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917E32800
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917E32CA0
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917E338C8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917E33908
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917D13150
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917E33920
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF917E34068
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF917E0EEE8
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF917E0EF80
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L31:
       mov       rax,r15
       cmp       r12d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r12d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r13,r13
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L33
       mov       rcx,r13
       mov       rdx,r8
       mov       r11,7FF917350FB0
       call      qword ptr [r11]
M02_L32:
       test      eax,eax
       je        short M02_L34
M02_L33:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L34:
       inc       r14d
M02_L35:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L36
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r15,[rsi+8]
       mov       r8,r15
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r8+rax*8+10]
       mov       r13,rax
       lea       eax,[r14-1]
       mov       r12d,eax
       cmp       r12d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L31
       mov       rdx,7FF917E32CB0
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L31
M02_L36:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L37:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L43
       mov       rcx,rax
M02_L38:
       mov       rdx,rsi
       call      qword ptr [7FF917C7D248]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L44
M02_L39:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       jne       near ptr M02_L45
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M02_L40:
       mov       rdx,[rbp+10]
       cmp       r14,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [r14+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [r14+24],0
       jne       short M02_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C7D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C7D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M02_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L42:
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
M02_L43:
       mov       rdx,7FF917E32CF8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF917E32740
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L45:
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C7D278]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C7D278]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L48
M02_L46:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L47:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       mov       rdx,7FF917E312C8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF917350F98
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L52:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L53
       jmp       short M02_L54
M02_L53:
       mov       rcx,rsi
       mov       rdx,7FF917E32E40
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L54:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L57
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rsi
       mov       rdx,7FF917E33028
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L56:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L57:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917E32F60
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L59:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L60
       jmp       short M02_L61
M02_L60:
       mov       rcx,rsi
       mov       rdx,7FF917E33010
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L61:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L79
M02_L62:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L63:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FF917D6E238
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L65:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L66:
       mov       ecx,80B
       mov       rdx,7FF91771A018
       call      qword ptr [7FF917687738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D44AC8]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917D4F108]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177F5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L68:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L69:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FF917D6E238
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L71:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FF917E338D8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF917350FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917E338F0
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L77
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L74
M02_L77:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF9175AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF917350FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L79:
       mov       rax,[rbp+10]
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
M02_L80:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        short M02_L81
       jmp       short M02_L82
M02_L81:
       mov       rcx,rdx
       mov       rdx,7FF917E32CA0
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B74CF0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917AC6028]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91768C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L20
       jmp       near ptr M02_L19
M02_L85:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L86:
       test      r8,r8
       je        near ptr M02_L34
       jmp       near ptr M02_L33
M02_L87:
       call      qword ptr [7FF917D4E8C8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF917A15E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917D4E8F8]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       r8d,[rsi+10]
       sub       r8d,edi
       mov       [rsp+20],r8d
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF9179ACD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D4F180]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M02_L93:
       call      qword ptr [7FF917C74BD0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917D4F1F8]
       mov       rbx,rax
       jmp       near ptr M02_L42
M02_L99:
       mov       rbx,rdx
       jmp       near ptr M02_L42
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917350FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3290
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C7D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917E31EF8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917E323F8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917D4F258]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C7D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C7CFC0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CE6E18
       call      qword ptr [7FF917687738]
       mov       rcx,rax
       call      qword ptr [7FF917D4EC40]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917E31EA8
       call      qword ptr [7FF91740C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917E32800
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C7D068]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C465D0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D4EDC0]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917350FB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917E32E40
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917E33028
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917E32F60
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917E33010
       call      qword ptr [7FF917687AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,24D43402AC8
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C6D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C6D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,24D43402AC8
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917D3F288]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C6D170]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C6D110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,24D43402AC8
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917CF1978
       call      qword ptr [7FF917C6D1B8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C36500]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D3EDF0]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917E3B830
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C6D470]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C6D470]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917E3B834
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L52
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L29
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L53
M02_L02:
       test      rax,rax
       je        near ptr M02_L55
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L54
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L28
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
       mov       rcx,[rbp+10]
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L72
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L65
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L66
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L71
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L69
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L70
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917864808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L28
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0C8]
       test      r14,r14
       je        near ptr M02_L31
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L32
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L33
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L33
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L38
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L38
       jmp       short M02_L19
M02_L18:
       inc       r14d
M02_L19:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       edx,[r8+8]
       cmp       r14d,edx
       jae       near ptr M02_L100
       mov       r11d,r14d
       mov       r15,[r8+r11*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,edx
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L20
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917340FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L18
M02_L20:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rsi+8]
       mov       r10,rdx
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       r8d,r14d
       mov       r8,[r10+r8*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,rdx
       movsxd    rdx,edi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917E21E68
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917E227C0
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917E22C60
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917E23888
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917E238C8
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917D02EE0
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917E238E0
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rcx,[rbp+10]
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
M02_L29:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L82
M02_L30:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B64DE0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917AB6118]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF917E24028
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF917DFEEA8
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF917DFEF40
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L34:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r15,r15
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L36
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917340FB0
       call      qword ptr [r11]
M02_L35:
       test      eax,eax
       je        short M02_L37
M02_L36:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L37:
       inc       r14d
M02_L38:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       edx,r14d
       mov       r15,[r8+rdx*8+10]
       lea       edx,[r14-1]
       mov       r13d,edx
       cmp       r13d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L34
       mov       rdx,7FF917E22C70
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L34
M02_L39:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L40:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        short M02_L43
       mov       rcx,rax
M02_L41:
       mov       rdx,rsi
       call      qword ptr [7FF917C6D398]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        short M02_L44
M02_L42:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       jne       short M02_L45
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L48
M02_L43:
       mov       rdx,7FF917E22CB8
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L41
M02_L44:
       mov       rdx,7FF917E22700
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L42
M02_L45:
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C6D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C6D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L51
M02_L46:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L47:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M02_L48:
       mov       rdx,[rbp+10]
       cmp       rbx,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [rbx+24],0
       jne       short M02_L49
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C6D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C6D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M02_L49:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L50:
       mov       rax,rsi
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
M02_L51:
       mov       rcx,rdi
       mov       rdx,7FF917E21288
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L52:
       mov       ecx,885
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF917340F98
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L55:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L56
       jmp       short M02_L57
M02_L56:
       mov       rcx,rsi
       mov       rdx,7FF917E22E00
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L57:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L60
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917E22FE8
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L59:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L60:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L61
       jmp       short M02_L62
M02_L61:
       mov       rcx,rsi
       mov       rdx,7FF917E22F20
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L62:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L63
       jmp       short M02_L64
M02_L63:
       mov       rcx,rsi
       mov       rdx,7FF917E22FD0
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L64:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L28
M02_L65:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L66:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FF917D6E7C0
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L68:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L69:
       mov       ecx,80B
       mov       rdx,7FF91770A018
       call      qword ptr [7FF917677738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D34B10]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917D3F138]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177E5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L71:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L72:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FF917D6E7C0
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L74:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A8]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917E23898
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF917340FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B0]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FF917E238B0
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L79:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L80
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L77
M02_L80:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91759E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF917340FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF917E22C60
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91767C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L18
       jmp       near ptr M02_L20
M02_L85:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L35
M02_L86:
       test      r8,r8
       je        near ptr M02_L37
       jmp       near ptr M02_L36
M02_L87:
       call      qword ptr [7FF917D3E8F8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF917A05E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917D3E928]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       edx,[rsi+10]
       sub       edx,edi
       mov       [rsp+20],edx
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91799CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D3F1B0]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M02_L93:
       call      qword ptr [7FF917C64D08]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917D3F228]
       mov       rsi,rax
       jmp       near ptr M02_L50
M02_L99:
       mov       rsi,rdx
       jmp       near ptr M02_L50
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917340FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3271
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C6D440]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917E21EB8
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917E223B8
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917D3F288]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C6D170]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C6D110]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CD7630
       call      qword ptr [7FF917677738]
       mov       rcx,rax
       call      qword ptr [7FF917D3EC70]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917E21E68
       call      qword ptr [7FF9173FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917E227C0
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C6D1B8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C36860]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D3EDF0]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917340FB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917E22E00
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917E22FE8
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917E22F20
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917E22FD0
       call      qword ptr [7FF917677AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,20739802AC8
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,20739802AC8
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917D2F240]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C5CFD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C5CF78]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,20739802AC8
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917CE12B0
       call      qword ptr [7FF917C5D020]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C26360]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D2ED90]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917E29610
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D2D8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D2D8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917E29614
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L52
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L29
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L53
M02_L02:
       test      rax,rax
       je        near ptr M02_L55
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L54
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L28
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
       mov       rcx,[rbp+10]
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L72
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L65
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L66
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L71
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L69
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L70
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917854808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L28
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0C8]
       test      r14,r14
       je        near ptr M02_L31
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L32
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L33
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L33
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L38
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L38
       jmp       short M02_L19
M02_L18:
       inc       r14d
M02_L19:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r14d,r11d
       jae       near ptr M02_L100
       mov       r10d,r14d
       mov       r15,[r8+r10*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,r11d
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L20
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917330FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L18
M02_L20:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917E11750
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917E120A8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917E12548
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917E13170
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917E131B0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917CF3998
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917E131C8
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rcx,[rbp+10]
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
M02_L29:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L82
M02_L30:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B54C90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917AA5FC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF917E13910
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF917DEF150
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF917DEF1E8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L34:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r15,r15
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L36
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917330FB0
       call      qword ptr [r11]
M02_L35:
       test      eax,eax
       je        short M02_L37
M02_L36:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L37:
       inc       r14d
M02_L38:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       r15,[r8+rax*8+10]
       lea       eax,[r14-1]
       mov       r13d,eax
       cmp       r13d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L34
       mov       rdx,7FF917E12558
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L34
M02_L39:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L40:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L48
       mov       rcx,rax
M02_L41:
       mov       rdx,rsi
       call      qword ptr [7FF917C5D200]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L49
M02_L42:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       je        near ptr M02_L51
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C5D230]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C5D230]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L50
M02_L43:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L44:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M02_L45:
       mov       rdx,[rbp+10]
       cmp       rbx,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [rbx+24],0
       jne       short M02_L46
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C5D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M02_L46:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L47:
       mov       rax,rsi
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
M02_L48:
       mov       rdx,7FF917E125A0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FF917E11FE8
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FF917E10C50
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF917330F98
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L55:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L56
       jmp       short M02_L57
M02_L56:
       mov       rcx,rsi
       mov       rdx,7FF917E126E8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L57:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L60
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917E128D0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L59:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L60:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L61
       jmp       short M02_L62
M02_L61:
       mov       rcx,rsi
       mov       rdx,7FF917E12808
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L62:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L63
       jmp       short M02_L64
M02_L63:
       mov       rcx,rsi
       mov       rdx,7FF917E128B8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L64:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L28
M02_L65:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L66:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FF917D4EA68
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L68:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L69:
       mov       ecx,80B
       mov       rdx,7FF9176FA018
       call      qword ptr [7FF917667738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D24AB0]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917D2F0D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177D5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L71:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L72:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FF917D4EA68
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L74:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A8]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917E13180
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B0]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FF917E13198
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L79:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L80
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L77
M02_L80:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91758E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF917E12548
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91766C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L18
       jmp       near ptr M02_L20
M02_L85:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L35
M02_L86:
       test      r8,r8
       je        near ptr M02_L37
       jmp       near ptr M02_L36
M02_L87:
       call      qword ptr [7FF917D2E8B0]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF9179F5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917D2E8E0]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       r8d,[rsi+10]
       sub       r8d,edi
       mov       [rsp+20],r8d
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91798CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D2F150]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M02_L93:
       call      qword ptr [7FF917C54B70]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917D2F1C8]
       mov       rsi,rax
       jmp       near ptr M02_L47
M02_L99:
       mov       rsi,rdx
       jmp       near ptr M02_L47
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917330FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3296
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C5D2A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917E117A0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917E11CA0
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917D2F240]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C5CFD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C5CF78]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CC6E18
       call      qword ptr [7FF917667738]
       mov       rcx,rax
       call      qword ptr [7FF917D2EC10]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917E11750
       call      qword ptr [7FF9173EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917E120A8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C5D020]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917C266C0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D2ED90]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917330FB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917E126E8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917E128D0
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917E12808
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917E128B8
       call      qword ptr [7FF917667AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,2B745400AD0
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C2F030]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C2F030]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,2B745400AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917ED4858]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917C2ED30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917C2ECD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,2B745400AD0
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917CE7978
       call      qword ptr [7FF917C2ED78]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917E4A1B0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917ED4690]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917EE96E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C2F030]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C2F030]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917EE96EC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L52
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L29
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L53
M02_L02:
       test      rax,rax
       je        near ptr M02_L55
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L54
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L28
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
       mov       rcx,[rbp+10]
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L72
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L65
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L66
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L71
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L69
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L70
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917834808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L28
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0D8]
       test      r14,r14
       je        near ptr M02_L31
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L32
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L33
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L33
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L38
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L38
       jmp       short M02_L19
M02_L18:
       inc       r14d
M02_L19:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r14d,r11d
       jae       near ptr M02_L100
       mov       r10d,r14d
       mov       r15,[r8+r10*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,r11d
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L20
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917311308
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L18
M02_L20:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917EBB3D8
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917EBBD30
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917EBC1D0
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917EB31D8
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917EB3218
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917B63DB8
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917EB3230
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rcx,[rbp+10]
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
M02_L29:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L82
M02_L30:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B358D8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917A86118]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF917EBCB98
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF917EBA338
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF917EBA3D0
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L34:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r15,r15
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L36
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917311308
       call      qword ptr [r11]
M02_L35:
       test      eax,eax
       je        short M02_L37
M02_L36:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L37:
       inc       r14d
M02_L38:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       r15,[r8+rax*8+10]
       lea       eax,[r14-1]
       mov       r13d,eax
       cmp       r13d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L34
       mov       rdx,7FF917EBC1E0
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L34
M02_L39:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L40:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L48
       mov       rcx,rax
M02_L41:
       mov       rdx,rsi
       call      qword ptr [7FF917C2EF58]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L49
M02_L42:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       je        near ptr M02_L51
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917C2EF88]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917C2EF88]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L50
M02_L43:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L44:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M02_L45:
       mov       rdx,[rbp+10]
       cmp       rbx,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [rbx+24],0
       jne       short M02_L46
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C2F030]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917C2F030]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M02_L46:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L47:
       mov       rax,rsi
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
M02_L48:
       mov       rdx,7FF917EBC228
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FF917EBBC70
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FF917EB8E20
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF9173112F0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L55:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L56
       jmp       short M02_L57
M02_L56:
       mov       rcx,rsi
       mov       rdx,7FF917EBC370
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L57:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L60
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917EBC558
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L59:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L60:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L61
       jmp       short M02_L62
M02_L61:
       mov       rcx,rsi
       mov       rdx,7FF917EBC490
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L62:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L63
       jmp       short M02_L64
M02_L63:
       mov       rcx,rsi
       mov       rdx,7FF917EBC540
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L64:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L28
M02_L65:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L66:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FF917D50B88
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L68:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L69:
       mov       ecx,80B
       mov       rdx,7FF9176DA018
       call      qword ptr [7FF917647738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917D24390]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917ED46F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177B5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L71:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L72:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FF917D50B88
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L74:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917EB31E8
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF9173112F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FF917EB3200
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L79:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebx,[rsi+10]
       cmp       [rcx+8],ebx
       jbe       short M02_L80
       lea       edx,[rbx+1]
       mov       [rsi+10],edx
       mov       edx,ebx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L77
M02_L80:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91756E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF917311300
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF917EBC1D0
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91764C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L18
       jmp       near ptr M02_L20
M02_L85:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L35
M02_L86:
       test      r8,r8
       je        near ptr M02_L37
       jmp       near ptr M02_L36
M02_L87:
       call      qword ptr [7FF917ED44C8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF9179D5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917ED44F8]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       r8d,[rsi+10]
       sub       r8d,edi
       mov       [rsp+20],r8d
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91796CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917D2FB88]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M02_L93:
       call      qword ptr [7FF917C26A00]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917ED47C8]
       mov       rsi,rax
       jmp       near ptr M02_L47
M02_L99:
       mov       rsi,rdx
       jmp       near ptr M02_L47
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917311300
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3296
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917C2F000]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917EBB428
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917EBB928
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917ED4858]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917C2ED30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917C2ECD0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917CCD740
       call      qword ptr [7FF917647738]
       mov       rcx,rax
       call      qword ptr [7FF917ED40C0]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917EBB3D8
       call      qword ptr [7FF9173CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917EBBD30
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917C2ED78]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917E4A510]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917ED4690]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917311310
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917EBC370
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917EBC558
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917EBC490
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917EBC540
       call      qword ptr [7FF917647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       rcx,1C528000B78
       mov       rdi,[rcx]
       mov       rcx,[rsi]
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rcx,rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Builder
       cmp       rcx,rax
       jne       near ptr M00_L06
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       short M00_L02
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M00_L13
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917D269E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917D269E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M00_L00:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M00_L02:
       jmp       short M00_L05
M00_L03:
       mov       rcx,1C528000B78
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF917EF5428]
       mov       r15,rax
       jmp       short M00_L01
M00_L04:
       mov       rcx,rsi
M00_L05:
       mov       rdx,[rcx+10]
       cmp       rdx,[rdi+10]
       jne       short M00_L06
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M00_L11
       mov       rax,[rdi+8]
       cmp       qword ptr [rax+10],0
       je        short M00_L10
       mov       edx,[rdx+20]
       mov       rax,[rdi+8]
       cmp       edx,[rax+20]
       jg        short M00_L09
M00_L06:
       mov       r8,[rdi+8]
       cmp       qword ptr [r8+10],0
       jne       short M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917D266E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rdx,rdi
       call      qword ptr [7FF917D26688]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       rax,1C528000B78
       mov       rax,[rax]
       jmp       short M00_L08
M00_L13:
       mov       ecx,873
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF917E20B60
       call      qword ptr [7FF917D26730]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917DD5BF0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF917EF5278]
       jmp       near ptr M00_L08
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF917F39250
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917D269E8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917D269E8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF917F39254
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M02_L52
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L29
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L53
M02_L02:
       test      rax,rax
       je        near ptr M02_L55
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L54
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L28
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L23
       mov       rcx,[rbp+10]
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M02_L24
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L72
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        near ptr M02_L25
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L65
       mov       ebx,[rdi+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L66
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        near ptr M02_L26
       mov       rcx,rax
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        near ptr M02_L27
M02_L10:
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M02_L71
       mov       r15d,[rdi+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r15d
       test      r14d,r14d
       jl        near ptr M02_L69
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L70
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [r14+18],rcx
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF917844808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L28
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L88
       cmp       edi,1
       jle       near ptr M02_L17
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0D8]
       test      r14,r14
       je        near ptr M02_L31
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M02_L83
       cmp       [r15+8],edi
       jl        near ptr M02_L89
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L32
M02_L15:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L33
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L33
M02_L16:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L17:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L38
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L38
       jmp       short M02_L19
M02_L18:
       inc       r14d
M02_L19:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       rax,[rsi+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r14d,r11d
       jae       near ptr M02_L100
       mov       r10d,r14d
       mov       r15,[r8+r10*8+10]
       lea       ebx,[r14-1]
       cmp       ebx,ecx
       jae       near ptr M02_L93
       cmp       ebx,r11d
       jae       near ptr M02_L100
       mov       ecx,ebx
       mov       r8,[rax+rcx*8+10]
       test      r15,r15
       je        near ptr M02_L84
       test      r8,r8
       je        short M02_L20
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917321640
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L18
M02_L20:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
       jmp       near ptr M02_L18
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FF917F227B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF917F23110
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF917F235B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF917EE0DF0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF917EE0E30
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF917B272F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF917EE0E48
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rcx,[rbp+10]
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
M02_L29:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L82
M02_L30:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF917B4C798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917A96010]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF917F23F90
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF917F21718
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF917F217B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L16
M02_L34:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L85
       test      r15,r15
       je        near ptr M02_L86
       test      r8,r8
       je        short M02_L36
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF917321640
       call      qword ptr [r11]
M02_L35:
       test      eax,eax
       je        short M02_L37
M02_L36:
       lea       ecx,[rdi+1]
       mov       r15d,ecx
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       mov       r10,r8
       cmp       r14d,[r10+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       rax,[r10+rax*8+10]
       cmp       edi,ecx
       jae       near ptr M02_L93
       mov       rcx,r8
       movsxd    rdx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       mov       edi,r15d
M02_L37:
       inc       r14d
M02_L38:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L39
       cmp       r14d,ecx
       jae       near ptr M02_L93
       mov       r8,[rsi+8]
       cmp       r14d,[r8+8]
       jae       near ptr M02_L100
       mov       eax,r14d
       mov       r15,[r8+rax*8+10]
       lea       eax,[r14-1]
       mov       r13d,eax
       cmp       r13d,ecx
       jae       near ptr M02_L93
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+0C8]
       test      r11,r11
       jne       near ptr M02_L34
       mov       rdx,7FF917F235C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L34
M02_L39:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L87
       test      ebx,ebx
       jl        near ptr M02_L88
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L40:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L48
       mov       rcx,rax
M02_L41:
       mov       rdx,rsi
       call      qword ptr [7FF917D26910]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L49
M02_L42:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       je        near ptr M02_L51
       lea       r14d,[rsi-1]
       mov       r15d,r14d
       shr       r15d,1F
       add       r14d,r15d
       sar       r14d,1
       dec       esi
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FF917D26940]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF917D26940]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L50
M02_L43:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M02_L94
       cmp       esi,[rbx+10]
       jae       near ptr M02_L93
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,esi
       mov       r13,[rax+rcx*8+10]
M02_L44:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M02_L95
       test      r14,r14
       je        near ptr M02_L96
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        near ptr M02_L101
       cmp       ecx,0FF
       ja        near ptr M02_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M02_L45:
       mov       rdx,[rbp+10]
       cmp       rbx,[rdx+8]
       je        near ptr M02_L99
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L98
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M02_L97
       mov       rdx,[rbp+10]
       cmp       byte ptr [rbx+24],0
       jne       short M02_L46
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF917D269E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF917D269E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M02_L46:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L47:
       mov       rax,rsi
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
M02_L48:
       mov       rdx,7FF917F23610
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FF917F23050
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FF917F20710
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF917321628
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L55:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L56
       jmp       short M02_L57
M02_L56:
       mov       rcx,rsi
       mov       rdx,7FF917F23768
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L57:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L60
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF917F23950
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L59:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L60:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L61
       jmp       short M02_L62
M02_L61:
       mov       rcx,rsi
       mov       rdx,7FF917F23888
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L62:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L63
       jmp       short M02_L64
M02_L63:
       mov       rcx,rsi
       mov       rdx,7FF917F23938
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L64:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L28
M02_L65:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L66:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+70]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FF917B7F030
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L68:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L69:
       mov       ecx,80B
       mov       rdx,7FF9176EA018
       call      qword ptr [7FF917657738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF917B46CE8]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF917EF52D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9177C5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L71:
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L72:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+70]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FF917B7F030
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L74:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FF917EE0E00
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF917321630
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FF917EE0E18
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L79:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L80
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L77
M02_L80:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF91757E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF917321638
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF917F235B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF91765C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L18
       jmp       near ptr M02_L20
M02_L85:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L35
M02_L86:
       test      r8,r8
       je        near ptr M02_L37
       jmp       near ptr M02_L36
M02_L87:
       call      qword ptr [7FF917EF50C8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF9179E5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF917C54858]
       int       3
M02_L90:
       sub       [rsi+10],ebx
       cmp       edi,[rsi+10]
       jge       short M02_L91
       mov       r8d,[rsi+10]
       sub       r8d,edi
       mov       [rsp+20],r8d
       lea       edx,[rdi+rbx]
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       mov       r9d,edi
       call      qword ptr [7FF91797CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF917EF4120]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M02_L93:
       call      qword ptr [7FF917B478D0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF917EF53B0]
       mov       rsi,rax
       jmp       near ptr M02_L47
M02_L99:
       mov       rsi,rdx
       jmp       near ptr M02_L47
M02_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M02_L102
       mov       rcx,[rbp-58]
       mov       r11,7FF917321638
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3264
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M03_L05
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L06
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L07
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FF917D269B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF917F22808
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF917F22D08
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF917EF5428]
       mov       r15,rax
       jmp       short M03_L03
M03_L08:
       mov       rcx,rbx
M03_L09:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M03_L10
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L15
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L14
       mov       edx,[rdx+20]
       mov       rax,[rsi+8]
       cmp       edx,[rax+20]
       jg        short M03_L13
M03_L10:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       short M03_L17
M03_L11:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917D266E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FF917D26688]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF917D768D8
       call      qword ptr [7FF917657738]
       mov       rcx,rax
       call      qword ptr [7FF917EF4CC0]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FF917F227B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF917F23110
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF917D26730]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF917DD5F50]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF917EF5278]
       jmp       near ptr M03_L12
; Total bytes of code 524
```
```assembly
; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M04_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M04_L03
M04_L00:
       test      rcx,rcx
       je        short M04_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M04_L04
       mov       ebx,[rcx+20]
M04_L01:
       mov       [rdi],ebx
M04_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       r11,7FF917321648
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L01
M04_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       rdx,7FF917F23768
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbx
       mov       rdx,7FF917F23950
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L11
       jmp       short M04_L12
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF917F23888
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rbx
       mov       rdx,7FF917F23938
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M04_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M04_L02
M04_L15:
       xor       eax,eax
       mov       [rdi],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 339
```

