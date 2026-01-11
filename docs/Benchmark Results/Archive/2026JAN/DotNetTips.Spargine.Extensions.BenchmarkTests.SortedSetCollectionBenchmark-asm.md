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
       mov       rax,20C0C000AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD10D080]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD10D080]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC7210E8
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       jb        near ptr M00_L31
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
       mov       rdx,20C0C000AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20C0C000AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCFCA579A8]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1C4828]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1CE670]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCFC7210F0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC7210F0
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
       call      qword ptr [7FFCFD1CE760]
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
       call      qword ptr [7FFCFD1CE748]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC87900]
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
       call      qword ptr [7FFCFD10D050]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD1C5458]
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
       mov       rax,1DD00002AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD0FD260]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD0FD260]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC7210E8
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       jb        near ptr M00_L31
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
       mov       rdx,1DD00002AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DD00002AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCFCA579A8]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1C4870]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1CE6E8]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCFC7210F0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC7210F0
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
       call      qword ptr [7FFCFD1CE7D8]
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
       call      qword ptr [7FFCFD1CE7C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC87900]
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
       call      qword ptr [7FFCFD0FD230]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD1C54A0]
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
       mov       rax,2A22C402AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD10D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD10D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC7210E8
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       jb        near ptr M00_L31
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
       mov       rdx,2A22C402AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A22C402AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCFCA579A8]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1C4828]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1CE6A0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCFC7210F0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC7210F0
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
       call      qword ptr [7FFCFD1CE790]
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
       call      qword ptr [7FFCFD1CE778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC87900]
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
       call      qword ptr [7FFCFD10D0F8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD1C5458]
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
       mov       rax,1E1C9400AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD11D170]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC7310E0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD11D170]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC7310E8
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       jb        near ptr M00_L31
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
       mov       rdx,1E1C9400AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E1C9400AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCFCA679A8]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBBA018
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1D4828]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1DE6A0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC7310D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCFC7310F0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC7310F0
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
       call      qword ptr [7FFCFD1DE790]
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
       call      qword ptr [7FFCFD1DE778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC97900]
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
       call      qword ptr [7FFCFD11D140]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD1D5458]
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
       mov       rax,2FAD6C00AD8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD10D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD10D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC7210E8
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       jb        near ptr M00_L31
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
       mov       rdx,2FAD6C00AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2FAD6C00AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCFCA579A8]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1C4810]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1CE688]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCFC7210F0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC7210F0
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
       call      qword ptr [7FFCFD1CE778]
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
       call      qword ptr [7FFCFD1CE760]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC87900]
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
       call      qword ptr [7FFCFD1CE688]
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
       call      qword ptr [7FFCFD1C5440]
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
       mov       rax,1DBA9002AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD11D218]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC7410F0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD11D218]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC7410F8
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       jb        near ptr M00_L31
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
       mov       rdx,1DBA9002AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DBA9002AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCFCA779A8]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBCA018
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1E4900]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1EE700]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC7410E8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCFC741100
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC741100
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
       call      qword ptr [7FFCFD1EE820]
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
       call      qword ptr [7FFCFD1EE808]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCCA7900]
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
       call      qword ptr [7FFCFD11D1E8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD1E5530]
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
       mov       rax,17775002AD0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L31
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD0FEEC8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC721390
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD0FEEC8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC721398
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       call      qword ptr [7FFCFCA579A8]
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
       mov       rdx,17775002AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17775002AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD1C4858]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD1CFC60]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC721388
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFCFC7213A0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC7213A0
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
       call      qword ptr [7FFCFD1CFD80]
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
       call      qword ptr [7FFCFD1CFD68]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC87900]
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
       call      qword ptr [7FFCFD0FEE98]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD1C5488]
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
       mov       rax,1A961C00B80
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L31
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
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
       js        near ptr M00_L32
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
       jbe       near ptr M00_L33
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
       call      qword ptr [7FFCFD1E6A18]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
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
       mov       r11,7FFCFC721738
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCFD1E6A18]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCFC721740
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
       jne       near ptr M00_L36
M00_L21:
       mov       ebx,1
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
       call      qword ptr [7FFCFCA579A8]
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
       mov       rdx,1A961C00B78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCFC7D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A961C00B80
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCFD006C88]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCFD3A4888]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCFC721730
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFCFC721748
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFCFC721748
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
       call      qword ptr [7FFCFD3A4978]
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
       call      qword ptr [7FFCFD3A4960]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC87900]
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
       call      qword ptr [7FFCFD1E69E8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCFD007900]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,[rbx+60]
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
       mov       rcx,1C961800AD0
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
       call      qword ptr [7FFCFD0FD4B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD4B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1C961800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD1DF2E8]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD0FD1B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD0FD158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCEAE7C0]
       mov       ecx,65
       mov       rdx,7FFCFCD06AC8
       call      qword ptr [7FFCFCA57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06AC8
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4528]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4540]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD193660
       call      qword ptr [7FFCFD0FD200]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0D6A48]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD1DEE38]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD2D85C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD4B8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD4B8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD2D85CC
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
       mov       rax,[rdx+0B0]
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
       mov       r11,[rdx+0C8]
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
       mov       rax,[rdx+0A0]
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
       call      qword ptr [7FFCFCD04808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r14,[rax+0D8]
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
       mov       r11,7FFCFC720FC0
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
       mov       rdx,7FFCFD2C0BD0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD2C1528
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD2C19C8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD2C25F0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD2C2630
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD1A19F0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD2C2648
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FFCFD2C2D90
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FFCFD29DBC8
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFCFD29DC60
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCFC720FC0
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
       mov       rdx,7FFCFD2C19D8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD0FD3E0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD0FD4B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD4B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCFD2C1A20
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FFCFD2C1468
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD0FD410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD0FD410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFCFD29F630
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FFCFC720FA8
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
       mov       rdx,7FFCFD2C1B68
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C1D50
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C1C88
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C1D38
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FFCFD20C7B0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD1D4A68]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD1DF180]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCC85AB8]
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FFCFD20C7B0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FFCFD2C2600
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC720FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FFCFD2C2618
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC97E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC720FB8
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
       mov       rdx,7FFCFD2C19C8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCFD004D80]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCEAE790]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA5C1C8]
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
       call      qword ptr [7FFCFD1DE940]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEA5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD1DE970]
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
       call      qword ptr [7FFCFCE3CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD1DF1F8]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
       int       3
M02_L93:
       call      qword ptr [7FFCFD0F4C60]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD1DF270]
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
       mov       r11,7FFCFC720FB8
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
       call      qword ptr [7FFCFD0FD488]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD2C0C20
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD2C1120
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1DF2E8]
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
       call      qword ptr [7FFCFD0FD1B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD0FD158]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD17A080
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DEAC0]
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
       mov       rdx,7FFCFD2C0BD0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD2C1528
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD0FD200]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0D6ED0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD1DEE38]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,209E0BD0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1D7468]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC720FC8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1B68
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1D50
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1C88
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1D38
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,2641CC00AD0
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
       call      qword ptr [7FFCFD11D428]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D428]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,2641CC00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD1FF390]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD11D128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD11D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCECE7D8]
       mov       ecx,65
       mov       rdx,7FFCFCD26AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD114510]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD114528]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD19F118
       call      qword ptr [7FFCFD11D170]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0F7188]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD1FEEF8]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD2F8F68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D428]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D428]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD2F8F6C
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
       mov       rax,[rdx+0B0]
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
       mov       r11,[rdx+0C8]
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
       mov       rax,[rdx+0A0]
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
       call      qword ptr [7FFCFCD24808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r14,[rax+0D8]
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
       mov       r11,7FFCFC740FC0
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
       mov       rdx,7FFCFD2E1FF0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD2E2948
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD2E2DE8
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD2E3A10
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD2E3A50
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD1C26B0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD2E3A68
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FFCFD2E41B0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FFCFD2AEFC0
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFCFD2AF058
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCFC740FC0
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
       mov       rdx,7FFCFD2E2DF8
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD11D350]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD11D428]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D428]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCFD2E2E40
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FFCFD2E2888
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD11D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD11D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFCFD2E09C0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FFCFC740FA8
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
       mov       rdx,7FFCFD2E2F88
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2E3170
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2E30A8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2E3158
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FFCFD21D7C0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFCBCA018
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD1F4B10]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD1FF240]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCCA5AB8]
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FFCFD21D7C0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FFCFD2E3A20
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC740FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FFCFD2E3A38
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC740FB8
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
       mov       rdx,7FFCFD2E2DE8
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCFD024D68]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCECE7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA7C1C8]
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
       call      qword ptr [7FFCFD1FEA00]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEC5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD1FEA30]
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
       call      qword ptr [7FFCFCE5CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD1FF2B8]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
       int       3
M02_L93:
       call      qword ptr [7FFCFD114C48]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD1FF330]
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
       mov       r11,7FFCFC740FB8
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
       call      qword ptr [7FFCFD11D3F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD2E2040
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD2E2540
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1FF390]
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
       call      qword ptr [7FFCFD11D128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD11D0C8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD195B68
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1FEB80]
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
       mov       rdx,7FFCFD2E1FF0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD2E2948
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD11D170]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0F7610]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD1FEEF8]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2A49BD80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1F7510]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC740FC8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD2E2F88
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD2E3170
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD2E30A8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD2E3158
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,26740C02010
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
       call      qword ptr [7FFCFD145848]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD145848]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,26740C02010
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD14FE40]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD145548]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD1454E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCEC6AC0]
       mov       ecx,65
       mov       rdx,7FFCFCD26AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFFC8D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFFC8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD159D48
       call      qword ptr [7FFCFD145590]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD068DF8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD14F870]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD1D10D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD145848]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD145848]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD1D10D4
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
       je        near ptr M02_L51
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L82
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+90]
       test      rax,rax
       je        near ptr M02_L15
M02_L00:
       mov       rdx,[rax+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M02_L16
M02_L01:
       mov       rax,rbx
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M02_L52
M02_L02:
       test      rax,rax
       je        near ptr M02_L54
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L53
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L81
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L17
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L71
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M02_L19
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M02_L64
       mov       ebx,[r14+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L65
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        near ptr M02_L20
M02_L09:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M02_L21
M02_L10:
       mov       rdi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M02_L70
       mov       r15d,[r14+20]
       mov       r13d,r15d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass42_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+10],ecx
       mov       [r12+14],r13d
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,r15d
       test      edi,edi
       jl        near ptr M02_L68
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L69
       mov       [r12+14],r15d
       mov       rcx,offset MT_System.Collections.Generic.TreeWalkPredicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Collections.Generic.SortedSet`1+<>c__DisplayClass42_0[[System.__Canon, System.Private.CoreLib]].<CopyTo>b__0(Node<System.__Canon>)
       mov       [rdi+18],rcx
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFCFCD24808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L81
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L89
       cmp       edi,1
       jle       near ptr M02_L26
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0D8]
       test      r14,r14
       je        near ptr M02_L22
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       jne       near ptr M02_L23
       mov       ecx,2
       call      qword ptr [7FFCFCA7C1C8]
       int       3
M02_L15:
       mov       rcx,rdx
       mov       rdx,7FFCFD174790
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L16:
       mov       rcx,rax
       mov       rdx,7FFCFD1750E8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L17:
       mov       rcx,rdx
       mov       rdx,7FFCFD175588
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L18:
       mov       rdx,7FFCFD1761B0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L19:
       mov       rcx,rdi
       mov       rdx,7FFCFD176200
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L20:
       mov       rcx,rdi
       mov       rdx,7FFCFD176218
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L21:
       mov       rcx,rdi
       mov       rdx,7FFCFD176220
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L22:
       mov       rdx,7FFCFD176A20
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L23:
       cmp       [r15+8],edi
       jl        near ptr M02_L32
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L30
M02_L24:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L31
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L31
M02_L25:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L26:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L37
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L37
M02_L27:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L38
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
       je        near ptr M02_L85
       test      r8,r8
       je        short M02_L28
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFCFC740D80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L29
M02_L28:
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
M02_L29:
       inc       r14d
       jmp       near ptr M02_L27
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFCFD176BE8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L24
M02_L31:
       mov       rcx,r14
       mov       rdx,7FFCFD176C80
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L25
M02_L32:
       mov       ecx,10
       call      qword ptr [7FFCFD14FC90]
       int       3
M02_L33:
       mov       rax,[rsi+8]
       cmp       r13d,[rax+8]
       jae       near ptr M02_L100
       mov       ecx,r13d
       mov       r8,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L86
       test      r15,r15
       je        near ptr M02_L87
       test      r8,r8
       je        short M02_L35
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFCFC740D80
       call      qword ptr [r11]
M02_L34:
       test      eax,eax
       je        short M02_L36
M02_L35:
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
M02_L36:
       inc       r14d
M02_L37:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L38
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
       jne       near ptr M02_L33
       mov       rdx,7FFCFD175598
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L33
M02_L38:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L88
       test      ebx,ebx
       jl        near ptr M02_L89
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L39:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L45
       mov       rcx,rax
M02_L40:
       mov       rdx,rsi
       call      qword ptr [7FFCFD145770]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L46
M02_L41:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       jne       near ptr M02_L47
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M02_L42:
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
       jne       short M02_L43
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD145848]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD145848]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M02_L43:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L44:
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
M02_L45:
       mov       rdx,7FFCFD1755E0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L40
M02_L46:
       mov       rdx,7FFCFD175028
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L41
M02_L47:
       dec       esi
       mov       r14d,esi
       shr       r14d,1F
       add       r14d,esi
       sar       r14d,1
       sub       esi,r14d
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FFCFD1457A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD1457A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L50
M02_L48:
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
M02_L49:
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
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFCFD1726D8
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L48
M02_L51:
       mov       ecx,885
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
       int       3
M02_L52:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L53:
       mov       rcx,rax
       mov       r11,7FFCFC740D68
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L54:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rsi
       mov       rdx,7FFCFD175728
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L59
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L57
       jmp       short M02_L58
M02_L57:
       mov       rcx,rsi
       mov       rdx,7FFCFD175910
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L58:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L59:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L60
       jmp       short M02_L61
M02_L60:
       mov       rcx,rsi
       mov       rdx,7FFCFD175848
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L61:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L62
       jmp       short M02_L63
M02_L62:
       mov       rcx,rsi
       mov       rdx,7FFCFD1758F8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L63:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L81
M02_L64:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L65:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A8]
       test      rcx,rcx
       je        short M02_L66
       jmp       short M02_L67
M02_L66:
       mov       rcx,rdi
       mov       rdx,7FFCFD1761C0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L68:
       mov       ecx,80B
       mov       rdx,7FFCFCBCA018
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFCFD14F720]
       int       3
M02_L69:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFCFD14FBB8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFCCA5AB8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L70:
       mov       rcx,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L71:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A8]
       test      rcx,rcx
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rcx,rdi
       mov       rdx,7FFCFD1761C0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L73:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B0]
       test      r11,r11
       je        short M02_L74
       jmp       short M02_L75
M02_L74:
       mov       rcx,rdi
       mov       rdx,7FFCFD1761D0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L75:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L76:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC740D70
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L80
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M02_L77
       jmp       short M02_L78
M02_L77:
       mov       rcx,rdi
       mov       rdx,7FFCFD1761E8
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L78:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L79
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L76
M02_L79:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L76
M02_L80:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC740D78
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L81:
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
M02_L82:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        short M02_L83
       jmp       short M02_L84
M02_L83:
       mov       rcx,rdx
       mov       rdx,7FFCFD175588
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L84:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCFCF4D0C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCEC6A90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L85:
       test      r8,r8
       je        near ptr M02_L29
       jmp       near ptr M02_L28
M02_L86:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L34
M02_L87:
       test      r8,r8
       je        near ptr M02_L36
       jmp       near ptr M02_L35
M02_L88:
       call      qword ptr [7FFCFD14FCA8]
       int       3
M02_L89:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEC5E00]
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
       call      qword ptr [7FFCFCE5CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD14FD68]
       jmp       near ptr M02_L39
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
       int       3
M02_L93:
       call      qword ptr [7FFCFCFFD008]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L49
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD14FDE0]
       mov       rbx,rax
       jmp       near ptr M02_L44
M02_L99:
       mov       rbx,rdx
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
       mov       r11,7FFCFC740D78
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3274
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
       call      qword ptr [7FFCFD145818]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD1747E0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD174CE0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD14FE40]
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
       call      qword ptr [7FFCFD145548]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD1454E8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD150798
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD14F3A8]
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
       mov       rdx,7FFCFD174790
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD1750E8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD145590]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD069280]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD14F870]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2A7D5C30008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1E4DB0]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC740D88
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD175728
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD175910
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD175848
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD1758F8
       call      qword ptr [7FFCFCA77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,13588000AD0
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
       call      qword ptr [7FFCFD11D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,13588000AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD1EF318]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD11D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD11D068]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCEBE6A0]
       mov       ecx,65
       mov       rdx,7FFCFCD16AC8
       call      qword ptr [7FFCFCA67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16AC8
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD1143D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD1143F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD1A2C18
       call      qword ptr [7FFCFD11D110]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0E6708]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD1EEE80]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD2E8F68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D3C8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D3C8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD2E8F6C
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
       mov       rax,[rdx+0B0]
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
       mov       r11,[rdx+0C8]
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
       mov       rax,[rdx+0A0]
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
       call      qword ptr [7FFCFCD14808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r14,[rax+0D8]
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
       mov       r11,7FFCFC730FC0
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
       mov       rdx,7FFCFD2D1170
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD2D1AC8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD2D1F68
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD2D2B90
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD2D2BD0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD1B2010
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD2D2BE8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FFCFD2D3330
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FFCFD2AE110
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFCFD2AE1A8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCFC730FC0
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
       mov       rdx,7FFCFD2D1F78
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD11D2F0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD11D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD11D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFCFD11D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCFD2D1FC0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L46:
       mov       rdx,7FFCFD2D1A08
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rdi
       mov       rdx,7FFCFD2D0500
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L42
M02_L49:
       mov       ecx,885
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FFCFC730FA8
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
       mov       rdx,7FFCFD2D2108
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D22F0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D2228
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D22D8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L64
       jmp       short M02_L65
M02_L64:
       mov       rdx,7FFCFD21CAE8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFCBBA018
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD1E4A98]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD1EF1C8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCC95AB8]
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rdx,7FFCFD21CAE8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,[rdx+0B8]
       test      r11,r11
       je        short M02_L72
       jmp       short M02_L73
M02_L72:
       mov       rdx,7FFCFD2D2BA0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC730FB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L78
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FFCFD2D2BB8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC98E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC730FB8
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
       mov       rdx,7FFCFD2D1F68
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCFD014C30]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCEBE670]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA6C1C8]
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
       call      qword ptr [7FFCFD1EE988]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEB5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD1EE9B8]
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
       call      qword ptr [7FFCFCE4CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD1EF240]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
       int       3
M02_L93:
       call      qword ptr [7FFCFD114B10]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L41
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD1EF2B8]
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
       mov       r11,7FFCFC730FB8
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
       call      qword ptr [7FFCFD11D398]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD2D11C0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD2D16C0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1EF318]
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
       call      qword ptr [7FFCFD11D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD11D068]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EED00]
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
       mov       rdx,7FFCFD2D1170
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD2D1AC8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD11D110]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0E6B90]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD1EEE80]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,17607090008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1E7498]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC730FC8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D2108
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D22F0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D2228
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D22D8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,208CDC02AC8
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
       call      qword ptr [7FFCFD11D410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,208CDC02AC8
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD1EF348]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD11D110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD11D0B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCEBE6A0]
       mov       ecx,65
       mov       rdx,7FFCFCD16AC8
       call      qword ptr [7FFCFCA67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16AC8
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD114420]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD114438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD1A2C18
       call      qword ptr [7FFCFD11D158]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0E65C8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD1EEE98]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD2E6730
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D410]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D410]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD2E6734
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
       mov       rax,[rdx+0A0]
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
       call      qword ptr [7FFCFCD14808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFCFC730FC0
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
       mov       rdx,7FFCFD2D0830
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD2D1188
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD2D1628
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD2D2250
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD2D2290
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD1C1FD8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD2D22A8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD014C30]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCEBE670]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFCFD2D29F0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFCFD2AF6B8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFCFD2AF750
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCFC730FC0
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
       mov       rdx,7FFCFD2D1638
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD11D338]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD11D368]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD11D368]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFCFD11D410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11D410]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCFD2D1680
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FFCFD2D10C8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFCFD2AF2E0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFCFC730FA8
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
       mov       rdx,7FFCFD2D17C8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D19B0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D18E8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D1998
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FFCFD21CB28
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFCBBA018
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD1E4AE0]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD1EF1E0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCC95AB8]
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FFCFD21CB28
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2D2260
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC730FB0
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
       mov       rdx,7FFCFD2D2278
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC98E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC730FB8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFCFD2D1628
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA6C1C8]
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
       call      qword ptr [7FFCFD1EECD0]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEB5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD1EED00]
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
       call      qword ptr [7FFCFCE4CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD1EF258]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
       int       3
M02_L93:
       call      qword ptr [7FFCFD114B58]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD1EF2D0]
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
       mov       r11,7FFCFC730FB8
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
       call      qword ptr [7FFCFD11D3E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD2D0880
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD2D0D80
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1EF348]
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
       call      qword ptr [7FFCFD11D110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD11D0B0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD189658
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1EEBE0]
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
       mov       rdx,7FFCFD2D0830
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD2D1188
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD11D158]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0E6C80]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD1EEE98]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,24962B80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1E7570]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC730FC8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D17C8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D19B0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D18E8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD2D1998
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,12DC4000AD0
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
       call      qword ptr [7FFCFD0FD500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,12DC4000AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD1DF390]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD0FD200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD0FD1A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCEAE7D8]
       mov       ecx,65
       mov       rdx,7FFCFCD06AC8
       call      qword ptr [7FFCFCA57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06AC8
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4528]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4540]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD193660
       call      qword ptr [7FFCFD0FD248]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0D7028]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD1DEEE0]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD2D7060
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD500]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD500]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD2D7064
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
       mov       rax,[rdx+0A0]
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
       call      qword ptr [7FFCFCD04808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFCFC720FC0
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
       mov       rdx,7FFCFD2C09B8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD2C1310
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD2C17B0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD2C23D8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD2C2418
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD1A18A0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD2C2430
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD004D80]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCEAE7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFCFD2C2B78
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFCFD29E170
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFCFD29E208
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCFC720FC0
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
       mov       rdx,7FFCFD2C17C0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD0FD428]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD0FD458]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD0FD458]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFCFD0FD500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCFD2C1808
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FFCFD2C1250
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFCFD29FDE0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFCFC720FA8
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
       mov       rdx,7FFCFD2C1950
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C1B38
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C1A70
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C1B20
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FFCFD20C9B8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFCBAA018
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD1D4B10]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD1DF228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCC85AB8]
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FFCFD20C9B8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD2C23E8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC720FB0
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
       mov       rdx,7FFCFD2C2400
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC97E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC720FB8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFCFD2C17B0
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA5C1C8]
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
       call      qword ptr [7FFCFD1DEA00]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEA5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD1DEA30]
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
       call      qword ptr [7FFCFCE3CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD1DF2A0]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
       int       3
M02_L93:
       call      qword ptr [7FFCFD0F4C60]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD1DF318]
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
       mov       r11,7FFCFC720FB8
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
       call      qword ptr [7FFCFD0FD4D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD2C0A08
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD2C0F08
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1DF390]
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
       call      qword ptr [7FFCFD0FD200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD0FD1A0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD17A090
       call      qword ptr [7FFCFCA57738]
       mov       rcx,rax
       call      qword ptr [7FFCFD1DED60]
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
       mov       rdx,7FFCFD2C09B8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD2C1310
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD0FD248]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD0D74B0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD1DEEE0]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,16E430D0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1D75A0]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC720FC8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1950
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1B38
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1A70
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD2C1B20
       call      qword ptr [7FFCFCA57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,1D962400AD0
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
       call      qword ptr [7FFCFD0FF168]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FF168]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1D962400AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD3A5128]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD0FEE68]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD0FEE08]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCEBE6A0]
       mov       ecx,65
       mov       rdx,7FFCFCD16AC8
       call      qword ptr [7FFCFCA67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16AC8
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F55C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F55D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD1BBC78
       call      qword ptr [7FFCFD0FEEB0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD31F4F8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD3A4FD8]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD3DD908
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FF168]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FF168]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD3DD90C
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
       mov       rax,[rdx+0C0]
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
       mov       r11,[rdx+0D8]
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
       mov       rax,[rdx+98]
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
       mov       r11,[rdx+0E0]
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
       call      qword ptr [7FFCFCD14808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r14,[rax+0E8]
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
       mov       r11,7FFCFC7313E0
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
       mov       rdx,7FFCFD3C9C88
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD3CA2A8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD3CA748
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD2DD538
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD2DD578
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD10E5C8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD2DD590
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD014C30]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCEBE670]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFCFD3CB110
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFCFD3C78D0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFCFD3C7968
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCFC7313E0
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
       mov       rdx,7FFCFD3CA758
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M02_L46
       mov       rcx,rax
M02_L41:
       mov       rdx,rsi
       call      qword ptr [7FFCFD0FF090]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L47
M02_L42:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       jne       near ptr M02_L48
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M02_L43:
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
       jne       short M02_L44
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FF168]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FF168]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M02_L44:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L45:
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
M02_L46:
       mov       rdx,7FFCFD3CA7A0
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FFCFD3CA1E8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L48:
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
       call      qword ptr [7FFCFD0FF0C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD0FF0C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L51
M02_L49:
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
M02_L50:
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
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       mov       rdx,7FFCFD3C66E8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFCFC7313C8
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
       mov       rdx,7FFCFD3CA8E8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD3CAAD0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD3CAA08
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFCFD3CAAB8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FFCFD246608
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCFCBBA018
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD1E4AF8]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD3A5038]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCC95AB8]
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FFCFD246608
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FFCFD2DD548
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC7313D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FFCFD2DD560
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC98E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC7313D8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFCFD3CA748
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA6C1C8]
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
       call      qword ptr [7FFCFD3A4D80]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEB5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD3A4DB0]
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
       call      qword ptr [7FFCFCE4CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD1EFC18]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
       int       3
M02_L93:
       call      qword ptr [7FFCFD0F5E48]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD3A4EE8]
       mov       rbx,rax
       jmp       near ptr M02_L45
M02_L99:
       mov       rbx,rdx
       jmp       near ptr M02_L45
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
       mov       r11,7FFCFC7313D8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3294
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
       call      qword ptr [7FFCFD0FF138]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD3C9CD8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD3CA1D8
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD3A5128]
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
       call      qword ptr [7FFCFD0FEE68]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD0FEE08]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD1B26C8
       call      qword ptr [7FFCFCA67738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3A4930]
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
       mov       rdx,7FFCFD3C9C88
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFCFD3CA2A8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD0FEEB0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD31F8C0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD3A4FD8]
       jmp       near ptr M03_L12
; Total bytes of code 528
```
```assembly
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,219E12F0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFCFD1E7B28]
       int       3
; Total bytes of code 244
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC7313E8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD3CA8E8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD3CAAD0
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD3CAA08
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD3CAAB8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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
       mov       rcx,2297C802B80
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
       call      qword ptr [7FFCFD206E38]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD206E38]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,2297C802B80
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFCFD3D54E8]
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
       jne       near ptr M00_L14
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD206B38]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L08:
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCFD206AD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFCFCECE7D8]
       mov       ecx,65
       mov       rdx,7FFCFCD26AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD026730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD026748]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFCFD307160
       call      qword ptr [7FFCFD206B80]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD277478]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFCFD3D53B0]
       jmp       near ptr M00_L08
; Total bytes of code 663
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FFCFD4113D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD206E38]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD206E38]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFCFD4113D4
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
       mov       rax,[rdx+0C0]
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
       mov       r11,[rdx+0D8]
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
       mov       rax,[rdx+78]
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
       mov       r11,[rdx+0E0]
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
       call      qword ptr [7FFCFCD24808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r14,[rax+0E8]
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
       mov       r11,7FFCFC741798
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
       mov       rdx,7FFCFD3FD300
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCFD3FD920
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFCFD3FDDC8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFCFD3B68D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFCFD3B6910
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFCFD006B88
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFCFD3B6928
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
       call      qword ptr [7FFCFD02CBA0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFCECE7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFCFD3FE790
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFCFD3FAF40
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFCFD3FAFD8
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
       mov       r11,7FFCFC741798
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
       mov       rdx,7FFCFD3FDDD8
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
       call      qword ptr [7FFCFD206D60]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD206D90]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCFD206D90]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFCFD206E38]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD206E38]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCFD3FDE20
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FFCFD3FD860
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFCFD3F9EF0
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
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFCFC741780
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
       mov       rdx,7FFCFD3FDF68
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
       mov       rdx,7FFCFD3FE150
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
       mov       rdx,7FFCFD3FE088
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
       mov       rdx,7FFCFD3FE138
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
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FFCFD05E980
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
       mov       rdx,7FFCFCBCA018
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCFD026CE8]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCFD3D5410]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCFCCA5AB8]
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
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FFCFD05E980
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
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FFCFD3B68E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC741788
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FFCFD3B68F8
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFCFC741790
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFCFD3FDDC8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFCFCA7C1C8]
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
       call      qword ptr [7FFCFD3D5170]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEC5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFCFD144840]
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
       call      qword ptr [7FFCFCE5CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFCFD3D41C8]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
       int       3
M02_L93:
       call      qword ptr [7FFCFD027378]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFCFD3D52C0]
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
       mov       r11,7FFCFC741790
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3270
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
       call      qword ptr [7FFCFD206E08]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFCFD3FD350
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFCFD3FD850
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD3D54E8]
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
       call      qword ptr [7FFCFD206B38]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCFD206AD8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFCFD2EDBA0
       call      qword ptr [7FFCFCA77738]
       mov       rcx,rax
       call      qword ptr [7FFCFD3D4D50]
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
       mov       rdx,7FFCFD3FD300
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
       mov       rdx,7FFCFD3FD920
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFCFD206B80]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCFD277840]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCFD3D53B0]
       jmp       near ptr M03_L12
; Total bytes of code 524
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M04_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L00
       test      rbx,rbx
       je        near ptr M04_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       test      rbx,rbx
       je        short M04_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L02
M04_L01:
       mov       rax,26A11940008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      qword ptr [7FFCFD207A20]
       int       3
; Total bytes of code 235
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
       je        short M05_L00
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       short M05_L03
M05_L00:
       test      rcx,rcx
       je        short M05_L05
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M05_L04
       mov       ebx,[rcx+20]
M05_L01:
       mov       [rdi],ebx
M05_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M05_L00
M05_L04:
       mov       r11,7FFCFC7417A0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M05_L01
M05_L05:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rbx
       mov       rdx,7FFCFD3FDF68
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L10
       mov       rcx,[rbx+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FFCFD3FE150
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L09:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M05_L11
       jmp       short M05_L12
M05_L11:
       mov       rcx,rbx
       mov       rdx,7FFCFD3FE088
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L12:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L15
       mov       rcx,[rbx+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M05_L13
       jmp       short M05_L14
M05_L13:
       mov       rcx,rbx
       mov       rdx,7FFCFD3FE138
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M05_L14:
       mov       rcx,rbp
       call      qword ptr [r11]
       mov       [rdi],eax
       jmp       near ptr M05_L02
M05_L15:
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

