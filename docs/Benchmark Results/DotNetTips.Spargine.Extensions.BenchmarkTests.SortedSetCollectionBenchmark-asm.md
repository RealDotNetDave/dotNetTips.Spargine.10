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
       mov       rax,1D100002AC8
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
       call      qword ptr [7FFA2EAAD1B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2010D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EAAD1B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2010D8
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
       mov       rdx,1D100002AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D100002AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFA2E2BF480]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4982E0
       call      qword ptr [7FFA2E2BF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EBE4870]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EBEE5C8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2010C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FFA2E2010E0
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
       mov       r11,7FFA2E2010E0
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
       call      qword ptr [7FFA2EBEE6B8]
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
       call      qword ptr [7FFA2EBEE6A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E697900]
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
       call      qword ptr [7FFA2EAAD188]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EBE54B8]
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
       mov       rax,1CDD2C00AD0
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
       call      qword ptr [7FFA2EABCBB8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2210D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EABCBB8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2210D8
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
       mov       rdx,1CDD2C00AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CDD2C00AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFA2E2DF480]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EC04828]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EC0E598]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2210C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FFA2E2210E0
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
       mov       r11,7FFA2E2210E0
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
       call      qword ptr [7FFA2EC0E688]
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
       call      qword ptr [7FFA2EC0E670]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E6B7900]
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
       call      qword ptr [7FFA2EABCB88]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EC05470]
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
       mov       rax,1C3DE400AD0
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
       call      qword ptr [7FFA2EB3D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2110D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EB3D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2110D8
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
       mov       rdx,1C3DE400AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C3DE400AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFA2E2CF480]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4A82E0
       call      qword ptr [7FFA2E2CF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EBF48B8]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EBFE5F8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FFA2E2110E0
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
       mov       r11,7FFA2E2110E0
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
       call      qword ptr [7FFA2EBFE6E8]
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
       call      qword ptr [7FFA2EBFE6D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E6B7930]
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
       call      qword ptr [7FFA2EB3D0F8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EBF54E8]
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
       mov       rax,2120F400AD0
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
       call      qword ptr [7FFA2EB1CCD8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2010D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EB1CCD8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2010D8
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
       mov       rdx,2120F400AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2120F400AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFA2E2BF480]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4982E0
       call      qword ptr [7FFA2E2BF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EBE4858]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EBEE5C8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2010C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FFA2E2010E0
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
       mov       r11,7FFA2E2010E0
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
       call      qword ptr [7FFA2EBEE6B8]
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
       call      qword ptr [7FFA2EBEE6A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E697900]
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
       call      qword ptr [7FFA2EB1CCA8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EBE54A0]
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
       mov       rax,24CFA400AD0
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
       call      qword ptr [7FFA2EADD1A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2310D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EADD1A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2310D8
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
       mov       rdx,24CFA400AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24CFA400AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFA2E2EF480]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EC14858]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EC1E5B0]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2310C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FFA2E2310E0
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
       mov       r11,7FFA2E2310E0
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
       call      qword ptr [7FFA2EC1E6A0]
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
       call      qword ptr [7FFA2EC1E688]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E6D7930]
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
       call      qword ptr [7FFA2EC1E5B0]
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
       call      qword ptr [7FFA2EC15488]
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
       mov       rax,20C1CC00AD0
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
       call      qword ptr [7FFA2EB3D200]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2110D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EB3D200]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2110D8
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
       mov       rdx,20C1CC00AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20C1CC00AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFA2E2CF480]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4A82E0
       call      qword ptr [7FFA2E2CF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EBF48B8]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EBFE5F8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FFA2E2110E0
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
       mov       r11,7FFA2E2110E0
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
       call      qword ptr [7FFA2EBFE6E8]
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
       call      qword ptr [7FFA2EBFE6D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E6B7930]
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
       call      qword ptr [7FFA2EB3D1D0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EBF54E8]
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
       mov       rax,2AB2C400AD0
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
       call      qword ptr [7FFA2EB3ED00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E2213D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EB3ED00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E2213D8
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
       call      qword ptr [7FFA2E2DF480]
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
       mov       rdx,2AB2C400AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AB2C400AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EC048D0]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EC0FBA0]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E2213C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L35:
       mov       r11,7FFA2E2213E0
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
       mov       r11,7FFA2E2213E0
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
       call      qword ptr [7FFA2EC0FCC0]
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
       call      qword ptr [7FFA2EC0FCA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E6B7900]
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
       call      qword ptr [7FFA2EB3ECD0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EC05518]
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
       mov       rax,292EA400B78
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
       call      qword ptr [7FFA2EC26748]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA2E221770
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA2EC26748]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA2E221778
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
       call      qword ptr [7FFA2E2DF480]
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
       mov       rdx,292EA400B70
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,292EA400B78
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       mov       ecx,783
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA2EA46C88]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFA2EDE4870]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA2E221768
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L35:
       mov       r11,7FFA2E221780
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
       mov       r11,7FFA2E221780
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
       call      qword ptr [7FFA2EDE4960]
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
       call      qword ptr [7FFA2EDE4948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA2E6B7900]
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
       call      qword ptr [7FFA2EC26718]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA2EA47990]
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
       mov       r8,1F69E000AC8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB278C0]
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
       call      qword ptr [7FFA2EC2F168]
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
       mov       r11,7FFA2E230FC0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC2EF10]
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
       call      qword ptr [7FFA2EC2EF10]
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
       call      qword ptr [7FFA2EB5D488]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EB5D4A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EB5D290]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EBE3E48
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D500]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E230FB0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC24BD0]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EC2EEB0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6D5AE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC24BD0]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EC2EB68]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EC2EB68]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EC2EB98]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E230FB8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F69E000C28
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1F69E000AC8
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EB5D278]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EB5FAC8]
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
       jmp       qword ptr [7FFA2E4F6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
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
       call      qword ptr [7FFA2EB5D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EC2EE68]
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
       mov       r14,[rax+70]
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
       mov       rdi,[rax+78]
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
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
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
       mov       r11,7FFA2E230FD8
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
       mov       rdx,7FFA2ED11E50
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFA2EBF1710
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFA2ECEFAC0
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFA2ED11E90
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFA2ED12600
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFA2ED12620
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFA2ED12708
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFA2ECED640
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFA2ECED6D8
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA2E230FD8
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
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M05_L29
       mov       rcx,rdx
       mov       rdx,7FFA2ED11EB0
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M05_L41
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFA2EB5D3E0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
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
       call      qword ptr [7FFA2EB5D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2ED12088
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFA2ED120A8
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2EB5D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EB5D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFA2ECEEBC8
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E8F5E00]
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
       mov       rdx,7FFA2EC8E478
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC2F1F8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EBCEE28]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E230FC8
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
       mov       rdx,7FFA2ECEFAE8
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E230FD0
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
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFA2EC2F030]
       int       3
M05_L67:
       call      qword ptr [7FFA2E4FF1B0]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2E8FE0D0]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFA2E77C780]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2EFD38]
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
       call      qword ptr [7FFA2EC2E9B8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8F5E00]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EC2E9E8]
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
       call      qword ptr [7FFA2E88CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EC2EDC0]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M05_L81:
       call      qword ptr [7FFA2EB54C48]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EBCAEC8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAF0]
       int       3
M05_L86:
       call      qword ptr [7FFA2EC2EE68]
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
       mov       r11,7FFA2E230FD0
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
       jmp       qword ptr [7FFA2E2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB23150]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2ED22848
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2ED2284C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EB5D290]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2ED22850
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EC2EF28]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,1C0C8800AC8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB47000]
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
       call      qword ptr [7FFA2EC2F0D8]
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
       mov       r11,7FFA2E230FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC2EDC0]
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
       call      qword ptr [7FFA2EC2EDC0]
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
       call      qword ptr [7FFA2EADD3E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EADD3F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EADD1E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EBE3EA0
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EADD458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E230FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC24B40]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EC2ED48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6D5AE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC24B40]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EC2EA78]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EC2EA78]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EC2EAA8]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E230FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C0C8800C28
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1C0C8800AC8
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EADD1D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EADFA38]
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
       jmp       qword ptr [7FFA2E4F6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
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
       call      qword ptr [7FFA2EADD440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EADD440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EC2EDD8]
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
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
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
       mov       r11,7FFA2E230FC8
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
       mov       rdx,7FFA2ED10E30
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFA2EBF17B8
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFA2ED11158
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10E70
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFA2ED117D8
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFA2ED117F8
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFA2ED118E0
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFA2ECED7B0
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFA2ECED848
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA2E230FC8
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
       mov       rdx,7FFA2ED10E90
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L43
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFA2EADD338]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L44
M05_L37:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L46
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
       call      qword ptr [7FFA2EADD398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EADD398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L45
M05_L38:
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
M05_L39:
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
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
M05_L40:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M05_L85
       cmp       byte ptr [rbx+24],0
       jne       short M05_L41
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EADD440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EADD440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L41:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L42:
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
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10F78
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10F98
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FFA2ECEF180
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L40
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
       call      qword ptr [7FFA2E8F5E00]
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
       mov       rdx,7FFA2EC5D270
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC2F168]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EBCEFF8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E230FB8
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
       mov       rdx,7FFA2ED11180
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E230FC0
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
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFA2EC2EF10]
       int       3
M05_L67:
       call      qword ptr [7FFA2E4FF1B0]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2E8FE0D0]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFA2E77C780]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2EFD38]
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
       call      qword ptr [7FFA2EC2E958]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8F5E00]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EC2E988]
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
       call      qword ptr [7FFA2E88CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EC2EF88]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M05_L81:
       call      qword ptr [7FFA2EAD4BE8]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EBCB098
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EAD8]
       int       3
M05_L86:
       call      qword ptr [7FFA2EC2EDD8]
       mov       rsi,rax
       jmp       near ptr M05_L42
M05_L87:
       mov       rsi,rcx
       jmp       near ptr M05_L42
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
       mov       r11,7FFA2E230FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2799
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
       jmp       qword ptr [7FFA2E2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB42BD0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2ED20B50
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2ED20B54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EADD1E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2ED20B58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EC2EDF0]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,20176400AC8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB16FE0]
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
       call      qword ptr [7FFA2EC0F138]
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
       mov       r11,7FFA2E210FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC0EE20]
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
       call      qword ptr [7FFA2EC0EE20]
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
       call      qword ptr [7FFA2EAACE88]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EAACEA0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EAACC90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EB9A2B0
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EAACF00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E210FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4A82E0
       call      qword ptr [7FFA2E2CF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC04BB8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EC0EDA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6B5AE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4A82E0
       call      qword ptr [7FFA2E2CF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC04BB8]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EC0EAD8]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EC0EAD8]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EC0EB08]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E210FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20176400C28
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,20176400AC8
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EAACC78]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EAAFB10]
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
       jmp       qword ptr [7FFA2E4D6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
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
       call      qword ptr [7FFA2EAACEE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EAACEE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EC0EE38]
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
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
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
       mov       r11,7FFA2E210FC8
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
       mov       rdx,7FFA2ECDFA48
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFA2EBCBA80
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFA2ECDFD70
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFA2ECDFA88
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFA2ED103F0
       call      qword ptr [7FFA2E2CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10410
       call      qword ptr [7FFA2E2CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFA2ED104F8
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFA2ECDC448
       call      qword ptr [7FFA2E2CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFA2ECDC4E0
       call      qword ptr [7FFA2E2CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA2E210FC8
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
       mov       rdx,7FFA2ECDFAA8
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L43
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFA2EAACDE0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L44
M05_L37:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L46
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
       call      qword ptr [7FFA2EAACE40]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EAACE40]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L45
M05_L38:
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
M05_L39:
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
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
M05_L40:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M05_L85
       cmp       byte ptr [rbx+24],0
       jne       short M05_L41
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EAACEE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EAACEE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L41:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L42:
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
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFA2ECDFB90
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFA2ECDFBB0
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FFA2ECDDE18
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L40
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
       call      qword ptr [7FFA2E8D5E00]
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
       mov       rdx,7FFA2EC631A0
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2C71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC0F1C8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EB95428]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E210FB8
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
       mov       rdx,7FFA2ECDFD98
       call      qword ptr [7FFA2E2CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2C71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E210FC0
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
       call      qword ptr [7FFA2E2C71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFA2EC0EF70]
       int       3
M05_L67:
       call      qword ptr [7FFA2E4DF1B0]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2E8DE0E8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFA2E75C780]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2CFD38]
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
       call      qword ptr [7FFA2EC0E9B8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8D5E00]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EC0E9E8]
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
       call      qword ptr [7FFA2E86CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EC0EFE8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M05_L81:
       call      qword ptr [7FFA2EAA4708]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EB914C8
       call      qword ptr [7FFA2E2CF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC0EB38]
       int       3
M05_L86:
       call      qword ptr [7FFA2EC0EE38]
       mov       rsi,rax
       jmp       near ptr M05_L42
M05_L87:
       mov       rsi,rcx
       jmp       near ptr M05_L42
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
       mov       r11,7FFA2E210FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2806
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
       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB127D0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2ED02AD0
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2ED02AD4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EAACC90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2ED02AD8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EC0EE50]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,269CC802AC0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB370C0]
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
       call      qword ptr [7FFA2EC1F138]
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
       mov       r11,7FFA2E220FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC1EE20]
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
       call      qword ptr [7FFA2EC1EE20]
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
       call      qword ptr [7FFA2EACD338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EACD350]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EACD140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EBBF520
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EACD3B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E220FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC14B88]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EC1EDA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6B5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC14B88]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EC1EAD8]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EC1EAD8]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EC1EB08]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E220FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,269CC802C20
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,269CC802AC0
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EACD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EACFA80]
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
       jmp       qword ptr [7FFA2E4E6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
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
       call      qword ptr [7FFA2EACD398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EACD398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EC1EE38]
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
       je        near ptr M05_L48
M05_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L11
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L49
       test      r13d,r13d
       je        near ptr M05_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L12
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
       je        near ptr M05_L13
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L53
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L14
M05_L06:
       test      esi,esi
       je        near ptr M05_L19
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L63
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L15
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L66
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L16
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L67
       cmp       [rdi+8],r13d
       jb        near ptr M05_L68
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
       ja        near ptr M05_L17
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
       je        near ptr M05_L18
       jmp       near ptr M05_L69
M05_L11:
       mov       rcx,rdx
       mov       rdx,7FFA2ED01FC0
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L12:
       mov       rdx,7FFA2EBE6CE8
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L13:
       mov       rdx,7FFA2ED022E8
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,rdx
       mov       rdx,7FFA2ED02000
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L15:
       mov       rcx,rdi
       mov       rdx,7FFA2ED02960
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L16:
       mov       rcx,rdx
       mov       rdx,7FFA2ED02980
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L17:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2EA4CC30]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L18:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L19:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L23
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L27
M05_L20:
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
M05_L21:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L29
M05_L22:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L23:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L34
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M05_L34
       jmp       short M05_L25
M05_L24:
       inc       edi
M05_L25:
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jge       near ptr M05_L35
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
       je        short M05_L26
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E220FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L24
M05_L26:
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
       jmp       near ptr M05_L24
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFA2ED02A68
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L20
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFA2ECDE8D0
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFA2ECDE968
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L22
M05_L30:
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
       je        short M05_L32
       mov       rcx,r13
       mov       rdx,r8
       mov       r11,7FFA2E220FC8
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
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jge       short M05_L35
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
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFA2ED02020
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2EACD290]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA2EACD398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EACD398]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2ED02108
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFA2ED02128
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2EACD2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EACD2F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFA2ED00D10
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
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
M05_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA2E8E5DD0]
       int       3
M05_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L51
       jmp       short M05_L52
M05_L51:
       mov       rdx,7FFA2EC3D808
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L55
M05_L54:
       mov       edx,4
M05_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFA2E2D71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC1F1C8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EBBA698]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E220FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L59
       jmp       short M05_L60
M05_L59:
       mov       rcx,r14
       mov       rdx,7FFA2ED02310
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L61
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L58
M05_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA2E2D71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E220FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L65
M05_L64:
       mov       eax,4
M05_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFA2E2D71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FFA2EC1EF70]
       int       3
M05_L68:
       call      qword ptr [7FFA2E4EF1B0]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L18
M05_L70:
       call      qword ptr [7FFA2E76C750]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2DFD38]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L24
       jmp       near ptr M05_L26
M05_L73:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L74:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L75:
       call      qword ptr [7FFA2EC1E9B8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8E5DD0]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EC1E9E8]
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
       call      qword ptr [7FFA2E86CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EC1EFE8]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M05_L81:
       call      qword ptr [7FFA2EAC4BB8]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EBB6738
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC1ED30]
       int       3
M05_L86:
       call      qword ptr [7FFA2EC1EE38]
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
       mov       r11,7FFA2E220FC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2807
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
       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB32D70]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2ED10B50
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2ED10B54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EACD140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2ED10B58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EC1EE50]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,1F7C4400AC8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB26EA0]
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
       call      qword ptr [7FFA2EC2F138]
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
       mov       r11,7FFA2E230FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC2EE08]
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
       call      qword ptr [7FFA2EC2EE08]
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
       call      qword ptr [7FFA2EB5D410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EB5D428]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EB5D218]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EBE3EA0
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D488]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E230FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC24B88]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EC2ED90]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6C5AB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC24B88]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EC2E8B0]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EC2E8B0]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EC2E8E0]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E230FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F7C4400C28
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1F7C4400AC8
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EB5D200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EB5FA80]
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
       jmp       qword ptr [7FFA2E4F6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
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
       call      qword ptr [7FFA2EB5D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EC2EE20]
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
       je        near ptr M05_L11
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L12
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L49
       test      r13d,r13d
       je        near ptr M05_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L13
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
       je        near ptr M05_L14
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L53
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L15
M05_L06:
       test      esi,esi
       je        near ptr M05_L20
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L63
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L16
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L66
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L17
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L67
       cmp       [rdi+8],r13d
       jb        near ptr M05_L68
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
       ja        near ptr M05_L18
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
       je        near ptr M05_L19
       jmp       near ptr M05_L69
M05_L11:
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
M05_L12:
       mov       rcx,rdx
       mov       rdx,7FFA2ED106F8
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L13:
       mov       rdx,7FFA2EC05E08
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L14:
       mov       rdx,7FFA2ED10A20
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10738
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L16:
       mov       rcx,rdi
       mov       rdx,7FFA2ED110A0
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L17:
       mov       rcx,rdx
       mov       rdx,7FFA2ED110C0
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L18:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2EA5CC48]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L19:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L20:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L24
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L28
M05_L21:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L29
M05_L22:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L30
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L30
M05_L23:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L24:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L35
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L35
       jmp       short M05_L26
M05_L25:
       inc       edi
M05_L26:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L36
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
       je        short M05_L27
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E230FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L25
M05_L27:
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
       jmp       near ptr M05_L25
M05_L28:
       mov       rcx,r14
       mov       rdx,7FFA2ED111A8
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFA2ECEEEC8
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L22
M05_L30:
       mov       rcx,rdi
       mov       rdx,7FFA2ECEEF60
       call      qword ptr [7FFA2E2EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L23
M05_L31:
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
       je        short M05_L33
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E230FC8
       call      qword ptr [r11]
M05_L32:
       test      eax,eax
       je        short M05_L34
M05_L33:
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
M05_L34:
       inc       edi
M05_L35:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L36
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
       jne       near ptr M05_L31
       mov       rcx,rdx
       mov       rdx,7FFA2ED10758
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L31
M05_L36:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L37:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L43
M05_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFA2EB5D368]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L44
M05_L39:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L45
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L40:
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
       jne       short M05_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB5D470]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L42:
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
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10840
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L38
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFA2ED10860
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L39
M05_L45:
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
       call      qword ptr [7FFA2EB5D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EB5D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L48
M05_L46:
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
M05_L47:
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
       jmp       near ptr M05_L40
M05_L48:
       mov       rcx,rsi
       mov       rdx,7FFA2ECEE740
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L46
M05_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA2E8F5DD0]
       int       3
M05_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L51
       jmp       short M05_L52
M05_L51:
       mov       rdx,7FFA2EC5CF68
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L55
M05_L54:
       mov       edx,4
M05_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC2F1C8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EBCF008]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E230FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L59
       jmp       short M05_L60
M05_L59:
       mov       rcx,r14
       mov       rdx,7FFA2ED10A48
       call      qword ptr [7FFA2E2EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L61
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L58
M05_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA2E2E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E230FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L65
M05_L64:
       mov       eax,4
M05_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FFA2EC2EF58]
       int       3
M05_L68:
       call      qword ptr [7FFA2E4FF1B0]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L19
M05_L70:
       call      qword ptr [7FFA2E77C750]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2EFD38]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L25
       jmp       near ptr M05_L27
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L32
M05_L74:
       test      r8,r8
       je        near ptr M05_L34
       jmp       near ptr M05_L33
M05_L75:
       call      qword ptr [7FFA2EC2ECD0]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8F5DD0]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EC2ED00]
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
       call      qword ptr [7FFA2E87CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EC2EFD0]
       jmp       near ptr M05_L37
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M05_L81:
       call      qword ptr [7FFA2EB54BD0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L47
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EBCB0A8
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EC2EB98]
       int       3
M05_L86:
       call      qword ptr [7FFA2EC2EE20]
       mov       rbx,rax
       jmp       near ptr M05_L42
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L42
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
       mov       r11,7FFA2E230FC0
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
       jmp       qword ptr [7FFA2E2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2EB21BD0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2ED0EC60
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2ED0EC64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EB5D218]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2ED0EC68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EC2EE38]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,1F700400AC8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2EAF6CA0]
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
       call      qword ptr [7FFA2EBFF168]
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
       mov       r11,7FFA2E200FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EBFEF10]
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
       call      qword ptr [7FFA2EBFEF10]
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
       call      qword ptr [7FFA2EB2D488]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EB2D4A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EB2D290]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EBB52C8
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2D500]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E200FA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4982E0
       call      qword ptr [7FFA2E2BF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EBF4BD0]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EBFEEB0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6A5AE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4982E0
       call      qword ptr [7FFA2E2BF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EBF4BD0]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EBFE958]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EBFE958]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EBFE988]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E200FA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F700400C28
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1F700400AC8
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EB2D278]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EB2FB10]
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
       jmp       qword ptr [7FFA2E4C6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
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
       call      qword ptr [7FFA2EB2D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EBFEE68]
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
       je        near ptr M05_L11
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+70]
       test      r14,r14
       je        near ptr M05_L12
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L49
       test      r13d,r13d
       je        near ptr M05_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M05_L13
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
       je        near ptr M05_L14
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L53
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+78]
       test      rdi,rdi
       je        near ptr M05_L15
M05_L06:
       test      esi,esi
       je        near ptr M05_L20
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L63
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L16
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L66
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L17
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L67
       cmp       [rdi+8],r13d
       jb        near ptr M05_L68
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
       ja        near ptr M05_L18
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
       je        near ptr M05_L19
       jmp       near ptr M05_L69
M05_L11:
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
M05_L12:
       mov       rcx,rdx
       mov       rdx,7FFA2ECE1790
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L13:
       mov       rdx,7FFA2EBD5B28
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L14:
       mov       rdx,7FFA2ECE1B90
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,rdx
       mov       rdx,7FFA2ECE17D0
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L16:
       mov       rcx,rdi
       mov       rdx,7FFA2ECE2210
       call      qword ptr [7FFA2E2BF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L17:
       mov       rcx,rdx
       mov       rdx,7FFA2ECE2230
       call      qword ptr [7FFA2E2BF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L18:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2EA2CCC0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L19:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L20:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L76
       cmp       esi,1
       jle       near ptr M05_L24
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D0]
       test      rdi,rdi
       je        near ptr M05_L28
M05_L21:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M05_L71
       cmp       [r14+8],esi
       jl        near ptr M05_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L29
M05_L22:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L30
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L30
M05_L23:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L24:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L35
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L35
       jmp       short M05_L26
M05_L25:
       inc       edi
M05_L26:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L36
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
       je        short M05_L27
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E200FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L25
M05_L27:
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
       jmp       near ptr M05_L25
M05_L28:
       mov       rcx,r14
       mov       rdx,7FFA2ECE2318
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFA2ECBEE58
       call      qword ptr [7FFA2E2BF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L22
M05_L30:
       mov       rcx,rdi
       mov       rdx,7FFA2ECBEEF0
       call      qword ptr [7FFA2E2BF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L23
M05_L31:
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
       je        short M05_L33
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E200FC8
       call      qword ptr [r11]
M05_L32:
       test      eax,eax
       je        short M05_L34
M05_L33:
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
M05_L34:
       inc       edi
M05_L35:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L36
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
       jne       near ptr M05_L31
       mov       rcx,rdx
       mov       rdx,7FFA2ECE17F0
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L31
M05_L36:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L75
       test      ebx,ebx
       jl        near ptr M05_L76
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L37:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M05_L45
M05_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFA2EB2D3E0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M05_L46
M05_L39:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L48
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
       call      qword ptr [7FFA2EB2D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EB2D440]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L40:
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
M05_L41:
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
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
M05_L42:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M05_L85
       cmp       byte ptr [rbx+24],0
       jne       short M05_L43
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2D4E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L43:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L44:
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
M05_L45:
       mov       rcx,rdx
       mov       rdx,7FFA2ECE19C8
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rdx
       mov       rdx,7FFA2ECE19E8
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FFA2ECBD898
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L40
M05_L48:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L42
M05_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA2E8C5E00]
       int       3
M05_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M05_L51
       jmp       short M05_L52
M05_L51:
       mov       rdx,7FFA2EC2CCF8
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L55
M05_L54:
       mov       edx,4
M05_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFA2E2B71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EBFF1F8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EBB0440]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E200FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L59
       jmp       short M05_L60
M05_L59:
       mov       rcx,r14
       mov       rdx,7FFA2ECE1BB8
       call      qword ptr [7FFA2E2BF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L61
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L58
M05_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA2E2B71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E200FC0
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L65
M05_L64:
       mov       eax,4
M05_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFA2E2B71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FFA2EBFF030]
       int       3
M05_L68:
       call      qword ptr [7FFA2E4CF1B0]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L19
M05_L70:
       call      qword ptr [7FFA2E74C780]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2BFD38]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L25
       jmp       near ptr M05_L27
M05_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L32
M05_L74:
       test      r8,r8
       je        near ptr M05_L34
       jmp       near ptr M05_L33
M05_L75:
       call      qword ptr [7FFA2EBFECE8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8C5E00]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EBFED18]
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
       call      qword ptr [7FFA2E85CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EBFEDC0]
       jmp       near ptr M05_L37
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M05_L81:
       call      qword ptr [7FFA2EB24D80]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L41
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EB9C360
       call      qword ptr [7FFA2E2BF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EBFE8E0]
       int       3
M05_L86:
       call      qword ptr [7FFA2EBFEE68]
       mov       rsi,rax
       jmp       near ptr M05_L44
M05_L87:
       mov       rsi,rcx
       jmp       near ptr M05_L44
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
       mov       r11,7FFA2E200FC0
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
       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2EAF1B70]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2ECF1BF0
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2ECF1BF4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EB2D290]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2ECF1BF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EBFEF28]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,1BD10400AC8
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L30
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2ED4C540]
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
       call      qword ptr [7FFA2EDD46F0]
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
       mov       r11,7FFA2E221228
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EDD43D8]
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
       call      qword ptr [7FFA2EDD43D8]
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
       call      qword ptr [7FFA2EB2E0A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EB2E0B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L31
M00_L30:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EB2DEA8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L31:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2EBD52C8
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2E118]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E221218
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC14C00]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EDD4360]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6C5AE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFA2E4B82E0
       call      qword ptr [7FFA2E2DF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EC14C00]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EC1FE70]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EC1FE70]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EC1FEA0]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E221220
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BD10400C50
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1BD10400AC8
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EB2DE90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       call      qword ptr [7FFA2EB2F378]
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
       jmp       qword ptr [7FFA2E4E6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
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
       call      qword ptr [7FFA2EB2E100]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2E100]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EDD43F0]
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
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
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
       mov       r11,7FFA2E221240
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
       mov       rdx,7FFA2ED3AB98
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFA2EBCF860
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFA2ED31108
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFA2ED3ABD8
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFA2ED3B270
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFA2ED3B290
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFA2ED3B440
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFA2ED39390
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFA2ED39428
       call      qword ptr [7FFA2E2DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA2E221240
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
       mov       rdx,7FFA2ED3ABF8
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2EB2DFF8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA2EB2E100]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EB2E100]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2ED3ACE0
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFA2ED3AD00
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2EB2E058]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EB2E058]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFA2ED38A10
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA2E8E5E00]
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
       mov       rdx,7FFA2EC47B08
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2D71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EDD4768]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EBD0440]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E221230
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
       mov       rdx,7FFA2ED31130
       call      qword ptr [7FFA2E2DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA2E2D71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E221238
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
       call      qword ptr [7FFA2E2D71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFA2EDD4528]
       int       3
M05_L67:
       call      qword ptr [7FFA2E4EFA98]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2E8EE0D0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFA2E76C780]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFA2E2DFD38]
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
       call      qword ptr [7FFA2EDD42A0]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8E5E00]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFA2EDD42D0]
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
       call      qword ptr [7FFA2E87CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EC1FC00]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M05_L81:
       call      qword ptr [7FFA2EB25980]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EBBC280
       call      qword ptr [7FFA2E2DF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EDD4138]
       int       3
M05_L86:
       call      qword ptr [7FFA2EDD43F0]
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
       mov       r11,7FFA2E221238
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
       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2ED473D0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2EDCB520
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2EDCB524
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EB2DEA8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2EDCB528
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EDD4408]
; Total bytes of code 142
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EA56CE8]
       int       3
M00_L07:
       mov       ecx,80B
       mov       rdx,7FFA2E4C82E0
       call      qword ptr [7FFA2E2EF210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA2EA56CE8]
       int       3
M00_L08:
       test      rdi,rdi
       je        near ptr M00_L42
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L09:
       mov       r8,1F71E000B70
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L32
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA2ED05BF8]
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
       call      qword ptr [7FFA2EE05248]
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
       mov       r11,7FFA2E231588
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L22
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EE04F78]
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
       call      qword ptr [7FFA2EE04F78]
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
       call      qword ptr [7FFA2EC36970]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFA2EC36988]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L33
M00_L32:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFA2EC36778]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L33:
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,7FFA2ECA1F58
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC369E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA2E231578
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA2EE04F00]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA2E6D5AE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFA2EE04A68]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA2EE04A68]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFA2EE04A98]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFA2E231580
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F71E000C88
       mov       rdi,[rcx]
       jmp       near ptr M00_L08
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L09
M00_L43:
       mov       ecx,873
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M00_L44:
       mov       ecx,847
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M00_L45:
       mov       ecx,851
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M00_L46:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       [rsp+50],edx
       lea       rdx,[rsp+48]
       mov       rcx,1F71E000B70
       mov       rcx,[rcx]
       call      qword ptr [7FFA2EC36760]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
       jmp       near ptr 00007FFA8DF07B10
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFA2EA557A0]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFA2E4F6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
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
       call      qword ptr [7FFA2EC369D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC369D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M04_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA2EE04F90]
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
       je        near ptr M05_L14
M05_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M05_L15
M05_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M05_L50
       test      r13d,r13d
       je        near ptr M05_L51
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        near ptr M05_L16
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
       je        near ptr M05_L17
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L58
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L54
M05_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M05_L18
M05_L06:
       test      esi,esi
       je        near ptr M05_L12
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M05_L64
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L19
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L67
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L20
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L68
       cmp       [rdi+8],r13d
       jb        near ptr M05_L69
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L72
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L71
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFA8DEB5D60
       cmp       dword ptr [7FFA8E21F778],0
       jne       near ptr M05_L70
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
       jle       near ptr M05_L25
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0E0]
       test      rdi,rdi
       je        near ptr M05_L21
M05_L13:
       mov       r14,[r15+8]
       test      r14,r14
       jne       near ptr M05_L22
       mov       ecx,2
       call      qword ptr [7FFA2E2EFD38]
       int       3
M05_L14:
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
M05_L15:
       mov       rcx,rdx
       mov       rdx,7FFA2EE2B6B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L16:
       mov       rdx,7FFA2EA37870
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L17:
       mov       rdx,7FFA2EDE9960
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L18:
       mov       rcx,rdx
       mov       rdx,7FFA2EE2B6F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L19:
       mov       rcx,rdi
       mov       rdx,7FFA2EE2BD90
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L20:
       mov       rcx,rdx
       mov       rdx,7FFA2EE2BDB0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L21:
       mov       rcx,r14
       mov       rdx,7FFA2EE2BE98
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L22:
       cmp       [r14+8],esi
       jl        near ptr M05_L31
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M05_L29
M05_L23:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M05_L30
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M05_L30
M05_L24:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M05_L25:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M05_L36
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L36
       jmp       short M05_L27
M05_L26:
       inc       edi
M05_L27:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M05_L37
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
       je        near ptr M05_L73
       test      r8,r8
       je        short M05_L28
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E2315A0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L26
M05_L28:
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
       jmp       near ptr M05_L26
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFA2EE29EA0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L23
M05_L30:
       mov       rcx,rdi
       mov       rdx,7FFA2EE29F38
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L24
M05_L31:
       mov       ecx,10
       call      qword ptr [7FFA2EB64978]
       int       3
M05_L32:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L74
       test      r14,r14
       je        near ptr M05_L75
       test      r8,r8
       je        short M05_L34
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFA2E2315A0
       call      qword ptr [r11]
M05_L33:
       test      eax,eax
       je        short M05_L35
M05_L34:
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
M05_L35:
       inc       edi
M05_L36:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M05_L37
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
       jne       near ptr M05_L32
       mov       rcx,rdx
       mov       rdx,7FFA2EE2B718
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L32
M05_L37:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L76
       test      ebx,ebx
       jl        near ptr M05_L77
       test      ebx,ebx
       jg        near ptr M05_L78
M05_L38:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L46
M05_L39:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFA2EC368C8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L47
M05_L40:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L49
       dec       edi
       mov       r14d,edi
       shr       r14d,1F
       add       r14d,edi
       sar       r14d,1
       sub       edi,r14d
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,edi
       xor       r8d,r8d
       call      qword ptr [7FFA2EC36928]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA2EC36928]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L48
M05_L41:
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
M05_L42:
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
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       cmovl     ecx,edx
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
M05_L43:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M05_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M05_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M05_L85
       cmp       byte ptr [rbx+24],0
       jne       short M05_L44
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC369D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EC369D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L44:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L45:
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
M05_L46:
       mov       rcx,rdx
       mov       rdx,7FFA2EE2B800
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rdx
       mov       rdx,7FFA2EE2B820
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L40
M05_L48:
       mov       rcx,rsi
       mov       rdx,7FFA2EE29460
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L41
M05_L49:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L43
M05_L50:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA2E8F5E00]
       int       3
M05_L51:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+70]
       test      rdx,rdx
       je        short M05_L52
       jmp       short M05_L53
M05_L52:
       mov       rdx,7FFA2EA8D268
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L53:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L54:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L57
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L55
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L56
M05_L55:
       mov       edx,4
M05_L56:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L57:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA2EE052A8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L58:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA2EC8D0B0]
       mov       [rbp-58],rax
M05_L59:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E231590
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L63
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M05_L60
       jmp       short M05_L61
M05_L60:
       mov       rcx,r14
       mov       rdx,7FFA2EDE9988
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L61:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M05_L62
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L59
M05_L62:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA2E2E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L59
M05_L63:
       mov       rcx,[rbp-58]
       mov       r11,7FFA2E231598
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L64:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L65
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L66
M05_L65:
       mov       eax,4
M05_L66:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFA2E2E71E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L67:
       test      r13d,r13d
       jne       short M05_L69
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L68:
       call      qword ptr [7FFA2EE050C8]
       int       3
M05_L69:
       call      qword ptr [7FFA2E4FF1B0]
       int       3
M05_L70:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L71:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA2E8FE0D0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L72:
       call      qword ptr [7FFA2E77C780]
       int       3
M05_L73:
       test      r8,r8
       je        near ptr M05_L26
       jmp       near ptr M05_L28
M05_L74:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L33
M05_L75:
       test      r8,r8
       je        near ptr M05_L35
       jmp       near ptr M05_L34
M05_L76:
       call      qword ptr [7FFA2EE04E58]
       int       3
M05_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA2E8F5E00]
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
       call      qword ptr [7FFA2E88CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFA2EE04150]
       jmp       near ptr M05_L38
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M05_L81:
       call      qword ptr [7FFA2EA57C60]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L42
M05_L83:
       mov       ecx,847
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFA2EC89150
       call      qword ptr [7FFA2E2EF210]
       mov       rcx,rax
       call      qword ptr [7FFA2EE04D20]
       int       3
M05_L86:
       call      qword ptr [7FFA2EE04F90]
       mov       rsi,rax
       jmp       near ptr M05_L45
M05_L87:
       mov       rsi,rcx
       jmp       near ptr M05_L45
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
       mov       r11,7FFA2E231598
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2779
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
       jmp       qword ptr [7FFA2E2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       vmulss    xmm0,xmm0,dword ptr [7FFA2ED02DF0]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M08_L01
       mov       rcx,7FFA2EE3E7E8
       call      CORINFO_HELP_COUNTPROFILE32
M08_L00:
       mov       rcx,7FFA2EE3E7EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EC36778]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M08_L01:
       mov       rcx,7FFA2EE3E7F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA2EE04FA8]
; Total bytes of code 142
```

