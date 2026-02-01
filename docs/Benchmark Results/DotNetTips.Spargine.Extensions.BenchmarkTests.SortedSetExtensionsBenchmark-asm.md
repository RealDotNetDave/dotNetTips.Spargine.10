## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,1F085400AD8
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC78CB40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBEA10A8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC78CB40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBEA10B0
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,1F085400AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F085400AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF5F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1C7720
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC8B4630]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8BE1D8]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBEA10A0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBEA10B8
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
       mov       r11,7FF7DBEA10B8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8BE2C8]
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
       call      qword ptr [7FF7DC8BE2B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC397930]
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
       call      qword ptr [7FF7DC78CB10]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC8B4FD8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,1A720C00AD8
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC77CB88]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBE910A8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC77CB88]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBE910B0
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,1A720C00AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A720C00AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF4F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1B7720
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC8A4690]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8AE238]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBE910A0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBE910B8
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
       mov       r11,7FF7DBE910B8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8AE328]
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
       call      qword ptr [7FF7DC8AE310]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC387930]
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
       call      qword ptr [7FF7DC77CB58]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC8A5038]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,20122000AD8
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC7BD050]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBEC10A8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC7BD050]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBEC10B0
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,20122000AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20122000AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF7F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1E7720
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC8D4678]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8DE238]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBEC10A0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBEC10B8
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
       mov       r11,7FF7DBEC10B8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8DE328]
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
       call      qword ptr [7FF7DC8DE310]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC3B7930]
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
       call      qword ptr [7FF7DC7BD020]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC8D5020]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,1B62F800AD8
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC7AD098]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBEB10A8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC7AD098]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBEB10B0
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,1B62F800AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B62F800AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF6F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1D7720
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC8C46A8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8CE268]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBEB10A0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBEB10B8
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
       mov       r11,7FF7DBEB10B8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8CE358]
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
       call      qword ptr [7FF7DC8CE340]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC3A7900]
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
       call      qword ptr [7FF7DC7AD068]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC8C5068]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,1E77E400AD8
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC79D098]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBEA10B8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC79D098]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBEA10C0
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,1E77E400AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E77E400AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF5F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1C7720
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC8B46A8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8BE238]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBEA10B0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBEA10C8
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
       mov       r11,7FF7DBEA10C8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8BE358]
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
       call      qword ptr [7FF7DC8BE340]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC397900]
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
       call      qword ptr [7FF7DC8BE238]
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
       call      qword ptr [7FF7DC8B5068]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,22882C00AD8
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC79D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBEA10A8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC79D128]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBEA10B0
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,22882C00AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22882C00AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF5F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1C7720
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC8B4630]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8BE208]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBEA10A0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBEA10B8
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
       mov       r11,7FF7DBEA10B8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8BE2F8]
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
       call      qword ptr [7FF7DC8BE2E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC397900]
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
       call      qword ptr [7FF7DC79D0F8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC8B4FF0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,1DBDAC00B10
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC8E56C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBEB13B0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC8E56C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBEB13B8
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DBF6F480]
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
       mov       rdx,1DBDAC00B08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DBDAC00B10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1D7720
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC817B10]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DC8EFC00]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBEB13A8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FF7DBEB13C0
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
       mov       r11,7FF7DBEB13C0
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 995
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DC8EFCF0]
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
       call      qword ptr [7FF7DC8EFCD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC3A7900]
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
       call      qword ptr [7FF7DC8E5698]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC81C4E0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmptyWithPredicate()
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
       mov       rax,22B54C00C50
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
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L10
M00_L05:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC96ECD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF7DBE91BF0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF7DC96ECD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF7DBE91BF8
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rdx,22B54C00C48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22B54C00C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF7DBF4F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF7DC1B7720
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF7DC716B38]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF7DCA34B10]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7DBE91BE8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF7DBE91C00
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
       mov       r11,7FF7DBE91C00
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF7DCA34C00]
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
       call      qword ptr [7FF7DCA34BE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC387930]
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
       call      qword ptr [7FF7DC96ECA0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF7DC7175B8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,24849C00AD0
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
       call      qword ptr [7FF7DC77CC90]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC77CC90]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,24849C00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DC8AEE68]
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
       call      qword ptr [7FF7DC77C990]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC77C930]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC59E220]
       mov       ecx,65
       mov       rdx,7FF7DC4064D0
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E3D40
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4064D0
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC70FE10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC70FE28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC851D78
       call      qword ptr [7FF7DC77C9D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC7F5C88]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DC8AE9B8]
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
       mov       rcx,7FF7DC9561D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC77CC90]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC77CC90]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DC9561DC
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
       call      qword ptr [7FF7DC4041D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBE90F88
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
       mov       rdx,7FF7DC9435D0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DC943F28
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DC9443D8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC944F60
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC944FA0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC880270
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC944FB8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF7DC945700
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF7DC940710
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF7DC9407A8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF7DBE90F88
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
       mov       rdx,7FF7DC9443E8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC77CBB8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC77CC90]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC77CC90]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DC944430
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF7DC943E68
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC77CBE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC77CBE8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF7DC942040
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF7DBE90F70
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
       mov       rdx,7FF7DC944578
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9446C0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9445F8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9446A8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC8D4CB8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1B7720
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8A4870]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC8AED00]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC385AB8]
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
       mov       rdx,7FF7DC8D4CB8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC944F70
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBE90F78
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
       mov       rdx,7FF7DC944F88
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBE90F80
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
       mov       rdx,7FF7DC9443D8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF7DC704678]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF4FD38]
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
       call      qword ptr [7FF7DC8AE4C0]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC595E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8AE4F0]
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
       call      qword ptr [7FF7DC51CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8AED78]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
       int       3
M02_L93:
       call      qword ptr [7FF7DC774558]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DC8AEDF0]
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
       mov       r11,7FF7DBE90F80
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
       call      qword ptr [7FF7DC77CC60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DC943620
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DC943B20
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8AEE68]
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
       call      qword ptr [7FF7DC77C990]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC77C930]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC605828
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE640]
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
       mov       rdx,7FF7DC9435D0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DC943F28
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC77C9D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC7F6110]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC8AE9B8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,288C8A70008
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
       call      qword ptr [7FF7DC8A7000]
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
       mov       r11,7FF7DBE90F90
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
       mov       rdx,7FF7DC944578
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9446C0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9445F8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9446A8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,1CE05800AD0
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
       call      qword ptr [7FF7DC7ACC78]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7ACC78]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1CE05800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DC8DEE98]
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
       call      qword ptr [7FF7DC7AC978]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC7AC918]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC5CE190]
       mov       ecx,65
       mov       rdx,7FF7DC4364D0
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4364D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC73FE10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC73FE28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC8812B0
       call      qword ptr [7FF7DC7AC9C0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC815768]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DC8DE9E8]
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
       mov       rcx,7FF7DC983F08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7ACC78]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7ACC78]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DC983F0C
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
       call      qword ptr [7FF7DC4341D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBEC0F88
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
       mov       rdx,7FF7DC972FA0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DC9738F8
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DC973DA8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC974930
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC974970
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC8B31D0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC974988
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF7DC9750D0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF7DC970938
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF7DC9709D0
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF7DBEC0F88
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
       mov       rdx,7FF7DC973DB8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC7ACBA0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC7ACBD0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC7ACBD0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FF7DC7ACC78]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7ACC78]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DC973E00
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L46:
       mov       rdx,7FF7DC973838
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rdi
       mov       rdx,7FF7DC971A10
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L42
M02_L49:
       mov       ecx,885
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF7DBEC0F70
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
       mov       rdx,7FF7DC973F48
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC974090
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC973FC8
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC974078
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC904D48
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1E7720
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8D48B8]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC8DED30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC3B5AB8]
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
       mov       rdx,7FF7DC904D48
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC974940
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEC0F78
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
       mov       rdx,7FF7DC974958
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEC0F80
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
       mov       rdx,7FF7DC973DA8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF7DC734600]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC5CE0A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF7FD38]
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
       call      qword ptr [7FF7DC8DE508]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC5C5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8DE538]
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
       call      qword ptr [7FF7DC54CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8DEDA8]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
       int       3
M02_L93:
       call      qword ptr [7FF7DC7A4558]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L41
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DC8DEE20]
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
       mov       r11,7FF7DBEC0F80
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3280
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
       call      qword ptr [7FF7DC7ACC48]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DC972FF0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DC9734F0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8DEE98]
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
       call      qword ptr [7FF7DC7AC978]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC7AC918]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC62B1B0
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE670]
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
       mov       rdx,7FF7DC972FA0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DC9738F8
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC7AC9C0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC815BF0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC8DE9E8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20E84AB0008
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
       call      qword ptr [7FF7DC8D7048]
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
       mov       r11,7FF7DBEC0F90
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
       mov       rdx,7FF7DC973F48
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC974090
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC973FC8
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC974078
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,1F93E800AD0
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
       call      qword ptr [7FF7DC7BD2C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7BD2C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1F93E800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DC8DEEC8]
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
       call      qword ptr [7FF7DC7BCFC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC7BCF60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC5CE718]
       mov       ecx,65
       mov       rdx,7FF7DC4364D0
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4364D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B43C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B43D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC893DD0
       call      qword ptr [7FF7DC7BD008]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC8268B8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DC8DEA30]
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
       mov       rcx,7FF7DC986C88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7BD2C0]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7BD2C0]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DC986C8C
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
       call      qword ptr [7FF7DC4341D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBEC0F88
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
       mov       rdx,7FF7DC9718E8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DC972240
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DC9726F0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC973278
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC9732B8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC87DF90
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC9732D0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF7DC973A18
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF7DC94EA18
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF7DC94EAB0
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF7DBEC0F88
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
       mov       rdx,7FF7DC972700
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC7BD1E8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC7BD2C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7BD2C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DC972748
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FF7DC972180
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC7BD218]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC7BD218]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF7DC970350
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF7DBEC0F70
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
       mov       rdx,7FF7DC972890
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9729D8
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC972910
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9729C0
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC912EB8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1E7720
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8D48E8]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC8DED78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC3B5AB8]
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
       mov       rdx,7FF7DC912EB8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC973288
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEC0F78
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
       mov       rdx,7FF7DC9732A0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEC0F80
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
       mov       rdx,7FF7DC9726F0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF7DC744BA0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC5CE628]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF7FD38]
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
       call      qword ptr [7FF7DC8DE538]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC5C5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8DE568]
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
       call      qword ptr [7FF7DC54CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8DEDF0]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
       int       3
M02_L93:
       call      qword ptr [7FF7DC7B4AF8]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DC8DEE68]
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
       mov       r11,7FF7DBEC0F80
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
       call      qword ptr [7FF7DC7BD290]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DC971938
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DC971E38
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8DEEC8]
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
       call      qword ptr [7FF7DC7BCFC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC7BCF60]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC656E80
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8DE6B8]
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
       mov       rdx,7FF7DC9718E8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DC972240
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC7BD008]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC826D40]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC8DEA30]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,239BD960008
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
       call      qword ptr [7FF7DC8D7078]
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
       mov       r11,7FF7DBEC0F90
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
       mov       rdx,7FF7DC972890
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9729D8
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC972910
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9729C0
       call      qword ptr [7FF7DBF7F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,1DE66800AD0
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
       call      qword ptr [7FF7DC80D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC80D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1DE66800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DC8AEEC8]
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
       call      qword ptr [7FF7DC80D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC80D068]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC59E820]
       mov       ecx,65
       mov       rdx,7FF7DC4064D0
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E3D40
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4064D0
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC804480]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC804498]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC8627A8
       call      qword ptr [7FF7DC80D110]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC7E6DF8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DC8AEA30]
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
       mov       rcx,7FF7DC9379F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC80D3C8]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC80D3C8]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DC9379F4
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
       call      qword ptr [7FF7DC4041D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBE90F88
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
       mov       rdx,7FF7DC941540
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DC941B60
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DC942010
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC942B98
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC942BD8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC84DCA0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC942BF0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FF7DC943338
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FF7DC91E9D0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FF7DC91EA68
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF7DBE90F88
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
       mov       rdx,7FF7DC942020
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC80D2F0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC80D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC80D320]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FF7DC80D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC80D3C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DC942068
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L46:
       mov       rdx,7FF7DC941AA0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rdi
       mov       rdx,7FF7DC91F1E0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L42
M02_L49:
       mov       ecx,885
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FF7DBE90F70
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
       mov       rdx,7FF7DC9421B0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9422F8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC942230
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9422E0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC8D2DD0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1B7720
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8A48E8]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC8AED78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC385AB8]
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
       mov       rdx,7FF7DC8D2DD0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC942BA8
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBE90F78
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
       mov       rdx,7FF7DC942BC0
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBE90F80
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
       mov       rdx,7FF7DC942010
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FF7DC714C60]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC59E730]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF4FD38]
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
       call      qword ptr [7FF7DC8AE538]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC595E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8AE568]
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
       call      qword ptr [7FF7DC51CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8AEDF0]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
       int       3
M02_L93:
       call      qword ptr [7FF7DC804BB8]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L41
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DC8AE928]
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
       mov       r11,7FF7DBE90F80
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
       call      qword ptr [7FF7DC80D398]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DC941590
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DC941A90
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8AEEC8]
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
       call      qword ptr [7FF7DC80D0C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC80D068]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC626C18
       call      qword ptr [7FF7DBF4F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8AE6A0]
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
       mov       rdx,7FF7DC941540
       call      qword ptr [7FF7DBF4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DC941B60
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC80D110]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC7E7280]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC8AEA30]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21EE5620008
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
       call      qword ptr [7FF7DC8A7078]
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
       mov       r11,7FF7DBE90F90
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
       mov       rdx,7FF7DC9421B0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9422F8
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC942230
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC9422E0
       call      qword ptr [7FF7DBF4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,2B638C00AD0
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
       call      qword ptr [7FF7DC79CD08]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC79CD08]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,2B638C00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DC8CEEB0]
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
       call      qword ptr [7FF7DC79CA08]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC79C9A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC5BE268]
       mov       ecx,65
       mov       rdx,7FF7DC4264D0
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC303D40
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4264D0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC72FE58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC72FE70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC871D78
       call      qword ptr [7FF7DC79CA50]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC816238]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DC8CEA00]
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
       mov       rcx,7FF7DC973FD8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC79CD08]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC79CD08]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DC973FDC
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
       call      qword ptr [7FF7DC4241D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBEB0F88
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
       mov       rdx,7FF7DC962F60
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DC9638B8
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DC963D68
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC9648F0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC964930
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC8A0340
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC964948
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC7246A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC5BE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF7DC965090
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF7DC961DF0
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF7DC961E88
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF7DBEB0F88
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
       mov       rdx,7FF7DC963D78
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC79CC30]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC79CD08]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC79CD08]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DC963DC0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FF7DC9637F8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC79CC60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC79CC60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF7DC961A18
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF7DBEB0F70
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
       mov       rdx,7FF7DC963F08
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC964050
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC963F88
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC964038
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC8F4CC8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1D7720
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8C48B8]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC8CED48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC3A5AB8]
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
       mov       rdx,7FF7DC8F4CC8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC964900
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0F78
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
       mov       rdx,7FF7DC964918
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0F80
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF7DC963D68
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF6FD38]
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
       call      qword ptr [7FF7DC8CE838]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC5B5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8CE868]
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
       call      qword ptr [7FF7DC53CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8CEDC0]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
       int       3
M02_L93:
       call      qword ptr [7FF7DC7945A0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DC8CEE38]
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
       mov       r11,7FF7DBEB0F80
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
       call      qword ptr [7FF7DC79CCD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DC962FB0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DC9634B0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8CEEB0]
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
       call      qword ptr [7FF7DC79CA08]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC79C9A8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC625828
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE748]
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
       mov       rdx,7FF7DC962F60
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DC9638B8
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC79CA50]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC8166C0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC8CEA00]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2F6B7A80008
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
       call      qword ptr [7FF7DC8C70D8]
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
       mov       r11,7FF7DBEB0F90
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
       mov       rdx,7FF7DC963F08
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC964050
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC963F88
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC964038
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,1D1FFC02010
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
       call      qword ptr [7FF7DC82CC60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC82CC60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1D1FFC02010
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DC8CEF40]
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
       call      qword ptr [7FF7DC82C960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC82C900]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC5BE028]
       mov       ecx,65
       mov       rdx,7FF7DC4264D0
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4264D0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC72FE10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC72FE28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC873DD0
       call      qword ptr [7FF7DC82C9A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC7F4B68]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DC8CEA90]
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
       mov       rcx,7FF7DC9732C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC82CC60]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC82CC60]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DC9732CC
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
       call      qword ptr [7FF7DC4241D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBEB0F88
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
       mov       rdx,7FF7DC961160
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DC961AB8
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DC961F68
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC962AF0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC962B30
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC8B0AF0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC962B48
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC7244B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC5BDF38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF7DC963290
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF7DC93FFC0
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF7DC960088
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF7DBEB0F88
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
       mov       rdx,7FF7DC961F78
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC82CB88]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC82CC60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC82CC60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DC961FC0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FF7DC9619F8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC82CBB8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC82CBB8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF7DC93FBE8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF7DBEB0F70
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
       mov       rdx,7FF7DC962108
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962250
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962188
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962238
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC8F2DE8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1D7720
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8C4990]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC8CEDD8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC3A5AE8]
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
       mov       rdx,7FF7DC8F2DE8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962B00
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0F78
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
       mov       rdx,7FF7DC962B18
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0F80
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF7DC961F68
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF6FD38]
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
       call      qword ptr [7FF7DC8CE8C8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC5B5E30]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8CE8F8]
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
       call      qword ptr [7FF7DC53CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8CEE50]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
       int       3
M02_L93:
       call      qword ptr [7FF7DC824558]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DC8CEEC8]
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
       mov       r11,7FF7DBEB0F80
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
       call      qword ptr [7FF7DC82CC30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DC9611B0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DC9616B0
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8CEF40]
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
       call      qword ptr [7FF7DC82C960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC82C900]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC61C6F8
       call      qword ptr [7FF7DBF6F210]
       mov       rcx,rax
       call      qword ptr [7FF7DC8CE7D8]
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
       mov       rdx,7FF7DC961160
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DC961AB8
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC82C9A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC7F5220]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC8CEA90]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,212949D0008
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
       call      qword ptr [7FF7DC8C7180]
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
       mov       r11,7FF7DBEB0F90
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
       mov       rdx,7FF7DC962108
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962250
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962188
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC962238
       call      qword ptr [7FF7DBF6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,29394000AF8
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
       call      qword ptr [7FF7DC8F5500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8F5500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,29394000AF8
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DCA54870]
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
       call      qword ptr [7FF7DC8F5200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC8F51A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC5CE220]
       mov       ecx,65
       mov       rdx,7FF7DC4364D0
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4364D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC825320]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC825338]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DC90EBE8
       call      qword ptr [7FF7DC8F5248]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC9D5968]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DCA54720]
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
       mov       rcx,7FF7DCA3E380
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8F5500]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8F5500]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DCA3E384
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
       call      qword ptr [7FF7DC4341D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBEC1408
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
       mov       rdx,7FF7DCA485F0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DCA48C10
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DCA490C0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DC95FA28
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DC95FA68
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC8472B8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DC95FA80
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC734660]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC5CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF7DCA499E8
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF7DCA45078
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF7DCA45110
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
       mov       r11,7FF7DBEC1408
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
       mov       rdx,7FF7DCA490D0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC8F5428]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC8F5500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8F5500]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DCA49118
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FF7DCA48B50
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DC8F5458]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC8F5458]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF7DCA46610
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF7DBEC13F0
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
       mov       rdx,7FF7DCA49260
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
       mov       rdx,7FF7DCA493A8
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
       mov       rdx,7FF7DCA492E0
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
       mov       rdx,7FF7DCA49390
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FF7DC920950
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC1E7720
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC827A98]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DCA54780]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC3B5AB8]
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
       mov       rdx,7FF7DC920950
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF7DC95FA38
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEC13F8
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
       mov       rdx,7FF7DC95FA50
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF7DBF771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEC1400
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF7DCA490C0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF7FD38]
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
       call      qword ptr [7FF7DCA541B0]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC5C5E00]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DCA541E0]
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
       call      qword ptr [7FF7DC54CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC8FF390]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
       int       3
M02_L93:
       call      qword ptr [7FF7DC825B90]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DCA54630]
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
       mov       r11,7FF7DBEC1400
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
       call      qword ptr [7FF7DC8F54D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DCA48640
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DCA48B40
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DCA54870]
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
       call      qword ptr [7FF7DC8F5200]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC8F51A0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC635828
       call      qword ptr [7FF7DBF7F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA544C8]
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
       mov       rdx,7FF7DCA485F0
       call      qword ptr [7FF7DBF7F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FF7DCA48C10
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC8F5248]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC9D5D30]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DCA54720]
       jmp       near ptr M03_L12
; Total bytes of code 527
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,2D412F30008
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
       call      qword ptr [7FF7DC8F76C0]
       int       3
; Total bytes of code 231
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
       mov       r11,7FF7DBEC1410
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
       mov       rdx,7FF7DCA49260
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
       mov       rdx,7FF7DCA493A8
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
       mov       rdx,7FF7DCA492E0
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
       mov       rdx,7FF7DCA49390
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
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
       mov       rcx,1EDD1000C40
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
       call      qword ptr [7FF7DC9ADB60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC9ADB60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1EDD1000C40
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF7DCA74C78]
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
       call      qword ptr [7FF7DC9AD860]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC9AD800]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FF7DC5DE268]
       mov       ecx,65
       mov       rdx,7FF7DC4464D0
       call      qword ptr [7FF7DBF8F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3240A0
       call      qword ptr [7FF7DBF8F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4464D0
       call      qword ptr [7FF7DBF8F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7465B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7465C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FF7DCA21CC8
       call      qword ptr [7FF7DC9AD8A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC975928]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7DCA74AC8]
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
       mov       rcx,7FF7DCA86F00
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC9ADB60]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC9ADB60]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FF7DCA86F04
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
       call      qword ptr [7FF7DC4441D0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FF7DBED1720
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
       mov       rdx,7FF7DCA5CEB0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FF7DCA5D808
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FF7DCA5DCC0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FF7DCA1A8F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FF7DCA1A938
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FF7DC72DB98
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FF7DCA1A950
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
       call      qword ptr [7FF7DC74C2D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DC5DE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FF7DCA5E5E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FF7DCA5BE18
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FF7DCA5BEB0
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
       mov       r11,7FF7DBED1720
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
       mov       rdx,7FF7DCA5DCD0
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
       call      qword ptr [7FF7DC9ADA88]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC9ADAB8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF7DC9ADAB8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FF7DC9ADB60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC9ADB60]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF7DCA5DD18
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FF7DCA5D748
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FF7DCA5AE10
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
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FF7DBED1708
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
       mov       rdx,7FF7DCA5DE60
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
       mov       rdx,7FF7DCA5DFA8
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
       mov       rdx,7FF7DCA5DEE0
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
       mov       rdx,7FF7DCA5DF90
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
       mov       rdx,7FF7DC78EDA8
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
       mov       rdx,7FF7DC1F7720
       call      qword ptr [7FF7DBF8F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC746AF0]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DCA74B28]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC3C5AE8]
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
       mov       rdx,7FF7DC78EDA8
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
       mov       rdx,7FF7DCA1A908
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBED1710
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
       mov       rdx,7FF7DCA1A920
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
       call      qword ptr [7FF7DBF871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBED1718
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FF7DCA5DCC0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FF7DBF8FD38]
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
       call      qword ptr [7FF7DCA74918]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DC5D5E30]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FF7DC8644C8]
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
       call      qword ptr [7FF7DC55CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF7DC9AF288]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
       int       3
M02_L93:
       call      qword ptr [7FF7DC864C18]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FF7DCA74C00]
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
       mov       r11,7FF7DBED1718
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
       call      qword ptr [7FF7DC9ADB30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FF7DCA5CF00
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FF7DCA5D400
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7DCA74C78]
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
       call      qword ptr [7FF7DC9AD860]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF7DC9AD800]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FF7DC645828
       call      qword ptr [7FF7DBF8F210]
       mov       rcx,rax
       call      qword ptr [7FF7DCA74540]
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
       mov       rdx,7FF7DCA5CEB0
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
       mov       rdx,7FF7DCA5D808
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF7DC9AD8A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF7DC975CF0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7DCA74AC8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22E50190008
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
       call      qword ptr [7FF7DC86ED48]
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
       mov       r11,7FF7DBED1728
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
       mov       rdx,7FF7DCA5DE60
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
       mov       rdx,7FF7DCA5DFA8
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
       mov       rdx,7FF7DCA5DEE0
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
       mov       rdx,7FF7DCA5DF90
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

