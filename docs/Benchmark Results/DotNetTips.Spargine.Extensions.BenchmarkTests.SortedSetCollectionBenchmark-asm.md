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
       mov       rax,16A00002AD0
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
       call      qword ptr [7FF94CDBD1A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C5110D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CDBD1A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C5110D8
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
       mov       rdx,16A00002AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16A00002AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF94C8479A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CEF4870]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CEFE5C8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C5110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF94C5110E0
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
       mov       r11,7FF94C5110E0
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
       call      qword ptr [7FF94CEFE6B8]
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
       call      qword ptr [7FF94CEFE6A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C9B7900]
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
       call      qword ptr [7FF94CDBD170]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CEF54B8]
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
       mov       rax,2098D800AD8
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
       call      qword ptr [7FF94CE3D050]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C5110D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CE3D050]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C5110D8
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
       mov       rdx,2098D800AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2098D800AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF94C8479A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CEF47F8]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CEFE580]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C5110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF94C5110E0
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
       mov       r11,7FF94C5110E0
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
       call      qword ptr [7FF94CEFE670]
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
       call      qword ptr [7FF94CEFE658]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C9B7900]
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
       call      qword ptr [7FF94CE3D020]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CEF5440]
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
       mov       rax,221B5C02AD0
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
       call      qword ptr [7FF94CE2D158]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C5010D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CE2D158]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C5010D8
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
       mov       rdx,221B5C02AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,221B5C02AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF94C8379A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8CA018
       call      qword ptr [7FF94C837738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CEE4810]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CEEE598]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C5010C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF94C5010E0
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
       mov       r11,7FF94C5010E0
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
       call      qword ptr [7FF94CEEE688]
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
       call      qword ptr [7FF94CEEE670]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C9A7900]
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
       call      qword ptr [7FF94CE2D128]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CEE5458]
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
       mov       rax,21E12800AD8
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
       call      qword ptr [7FF94CE3D1B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C5110D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CE3D1B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C5110D8
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
       mov       rdx,21E12800AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21E12800AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF94C8479A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CEF48A0]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CEFE610]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C5110C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF94C5110E0
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
       mov       r11,7FF94C5110E0
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
       call      qword ptr [7FF94CEFE700]
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
       call      qword ptr [7FF94CEFE6E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C9B7900]
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
       call      qword ptr [7FF94CE3D188]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CEF54E8]
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
       mov       rax,2211D400AD8
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
       call      qword ptr [7FF94CE1D080]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C4F10D0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CE1D080]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C4F10D8
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
       mov       rdx,2211D400AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2211D400AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF94C8279A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8BA018
       call      qword ptr [7FF94C827738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CED4810]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CEDE598]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C4F10C8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF94C4F10E0
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
       mov       r11,7FF94C4F10E0
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
       call      qword ptr [7FF94CEDE688]
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
       call      qword ptr [7FF94CEDE670]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C997900]
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
       call      qword ptr [7FF94CEDE598]
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
       call      qword ptr [7FF94CED5458]
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
       mov       rax,2287E800AD8
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
       call      qword ptr [7FF94CE3D170]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C5110E0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CE3D170]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C5110E8
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
       mov       rdx,2287E800AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2287E800AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       call      qword ptr [7FF94C8479A8]
       int       3
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CEF4840]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CEFE598]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C5110D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L35:
       mov       r11,7FF94C5110F0
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
       mov       r11,7FF94C5110F0
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
       call      qword ptr [7FF94CEFE688]
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
       call      qword ptr [7FF94CEFE670]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C9B7900]
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
       call      qword ptr [7FF94CE3D140]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CEF5488]
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
       mov       rax,24BBA000AD8
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
       call      qword ptr [7FF94CDEE208]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C4E1338
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CDEE208]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C4E1340
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
       call      qword ptr [7FF94C8179A8]
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
       mov       rdx,24BBA000AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24BBA000AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8AA018
       call      qword ptr [7FF94C817738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CEC4870]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94CECFAF8]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C4E1330
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L35:
       mov       r11,7FF94C4E1348
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
       mov       r11,7FF94C4E1348
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
       call      qword ptr [7FF94CECFBE8]
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
       call      qword ptr [7FF94CECFBD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C987900]
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
       call      qword ptr [7FF94CDEE1D8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CEC54B8]
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
       mov       rax,1931F800B80
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
       call      qword ptr [7FF94CF166D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF94C511770
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF94CF166D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF94C511778
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
       call      qword ptr [7FF94C8479A8]
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
       mov       rdx,1931F800B78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF94C5C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1931F800B80
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       mov       ecx,783
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF94CD36CA0]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FF94D0D4720]
       jmp       near ptr M00_L02
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF94C511768
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L35:
       mov       r11,7FF94C511780
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
       mov       r11,7FF94C511780
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
       call      qword ptr [7FF94D0D4840]
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
       call      qword ptr [7FF94D0D4828]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94C9B7900]
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
       call      qword ptr [7FF94CF166A0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF94CD37990]
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
       je        near ptr M00_L15
       mov       rcx,1AF71000AD0
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1AF71000AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94CEEF1F8]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CE1D080]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE1D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CEA5248
       call      qword ptr [7FF94CE1D0C8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDE5FA0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CEEED48]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,1AF71000AD0
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94CFEA8F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1D380]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1D380]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94CFEA8FC
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
       call      qword ptr [7FF94CA14808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF94C4F0FA0
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
       mov       rdx,7FF94CFD0DF0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94CFD1748
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94CFD1BE8
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94CFD2810
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94CFD2850
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEB22A0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94CFD2868
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF94CFD2FB0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF94CFADEF0
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF94CFADF88
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C4F0FA0
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
       mov       rdx,7FF94CFD1BF8
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE1D2A8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE1D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94CFD1C40
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF94CFD1688
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE1D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CE1D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF94CFAF8C0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF94C4F0F88
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
       mov       rdx,7FF94CFD1D88
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD1F70
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD1EA8
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD1F58
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF4EEB0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8BA018
       call      qword ptr [7FF94C827738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CEE4A68]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94CEEF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C995AB8]
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
       mov       rdx,7FF94CF4EEB0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD2820
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4F0F90
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
       mov       rdx,7FF94CFD2838
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C74E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4F0F98
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
       mov       rdx,7FF94CFD1BE8
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF94CD14CF0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC65FF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C82C1C8]
       int       3
M02_L84:
       test      r8,r8
       jne       near ptr M02_L19
       jmp       near ptr M02_L20
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
       call      qword ptr [7FF94CEEE850]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBB5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94CEEE880]
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
       call      qword ptr [7FF94CB4CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CEEF108]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
       int       3
M02_L93:
       call      qword ptr [7FF94CE14BD0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94CEEF180]
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
       mov       r11,7FF94C4F0F98
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
       call      qword ptr [7FF94CE1D350]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94CFD0E40
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94CFD1340
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEEF1F8]
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
       call      qword ptr [7FF94CE1D080]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE1D020]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CE8B098
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94CEEE9D0]
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
       mov       rdx,7FF94CFD0DF0
       call      qword ptr [7FF94C5AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF94CFD1748
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CE1D0C8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDE6300]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CEEED48]
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
       mov       r11,7FF94C4F0FA8
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
       mov       rdx,7FF94CFD1D88
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD1F70
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD1EA8
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFD1F58
       call      qword ptr [7FF94C827AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,2B240800AD0
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE4D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE4D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,2B240800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94CF1F228]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CE4D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE4D068]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CED5248
       call      qword ptr [7FF94CE4D110]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CE16260]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CF1ED90]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,2B240800AD0
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94D01B830
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE4D3C8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE4D3C8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94D01B834
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
       call      qword ptr [7FF94CA44808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF94C520FB0
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
       mov       rdx,7FF94D000DF8
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94D001750
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94D001BF0
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94D002818
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94D002858
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEE2818
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94D002870
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF94D002FB8
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF94CFDDF18
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF94CFDDFB0
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C520FB0
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
       mov       rdx,7FF94D001C00
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE4D2F0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE4D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE4D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94D001C48
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF94D001690
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE4D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CE4D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF94CFDF8E8
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF94C520F98
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
       mov       rdx,7FF94D001D90
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D001F78
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D001EB0
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D001F60
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF4DD80
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8EA018
       call      qword ptr [7FF94C857738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CF14A98]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94CF1F0D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C9C5AB8]
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
       mov       rdx,7FF94CF4DD80
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94D002828
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C520FA0
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
       mov       rdx,7FF94D002840
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C77E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C520FA8
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
       mov       rdx,7FF94D001BF0
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF94CD44CD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC96010]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C85C1C8]
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
       call      qword ptr [7FF94CF1E898]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBE5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94CF1E8C8]
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
       call      qword ptr [7FF94CB7CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CF1F150]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
       int       3
M02_L93:
       call      qword ptr [7FF94CE44BB8]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94CF1F1C8]
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
       mov       r11,7FF94C520FA8
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
       call      qword ptr [7FF94CE4D398]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94D000E48
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94D001348
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CF1F228]
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
       call      qword ptr [7FF94CE4D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE4D068]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CEBB0A8
       call      qword ptr [7FF94C857738]
       mov       rcx,rax
       call      qword ptr [7FF94CF1EA18]
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
       mov       rdx,7FF94D000DF8
       call      qword ptr [7FF94C5DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF94D001750
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CE4D110]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CE165C0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CF1ED90]
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
       mov       r11,7FF94C520FB8
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
       mov       rdx,7FF94D001D90
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D001F78
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D001EB0
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D001F60
       call      qword ptr [7FF94C857AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,1F044800AD0
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE2D3F8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE2D3F8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1F044800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94CEFF258]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CE2D0F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE2D098]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CEB5248
       call      qword ptr [7FF94CE2D140]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDF6240]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CEFEDC0]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,1F044800AD0
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94CFFAE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE2D3F8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE2D3F8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94CFFAE94
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
       call      qword ptr [7FF94CA24808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF94C500FB0
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
       mov       rdx,7FF94CFE1178
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94CFE1AD0
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94CFE1F70
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94CFE2B98
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94CFE2BD8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEC21F8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94CFE2BF0
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF94CFE3338
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF94CFBE118
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF94CFBE1B0
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C500FB0
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
       mov       rdx,7FF94CFE1F80
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE2D320]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE2D3F8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE2D3F8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94CFE1FC8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF94CFE1A10
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE2D350]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CE2D350]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF94CFBFAE8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF94C500F98
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
       mov       rdx,7FF94CFE2110
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE22F8
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE2230
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE22E0
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF2D678
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8CA018
       call      qword ptr [7FF94C837738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CEF4AE0]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94CEFF108]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C9A5AB8]
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
       mov       rdx,7FF94CF2D678
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE2BA8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C500FA0
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
       mov       rdx,7FF94CFE2BC0
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C75E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C500FA8
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
       mov       rdx,7FF94CFE1F70
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF94CD24CC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC75FF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C83C1C8]
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
       call      qword ptr [7FF94CEFE8C8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBC5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94CEFE8F8]
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
       call      qword ptr [7FF94CB5CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CEFF180]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
       int       3
M02_L93:
       call      qword ptr [7FF94CE24BE8]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94CEFF1F8]
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
       mov       r11,7FF94C500FA8
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
       call      qword ptr [7FF94CE2D3C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94CFE11C8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94CFE16C8
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEFF258]
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
       call      qword ptr [7FF94CE2D0F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE2D098]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CE9B098
       call      qword ptr [7FF94C837738]
       mov       rcx,rax
       call      qword ptr [7FF94CEFEA48]
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
       mov       rdx,7FF94CFE1178
       call      qword ptr [7FF94C5BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF94CFE1AD0
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CE2D140]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDF65A0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CEFEDC0]
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
       mov       r11,7FF94C500FB8
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
       mov       rdx,7FF94CFE2110
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE22F8
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE2230
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFE22E0
       call      qword ptr [7FF94C837AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,19EAE800AD0
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD8D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD8D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,19EAE800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94CEDF240]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CD8D038]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CD8CFD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CE94820
       call      qword ptr [7FF94CD8D080]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDF6AD0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CEDF108]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,19EAE800AD0
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94CFD3AF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD8D338]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD8D338]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94CFD3AFC
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
       call      qword ptr [7FF94CA04808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       jmp       short M02_L19
M02_L18:
       inc       r14d
M02_L19:
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
       je        short M02_L20
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF94C4E0FC0
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
       mov       rdx,7FF94CFC2F28
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94CFC3548
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94CFC39E8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94CFC1158
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94CFC1198
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEA2770
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94CFC11B0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF94CFC43B0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF94CF9E468
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF94CF9E500
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C4E0FC0
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
       mov       rdx,7FF94CFC39F8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CD8D260]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CD8D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD8D338]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94CFC3A40
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF94CFC3488
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CD8D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CD8D290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF94CF9F9F0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF94C4E0FA8
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
       mov       rdx,7FF94CFC3B88
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC3D70
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC3CA8
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC3D58
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF0D4E8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8AA018
       call      qword ptr [7FF94C817738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CED4A80]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94CEDF168]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C985AB8]
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
       mov       rdx,7FF94CF0D4E8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC1168
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4E0FB0
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
       mov       rdx,7FF94CFC1180
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C73E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4E0FB8
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
       mov       rdx,7FF94CFC39E8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF94CD04C30]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC45F50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C81C1C8]
       int       3
M02_L84:
       test      r8,r8
       je        near ptr M02_L18
       jmp       near ptr M02_L20
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
       call      qword ptr [7FF94CEDE880]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBA5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94CEDE8B0]
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
       call      qword ptr [7FF94CB3CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CEDEF70]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
       int       3
M02_L93:
       call      qword ptr [7FF94CD84B10]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94CEDF018]
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
       mov       r11,7FF94C4E0FB8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3292
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
       call      qword ptr [7FF94CD8D308]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94CFC2F78
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94CFC3478
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEDF240]
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
       call      qword ptr [7FF94CD8D038]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CD8CFD8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CE7A548
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDE9B8]
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
       mov       rdx,7FF94CFC2F28
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF94CFC3548
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CD8D080]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDF6E30]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CEDF108]
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
       mov       r11,7FF94C4E0FC8
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
       mov       rdx,7FF94CFC3B88
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC3D70
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC3CA8
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC3D58
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,15BE6C02AC8
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE3D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE3D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,15BE6C02AC8
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94CF0F210]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CE3D080]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE3D020]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CEC5248
       call      qword ptr [7FF94CE3D0C8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CE05F40]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CF0ED60]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,15BE6C02AC8
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94D009048
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE3D380]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE3D380]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94D00904C
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
       call      qword ptr [7FF94CA34808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF94C510FB0
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
       mov       rdx,7FF94CFF0730
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94CFF1088
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94CFF1528
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94CFF2150
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94CFF2190
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEE25F0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94CFF21A8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CD34C78]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC85FB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF94CFF28F0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF94CFCF618
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF94CFCF6B0
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C510FB0
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
       mov       rdx,7FF94CFF1538
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE3D2A8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE3D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CE3D2D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FF94CE3D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE3D380]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94CFF1580
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FF94CFF0FC8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FF94CFCF240
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF94C510F98
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
       mov       rdx,7FF94CFF16C8
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF18B0
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF17E8
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF1898
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF3DA80
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CF04A80]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94CF0F0A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C9B5AB8]
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
       mov       rdx,7FF94CF3DA80
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF2160
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C510FA0
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
       mov       rdx,7FF94CFF2178
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C76E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C510FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF94CFF1528
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C84C1C8]
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
       call      qword ptr [7FF94CF0EB98]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBD5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94CF0EBC8]
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
       call      qword ptr [7FF94CB6CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CF0F120]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
       int       3
M02_L93:
       call      qword ptr [7FF94CE34B58]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94CF0F198]
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
       mov       r11,7FF94C510FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3289
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
       call      qword ptr [7FF94CE3D350]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94CFF0780
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94CFF0C80
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CF0F210]
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
       call      qword ptr [7FF94CE3D080]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE3D020]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CEAB0A8
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94CF0EAA8]
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
       mov       rdx,7FF94CFF0730
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF94CFF1088
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CE3D0C8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CE062A0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CF0ED60]
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
       mov       r11,7FF94C510FB8
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
       mov       rdx,7FF94CFF16C8
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF18B0
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF17E8
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFF1898
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,29C49400AD0
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE0D500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE0D500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,29C49400AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94CEDF240]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CE0D200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE0D1A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CE95890
       call      qword ptr [7FF94CE0D248]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDD6850]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CEDEE20]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,29C49400AD0
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94CFBEB50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE0D500]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE0D500]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94CFBEB54
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
       call      qword ptr [7FF94CA04808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF94C4E0FB0
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
       mov       rdx,7FF94CFC17F0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94CFC1E10
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94CFC22B0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94CFC2ED8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94CFC2F18
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEB0080
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94CFC2F30
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CD04E28]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC56118]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF94CFC3678
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF94CF9F3E8
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF94CF9F480
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C4E0FB0
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
       mov       rdx,7FF94CFC22C0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE0D428]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE0D500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE0D500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94CFC2308
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FF94CFC1D50
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE0D458]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CE0D458]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF94CF9E8A0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF94C4E0F98
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
       mov       rdx,7FF94CFC2450
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2638
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2570
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2620
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF0D680
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8AA018
       call      qword ptr [7FF94C817738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CED4A98]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94CEDF168]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C985AB8]
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
       mov       rdx,7FF94CF0D680
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2EE8
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4E0FA0
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
       mov       rdx,7FF94CFC2F00
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C73E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4E0FA8
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF94CFC22B0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C81C1C8]
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
       call      qword ptr [7FF94CEDEBB0]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBA5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94CEDEBE0]
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
       call      qword ptr [7FF94CB3CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CEDEC88]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
       int       3
M02_L93:
       call      qword ptr [7FF94CE04D08]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94CEDED30]
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
       mov       r11,7FF94C4E0FA8
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3301
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
       call      qword ptr [7FF94CE0D4D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94CFC1840
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94CFC1D40
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEDF240]
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
       call      qword ptr [7FF94CE0D200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE0D1A0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CE7B5D0
       call      qword ptr [7FF94C817738]
       mov       rcx,rax
       call      qword ptr [7FF94CEDEA48]
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
       mov       rdx,7FF94CFC17F0
       call      qword ptr [7FF94C59C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF94CFC1E10
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CE0D248]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CDD6BB0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CEDEE20]
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
       mov       r11,7FF94C4E0FB8
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
       mov       rdx,7FF94CFC2450
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2638
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2570
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CFC2620
       call      qword ptr [7FF94C817AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,201CE802AC8
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,201CE802AC8
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94D0C4810]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CE1DCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE1DC98]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CEC6670
       call      qword ptr [7FF94CE1DD40]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94D04C8E0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94D0C4378]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,201CE802AC8
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94D0D5410
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94D0D5414
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
       call      qword ptr [7FF94CA34808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF94C511228
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
       mov       rdx,7FF94D02A8C8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF94D02B220
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF94D02B6C0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF94D0213A8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF94D0213E8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF94CEE0360
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF94D021400
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CD358F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC86028]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF94D02CA18
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF94D029830
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF94D0298C8
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF94C511228
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
       mov       rdx,7FF94D02B6D0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE1DF20]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF94D02B718
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FF94D02B160
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94CE1DF50]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CE1DF50]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF94D029210
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF94C511210
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
       mov       rdx,7FF94D02B860
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D02BA48
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D02B980
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D02BA30
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94CF36D58
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94C8DA018
       call      qword ptr [7FF94C847738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF94CF04AF8]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94D0C46C0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94C9B5AB8]
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
       mov       rdx,7FF94CF36D58
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF94D0213B8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C511218
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
       mov       rdx,7FF94D0213D0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF94C76E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C511220
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF94D02B6C0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF94C84C1C8]
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
       call      qword ptr [7FF94D0C41B0]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBD5DD0]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF94D0C41E0]
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
       call      qword ptr [7FF94CB6CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94CF0FB58]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M02_L93:
       call      qword ptr [7FF94CE15920]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94D0C4798]
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
       mov       r11,7FF94C511220
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3301
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M03_L30
       mov       rcx,rdi
       cmp       [rbx],rcx
       je        near ptr M03_L15
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M03_L06
M03_L01:
       cmp       [rbx],rax
       jne       near ptr M03_L21
       mov       rbp,[rbx+18]
       test      rbp,rbp
       jne       near ptr M03_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M03_L07
M03_L02:
       mov       rbp,[rbx+8]
       mov       r14,[rbx+10]
       cmp       qword ptr [rbp+10],0
       je        near ptr M03_L08
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       test      r14,r14
       je        near ptr M03_L34
       cmp       byte ptr [rbp+24],0
       jne       short M03_L03
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbp+24],1
M03_L03:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r15
M03_L04:
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       jmp       near ptr M03_L16
M03_L06:
       mov       rdx,7FF94D02A918
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M03_L01
M03_L07:
       mov       rdx,7FF94D02AE18
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L02
M03_L08:
       mov       rcx,rdx
       call      qword ptr [7FF94C5C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax]
       cmp       [rbp],bpl
       test      r14,r14
       jne       short M03_L10
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        near ptr M03_L31
M03_L09:
       mov       rcx,rdx
       call      qword ptr [7FF94C5C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M03_L10:
       cmp       r14,[rbp+10]
       jne       short M03_L12
M03_L11:
       jmp       near ptr M03_L04
M03_L12:
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0B0]
       test      r15,r15
       je        near ptr M03_L32
M03_L13:
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r15
       call      qword ptr [7FF94C5C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M03_L33
       test      r14,r14
       je        near ptr M03_L34
       cmp       byte ptr [r15+24],0
       jne       short M03_L14
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1DFF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+24],1
M03_L14:
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [7FF94CE1DC98]
       mov       rbp,rax
       jmp       near ptr M03_L11
M03_L15:
       mov       rbp,rbx
M03_L16:
       mov       rcx,[rbp+10]
       cmp       rcx,[rsi+10]
       jne       near ptr M03_L20
       mov       rcx,[rbp+8]
       cmp       qword ptr [rcx+10],0
       je        short M03_L19
       mov       rax,[rsi+8]
       cmp       qword ptr [rax+10],0
       je        short M03_L18
       mov       ecx,[rcx+20]
       mov       rax,[rsi+8]
       cmp       ecx,[rax+20]
       jg        short M03_L17
       mov       rcx,7FF94D03BD38
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L21
M03_L17:
       mov       rcx,7FF94D03BD34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF94CE1DC98]
       jmp       near ptr M03_L25
M03_L18:
       mov       rcx,7FF94D03BD30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       jmp       near ptr M03_L25
M03_L19:
       mov       rcx,7FF94D03BD28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       jmp       near ptr M03_L25
M03_L20:
       mov       rcx,7FF94D03BD2C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L21:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       je        short M03_L24
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        near ptr M03_L26
M03_L22:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M03_L27
       mov       rcx,rax
M03_L23:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FF94CE1DD40]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        near ptr M03_L29
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       mov       eax,ecx
       add       eax,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,eax
       vmulss    xmm0,xmm0,dword ptr [7FF94D0475F8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,ecx
       vucomiss  xmm0,xmm1
       jbe       short M03_L28
       mov       rcx,7FF94D03BD3C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L24:
       mov       rcx,7FF94D03BD40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CE1DCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L25:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L26:
       mov       rcx,rdi
       mov       rdx,7FF94D02A8C8
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L22
M03_L27:
       mov       rdx,7FF94D02B220
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L23
M03_L28:
       mov       rcx,7FF94D03BD44
       call      CORINFO_HELP_COUNTPROFILE32
M03_L29:
       mov       rcx,7FF94D03BD48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94D0C4378]
       jmp       short M03_L25
M03_L30:
       mov       ecx,4D7
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M03_L31:
       mov       rdx,7FF94D02B1E0
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L09
M03_L32:
       mov       rdx,7FF94D02B160
       call      qword ptr [7FF94C5CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M03_L13
M03_L33:
       mov       ecx,4AB
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
M03_L34:
       mov       ecx,873
       mov       rdx,7FF94CEAC280
       call      qword ptr [7FF94C847738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4090]
       int       3
; Total bytes of code 1073
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
       mov       r11,7FF94C511230
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
       mov       rdx,7FF94D02B860
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D02BA48
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D02B980
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF94D02BA30
       call      qword ptr [7FF94C847AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       je        near ptr M00_L15
       mov       rcx,1BFE4000B78
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
       je        near ptr M00_L12
       cmp       byte ptr [rbp+24],0
       jne       short M00_L00
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEF6958]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEF6958]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1BFE4000B78
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF94D0C5398]
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
       jne       short M00_L13
M00_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CEF6658]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CEF65F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       mov       ecx,873
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
       int       3
M00_L13:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF94CF63A98
       call      qword ptr [7FF94CEF66A0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L14
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CFC66B0]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L14:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94D0C5218]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,1BFE4000B78
       mov       rax,[rax]
       jmp       near ptr M00_L08
; Total bytes of code 527
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
M01_L00:
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       jne       short M01_L01
       mov       rcx,7FF94D109218
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEF6958]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEF6958]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF94D10921C
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
       je        near ptr M02_L54
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       near ptr M02_L23
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
       jne       near ptr M02_L55
M02_L02:
       test      rax,rax
       je        near ptr M02_L57
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r11
       jne       near ptr M02_L56
       mov       edi,[rax+20]
M02_L03:
       test      edi,edi
       je        near ptr M02_L22
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L17
       mov       rcx,[rbp+10]
M02_L05:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L74
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M02_L19
M02_L07:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M02_L67
       mov       ebx,[r14+20]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L68
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+68]
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
       jne       near ptr M02_L73
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
       jl        near ptr M02_L71
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jg        near ptr M02_L72
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
       call      qword ptr [7FF94CA14808]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
M02_L11:
       mov       [rsi+10],ebx
M02_L12:
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L22
M02_L13:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+10]
       mov       edi,[rsi+10]
       test      edi,edi
       jl        near ptr M02_L89
       cmp       edi,1
       jle       near ptr M02_L29
       mov       rcx,[rsi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+0D8]
       test      r14,r14
       je        near ptr M02_L25
M02_L14:
       mov       r15,[rsi+8]
       test      r15,r15
       jne       near ptr M02_L26
       mov       ecx,2
       call      qword ptr [7FF94C82C1C8]
       int       3
M02_L15:
       mov       rcx,rdx
       mov       rdx,7FF94D0EC2E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L16:
       mov       rcx,rax
       mov       rdx,7FF94D0ECC38
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L17:
       mov       rcx,rdx
       mov       rdx,7FF94D0ED0D8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L18:
       mov       rdx,7FF94D0AA630
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L19:
       mov       rcx,rdi
       mov       rdx,7FF94D0AA670
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L20:
       mov       rcx,rdi
       mov       rdx,7FF94CCF72F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L21:
       mov       rcx,rdi
       mov       rdx,7FF94D0AA688
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L22:
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
M02_L23:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       test      rax,rax
       je        near ptr M02_L84
M02_L24:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF94CD1C780]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94CC66028]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L25:
       mov       rdx,7FF94D0EDAA0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L26:
       cmp       [r15+8],edi
       jl        near ptr M02_L35
       add       r15,10
       mov       rcx,[r14+18]
       mov       r13,[rcx+28]
       test      r13,r13
       je        near ptr M02_L33
M02_L27:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L34
       mov       r12,[rcx+30]
       test      r12,r12
       je        near ptr M02_L34
M02_L28:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r15
       mov       [rbp-48],edi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M02_L29:
       inc       dword ptr [rsi+14]
       mov       edi,1
       mov       r14d,1
       test      rbx,rbx
       je        near ptr M02_L40
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M02_L40
       jmp       short M02_L31
M02_L30:
       inc       r14d
M02_L31:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       near ptr M02_L41
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
       je        short M02_L32
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF94C4F1648
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L30
M02_L32:
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
       jmp       near ptr M02_L30
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF94D0EB240
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L27
M02_L34:
       mov       rcx,r14
       mov       rdx,7FF94D0EB2D8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L28
M02_L35:
       mov       ecx,10
       call      qword ptr [7FF94CE24870]
       int       3
M02_L36:
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
       je        short M02_L38
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FF94C4F1648
       call      qword ptr [r11]
M02_L37:
       test      eax,eax
       je        short M02_L39
M02_L38:
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
M02_L39:
       inc       r14d
M02_L40:
       mov       ecx,[rsi+10]
       cmp       r14d,ecx
       jge       short M02_L41
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
       jne       near ptr M02_L36
       mov       rdx,7FF94D0ED0E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L36
M02_L41:
       mov       ebx,[rsi+10]
       sub       ebx,edi
       test      edi,edi
       jl        near ptr M02_L88
       test      ebx,ebx
       jl        near ptr M02_L89
       test      ebx,ebx
       jg        near ptr M02_L90
M02_L42:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+0D0]
       test      rax,rax
       je        near ptr M02_L50
       mov       rcx,rax
M02_L43:
       mov       rdx,rsi
       call      qword ptr [7FF94CEF6880]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rbp+10]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0B0]
       test      rdi,rdi
       je        near ptr M02_L51
M02_L44:
       mov       esi,[rsi+10]
       test      rbx,rbx
       je        near ptr M02_L92
       test      esi,esi
       je        near ptr M02_L53
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
       call      qword ptr [7FF94CEF68B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF94CEF68B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M02_L52
M02_L45:
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
M02_L46:
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
M02_L47:
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
       jne       short M02_L48
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEF6958]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CEF6958]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M02_L48:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L49:
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
M02_L50:
       mov       rdx,7FF94D0ED130
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rdx,7FF94D0ECB78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L44
M02_L52:
       mov       rcx,rdi
       mov       rdx,7FF94D0EA290
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L45
M02_L53:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L47
M02_L54:
       mov       ecx,885
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
       int       3
M02_L55:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L56:
       mov       rcx,rax
       mov       r11,7FF94C4F1630
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L57:
       mov       rdx,[rsi+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L58
       jmp       short M02_L59
M02_L58:
       mov       rcx,rsi
       mov       rdx,7FF94D0ED278
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M02_L59:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L62
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L60
       jmp       short M02_L61
M02_L60:
       mov       rcx,rsi
       mov       rdx,7FF94D0ED460
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L61:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M02_L03
M02_L62:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L63
       jmp       short M02_L64
M02_L63:
       mov       rcx,rsi
       mov       rdx,7FF94D0ED398
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L64:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rcx,[rsi+18]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M02_L65
       jmp       short M02_L66
M02_L65:
       mov       rcx,rsi
       mov       rdx,7FF94D0ED448
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
M02_L66:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jne       near ptr M02_L04
       jmp       near ptr M02_L22
M02_L67:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L68:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L69
       jmp       short M02_L70
M02_L69:
       mov       rcx,rdi
       mov       rdx,7FF94CD4F018
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L70:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L71:
       mov       ecx,80B
       mov       rdx,7FF94C8BA018
       call      qword ptr [7FF94C827738]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF94CD16CE8]
       int       3
M02_L72:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF94D0C5278]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF94C995AB8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L73:
       mov       rcx,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L11
M02_L74:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rcx,rdi
       mov       rdx,7FF94CD4F018
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L76:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M02_L77
       jmp       short M02_L78
M02_L77:
       mov       rcx,rdi
       mov       rdx,7FF94D0AA640
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L78:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L79:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4F1638
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L83
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M02_L80
       jmp       short M02_L81
M02_L80:
       mov       rcx,rdi
       mov       rdx,7FF94D0AA658
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L81:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L82
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L79
M02_L82:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF94C74E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L79
M02_L83:
       mov       rcx,[rbp-58]
       mov       r11,7FF94C4F1640
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L84:
       mov       rcx,rdx
       mov       rdx,7FF94D0ED0D8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L24
M02_L85:
       test      r8,r8
       je        near ptr M02_L30
       jmp       near ptr M02_L32
M02_L86:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [r11]
       jmp       near ptr M02_L37
M02_L87:
       test      r8,r8
       je        near ptr M02_L39
       jmp       near ptr M02_L38
M02_L88:
       call      qword ptr [7FF94D0C5068]
       int       3
M02_L89:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CBB5DD0]
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
       call      qword ptr [7FF94CB4CD38]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF94D0C40C0]
       jmp       near ptr M02_L42
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
       int       3
M02_L93:
       call      qword ptr [7FF94CD17A08]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L46
M02_L95:
       mov       ecx,847
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF94D0C5320]
       mov       rsi,rax
       jmp       near ptr M02_L49
M02_L99:
       mov       rsi,rdx
       jmp       near ptr M02_L49
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
       mov       r11,7FF94C4F1640
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3253
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
       call      qword ptr [7FF94CEF6928]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF94D0EC330
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF94D0EC830
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94D0C5398]
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
       call      qword ptr [7FF94CEF6658]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CEF65F8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF94CF49820
       call      qword ptr [7FF94C827738]
       mov       rcx,rax
       call      qword ptr [7FF94D0C4C90]
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
       mov       rdx,7FF94D0EC2E0
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
       mov       rdx,7FF94D0ECC38
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF94CEF66A0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF94CFC6A10]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF94D0C5218]
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
       mov       r11,7FF94C4F1650
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
       mov       rdx,7FF94D0ED278
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
       mov       rdx,7FF94D0ED460
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
       mov       rdx,7FF94D0ED398
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
       mov       rdx,7FF94D0ED448
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

