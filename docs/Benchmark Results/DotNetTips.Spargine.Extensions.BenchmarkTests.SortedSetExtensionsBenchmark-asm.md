## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,1EA2C0009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L27
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L31
       add       r14,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L03
M00_L02:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L08
M00_L06:
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
M00_L07:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L06
M00_L08:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L09:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L15
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L15
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L15
M00_L10:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D2278E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L13
       mov       rbx,[rdx+8]
M00_L11:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L14
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L12:
       test      r14d,r14d
       je        short M00_L10
       jmp       near ptr M00_L25
M00_L13:
       xor       ebx,ebx
       jmp       short M00_L11
M00_L14:
       xor       r14d,r14d
       jmp       short M00_L12
M00_L15:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L16
       mov       r11,7FFE0C970FF8
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D2278E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFE0C971000
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L21
M00_L18:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L19
       xor       ebx,ebx
       jmp       short M00_L20
M00_L19:
       mov       rbx,[rcx+8]
M00_L20:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L22
M00_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L24
M00_L22:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L23
       xor       r14d,r14d
       jmp       short M00_L24
M00_L23:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L24:
       test      r14d,r14d
       je        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L26:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L27:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L01
M00_L28:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EA2C0009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EA2C0009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE0CC4C2D0]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCD9308
       call      qword ptr [7FFE0CC4C060]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D22E7D8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2B7030]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C970FF0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFE0C971008
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C971008
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1008
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
       call      qword ptr [7FFE0D2B7120]
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
       call      qword ptr [7FFE0D2B7108]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CD8CCD8]
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
       call      qword ptr [7FFE0D2278B8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0CFDEF88]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,1F5094009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L27
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L31
       add       r14,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L03
M00_L02:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L08
M00_L06:
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
M00_L07:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L06
M00_L08:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L09:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L15
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L15
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L15
M00_L10:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D226718]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L13
       mov       rbx,[rdx+8]
M00_L11:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L14
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L12:
       test      r14d,r14d
       je        short M00_L10
       jmp       near ptr M00_L25
M00_L13:
       xor       ebx,ebx
       jmp       short M00_L11
M00_L14:
       xor       r14d,r14d
       jmp       short M00_L12
M00_L15:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L16
       mov       r11,7FFE0C980F30
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D226718]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFE0C980F38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L21
M00_L18:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L19
       xor       ebx,ebx
       jmp       short M00_L20
M00_L19:
       mov       rbx,[rcx+8]
M00_L20:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L22
M00_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L24
M00_L22:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L23
       xor       r14d,r14d
       jmp       short M00_L24
M00_L23:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L24:
       test      r14d,r14d
       je        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L26:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L27:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L01
M00_L28:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F5094009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F5094009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE0CC57A20]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCD9308
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D22DAE8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2D4348]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C980F28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFE0C980F40
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C980F40
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1008
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
       call      qword ptr [7FFE0D2D4480]
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
       call      qword ptr [7FFE0D2D4468]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CDA7B40]
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
       call      qword ptr [7FFE0D2266E8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0D22E640]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,267B7C029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L27
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L31
       add       r14,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L03
M00_L02:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L08
M00_L06:
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
M00_L07:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L06
M00_L08:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L09:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L15
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L15
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L15
M00_L10:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D236EF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L13
       mov       rbx,[rdx+8]
M00_L11:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L14
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L12:
       test      r14d,r14d
       je        short M00_L10
       jmp       near ptr M00_L25
M00_L13:
       xor       ebx,ebx
       jmp       short M00_L11
M00_L14:
       xor       r14d,r14d
       jmp       short M00_L12
M00_L15:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L16
       mov       r11,7FFE0C990F30
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D236EF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFE0C990F38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L21
M00_L18:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L19
       xor       ebx,ebx
       jmp       short M00_L20
M00_L19:
       mov       rbx,[rcx+8]
M00_L20:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L22
M00_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L24
M00_L22:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L23
       xor       r14d,r14d
       jmp       short M00_L24
M00_L23:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L24:
       test      r14d,r14d
       je        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L26:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L27:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L01
M00_L28:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,267B7C029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,267B7C029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE0CC67A20]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCE9308
       call      qword ptr [7FFE0CC677B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D23E040]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2E47C8]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C990F28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFE0C990F40
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C990F40
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1008
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
       call      qword ptr [7FFE0D2E4900]
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
       call      qword ptr [7FFE0D2E48E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CDB7B40]
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
       call      qword ptr [7FFE0D236EC8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0D23EB98]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,15A08C009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L27
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L31
       add       r14,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L03
M00_L02:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L08
M00_L06:
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
M00_L07:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L06
M00_L08:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L09:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L15
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L15
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L15
M00_L10:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D246EF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L13
       mov       rbx,[rdx+8]
M00_L11:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L14
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L12:
       test      r14d,r14d
       je        short M00_L10
       jmp       near ptr M00_L25
M00_L13:
       xor       ebx,ebx
       jmp       short M00_L11
M00_L14:
       xor       r14d,r14d
       jmp       short M00_L12
M00_L15:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L16
       mov       r11,7FFE0C9A0F30
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D246EF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFE0C9A0F38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L21
M00_L18:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L19
       xor       ebx,ebx
       jmp       short M00_L20
M00_L19:
       mov       rbx,[rcx+8]
M00_L20:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L22
M00_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L24
M00_L22:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L23
       xor       r14d,r14d
       jmp       short M00_L24
M00_L23:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L24:
       test      r14d,r14d
       je        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L26:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L27:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L01
M00_L28:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,15A08C009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15A08C009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE0CC77A20]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCF9308
       call      qword ptr [7FFE0CC777B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D24E040]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2F47C8]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C9A0F28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFE0C9A0F40
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C9A0F40
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1008
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
       call      qword ptr [7FFE0D2F4900]
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
       call      qword ptr [7FFE0D2F48E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CDC7B40]
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
       call      qword ptr [7FFE0D246EC8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0D24EB98]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,188A2C029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L27
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L31
       add       r14,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L03
M00_L02:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L08
M00_L06:
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
M00_L07:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L06
M00_L08:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L09:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L15
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L15
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L15
M00_L10:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D226F40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L13
       mov       rbx,[rdx+8]
M00_L11:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L14
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L12:
       test      r14d,r14d
       je        short M00_L10
       jmp       near ptr M00_L25
M00_L13:
       xor       ebx,ebx
       jmp       short M00_L11
M00_L14:
       xor       r14d,r14d
       jmp       short M00_L12
M00_L15:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L16
       mov       r11,7FFE0C980F40
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D226F40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFE0C980F48
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L21
M00_L18:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L19
       xor       ebx,ebx
       jmp       short M00_L20
M00_L19:
       mov       rbx,[rcx+8]
M00_L20:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L22
M00_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L24
M00_L22:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L23
       xor       r14d,r14d
       jmp       short M00_L24
M00_L23:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L24:
       test      r14d,r14d
       je        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L26:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L27:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L01
M00_L28:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,188A2C029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,188A2C029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE0CC57A20]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCD9308
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D22E0B8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2D47F8]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C980F38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFE0C980F50
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C980F50
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1008
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
       call      qword ptr [7FFE0D2D4930]
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
       call      qword ptr [7FFE0D2D4918]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CDA7B40]
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
       call      qword ptr [7FFE0D2D47F8]
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
       call      qword ptr [7FFE0D22EC10]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,1FE4C4029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L27
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L31
       add       r14,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L03
M00_L02:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L28
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L08
M00_L06:
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
M00_L07:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L06
M00_L08:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L09:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L15
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L15
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L15
M00_L10:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D216F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L13
       mov       rbx,[rdx+8]
M00_L11:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L14
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L12:
       test      r14d,r14d
       je        short M00_L10
       jmp       near ptr M00_L25
M00_L13:
       xor       ebx,ebx
       jmp       short M00_L11
M00_L14:
       xor       r14d,r14d
       jmp       short M00_L12
M00_L15:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L16
       mov       r11,7FFE0C970F30
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D216F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFE0C970F38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L21
M00_L18:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L19
       xor       ebx,ebx
       jmp       short M00_L20
M00_L19:
       mov       rbx,[rcx+8]
M00_L20:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L22
M00_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L24
M00_L22:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L23
       xor       r14d,r14d
       jmp       short M00_L24
M00_L23:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L24:
       test      r14d,r14d
       je        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L26:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L27:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L01
M00_L28:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1FE4C4029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FE4C4029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE0CC47A20]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCC9308
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D21E0B8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2C4840]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C970F28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFE0C970F40
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C970F40
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1008
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
       call      qword ptr [7FFE0D2C4978]
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
       call      qword ptr [7FFE0D2C4960]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CD97B40]
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
       call      qword ptr [7FFE0D216F28]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0D21EC10]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,27710000A20
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L31
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L02
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L01
       add       r14,10
       jmp       near ptr M00_L25
M00_L01:
       call      qword ptr [7FFE0CC47A20]
       int       3
M00_L02:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L05
M00_L03:
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
M00_L04:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L03
M00_L05:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L06:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L12
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L12
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L12
M00_L07:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D21CB10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L10
       mov       rbx,[rdx+8]
M00_L08:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L11
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L09:
       test      r14d,r14d
       je        short M00_L07
       jmp       near ptr M00_L22
M00_L10:
       xor       ebx,ebx
       jmp       short M00_L08
M00_L11:
       xor       r14d,r14d
       jmp       short M00_L09
M00_L12:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L13
       mov       r11,7FFE0C9710D8
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D21CB10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFE0C9710E0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L18
M00_L15:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L16
       xor       ebx,ebx
       jmp       short M00_L17
M00_L16:
       mov       rbx,[rcx+8]
M00_L17:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L19
M00_L18:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L21
M00_L19:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L20
       xor       r14d,r14d
       jmp       short M00_L21
M00_L20:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L21:
       test      r14d,r14d
       je        near ptr M00_L12
M00_L22:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L23:
       mov       ebx,1
       jmp       short M00_L28
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
       jne       short M00_L29
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
M00_L28:
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
M00_L29:
       mov       ebx,1
       jmp       short M00_L28
M00_L30:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27710000A18
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27710000A20
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       short M00_L28
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCC9308
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D0FF660]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D2C4D20]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C9710D0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFE0C9710E8
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C9710E8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 991
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
       call      qword ptr [7FFE0D2C4E40]
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
       call      qword ptr [7FFE0D2C4E28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CD97B40]
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
       call      qword ptr [7FFE0D21CAE0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0D21E6E8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       mov       rax,2360D800BB8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L31
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L02
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L01
       add       r14,10
       jmp       near ptr M00_L25
M00_L01:
       call      qword ptr [7FFE0CC57A20]
       int       3
M00_L02:
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rbx+24]
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
       je        short M00_L05
M00_L03:
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
M00_L04:
       mov       rdx,r15
       test      rdx,rdx
       jne       short M00_L03
M00_L05:
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],edi
       mov       byte ptr [r14+24],0
M00_L06:
       mov       [rbp-40],r14
       cmp       qword ptr [rbp-40],0
       je        short M00_L12
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       jne       short M00_L12
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L12
M00_L07:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D3A54D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L10
       mov       rbx,[rdx+8]
M00_L08:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       je        short M00_L11
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L09:
       test      r14d,r14d
       je        short M00_L07
       jmp       near ptr M00_L22
M00_L10:
       xor       ebx,ebx
       jmp       short M00_L08
M00_L11:
       xor       r14d,r14d
       jmp       short M00_L09
M00_L12:
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-40]
       cmp       [rcx],rdx
       je        short M00_L13
       mov       r11,7FFE0C981948
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFE0D3A54D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFE0C981950
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L18
M00_L15:
       lea       rcx,[rax+8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L16
       xor       ebx,ebx
       jmp       short M00_L17
M00_L16:
       mov       rbx,[rcx+8]
M00_L17:
       mov       rdx,rbx
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       je        short M00_L19
M00_L18:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14d,eax
       mov       rax,[rbp-40]
       jmp       short M00_L21
M00_L19:
       mov       rdi,[rbx+30]
       test      rdi,rdi
       jne       short M00_L20
       xor       r14d,r14d
       jmp       short M00_L21
M00_L20:
       cmp       dword ptr [rdi+8],0
       setg      r14b
       movzx     r14d,r14b
M00_L21:
       test      r14d,r14d
       je        near ptr M00_L12
M00_L22:
       mov       rcx,[rbp-40]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L36
M00_L23:
       mov       ebx,1
       jmp       short M00_L28
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
       jne       short M00_L29
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L26
M00_L27:
       xor       ebx,ebx
M00_L28:
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
M00_L29:
       mov       ebx,1
       jmp       short M00_L28
M00_L30:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2360D800BB0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFE0CA36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2360D800BB8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       short M00_L28
M00_L32:
       mov       ecx,783
       mov       rdx,7FFE0CCD9308
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE0D136C10]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFE0D3A69D0]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFE0C981940
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFE0C981958
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L38
       mov       rcx,rax
       mov       r11,7FFE0C981958
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 991
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
       call      qword ptr [7FFE0D3A6AF0]
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
       call      qword ptr [7FFE0D3A6AD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CDA7B40]
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
       call      qword ptr [7FFE0D3A54A0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFE0D1377F8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C980DF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D2F97D8],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1EC6B400A58
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C980E00
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1EC55401FE0
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D1BF9A8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L21
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D5368]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        near ptr M00_L19
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D227138]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D5380]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L18
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        near ptr M00_L22
M00_L11:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L12:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L14
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D227138]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L13:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D2D5350]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L14:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L16
M00_L15:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L13
M00_L16:
       mov       ecx,r8d
       jmp       short M00_L15
M00_L17:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L18:
       mov       r14,r13
       jmp       near ptr M00_L34
M00_L19:
       test      r13,r13
       je        short M00_L20
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L20:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L21:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       near ptr M00_L07
M00_L22:
       mov       ecx,edx
       jmp       near ptr M00_L11
M00_L23:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2D5008]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L28
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L24
       mov       r13,[r14+10]
M00_L24:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L27
M00_L25:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L26:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L27:
       mov       ecx,edx
       jmp       short M00_L25
M00_L28:
       test      r13,r13
       je        short M00_L29
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L29:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        short M00_L31
M00_L30:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L26
M00_L31:
       mov       eax,edx
       jmp       short M00_L30
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        near ptr M00_L17
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L12
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C980E08
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L23
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2D5008]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L09
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D5398]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D53B0]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D5368]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D53C8]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D227150]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D226F40]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D258808
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2271B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFBEBE0]
       mov       ecx,65
       mov       rdx,7FFE0CE2B048
       call      qword ptr [7FFE0CC577B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CD05508
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE2B048
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D22DE18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D22DE30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2241
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
       je        short M02_L00
       test      rdi,rdi
       je        short M02_L01
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,847
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D227198]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D227198]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D2D5020]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L48
M04_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M04_L19
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L49
       test      r13d,r13d
       je        near ptr M04_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M04_L20
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L21
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L53
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M04_L22
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L63
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L23
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L24
       test      r13d,r13d
       jne       near ptr M04_L67
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L68
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L76
       cmp       esi,1
       jle       near ptr M04_L15
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D8]
       test      rdi,rdi
       je        near ptr M04_L27
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M04_L71
       cmp       [r14+8],esi
       jl        near ptr M04_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L28
M04_L13:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L29
M04_L14:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L15:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L34
M04_L16:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L35
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L72
       test      r8,r8
       je        short M04_L17
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C980E20
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L18
M04_L17:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L18:
       inc       edi
       jmp       near ptr M04_L16
M04_L19:
       mov       rcx,rdx
       mov       rdx,7FFE0D2CAEE8
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFE0D23C4A8
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFE0D2CB228
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFE0D2CAF28
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFE0D2CB898
       call      qword ptr [7FFE0CC57B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L24:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L26
M04_L25:
       cmp       [rdi],rax
       jne       near ptr M04_L66
       cmp       [rdi+8],r13d
       jb        near ptr M04_L67
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L26:
       mov       rcx,rdx
       mov       rdx,7FFE0D2CB8B8
       call      qword ptr [7FFE0CC57B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFE0D2CBA18
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFE0D2C75D0
       call      qword ptr [7FFE0CC57B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFE0D2C7668
       call      qword ptr [7FFE0CC57B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L14
M04_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L73
       test      r14,r14
       je        near ptr M04_L74
       test      r8,r8
       je        short M04_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C980E20
       call      qword ptr [r11]
M04_L31:
       test      eax,eax
       je        short M04_L33
M04_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L33:
       inc       edi
M04_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L35
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L30
       mov       rcx,rdx
       mov       rdx,7FFE0D2CAF48
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L30
M04_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L75
       test      ebx,ebx
       jl        near ptr M04_L76
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L42
M04_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D227090]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L43
M04_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       near ptr M04_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M04_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M04_L85
       cmp       byte ptr [r14+24],0
       jne       short M04_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D227198]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D227198]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M04_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L41:
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
M04_L42:
       mov       rcx,rdx
       mov       rdx,7FFE0D2CB030
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L37
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFE0D2CB050
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L38
M04_L44:
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
       call      qword ptr [7FFE0D2270F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D2270F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L47
M04_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M04_L39
M04_L47:
       mov       rcx,rsi
       mov       rdx,7FFE0D2C9220
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L45
M04_L48:
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
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFB6178]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFE0D2C20B0
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L55
M04_L54:
       mov       edx,4
M04_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CBAE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2D5458]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D05AD08]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C980E10
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFE0D2CB250
       call      qword ptr [7FFE0CA3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M04_L61
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L58
M04_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CBAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C980E18
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L65
M04_L64:
       mov       eax,4
M04_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CBAE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFE0D2D5188]
       int       3
M04_L67:
       call      qword ptr [7FFE0CBA7198]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0CFBE550]
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFE0CE3CC00]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFE0CC5C240]
       int       3
M04_L72:
       test      r8,r8
       je        near ptr M04_L18
       jmp       near ptr M04_L17
M04_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L31
M04_L74:
       test      r8,r8
       je        near ptr M04_L33
       jmp       near ptr M04_L32
M04_L75:
       call      qword ptr [7FFE0D2D4B58]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFB6178]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFE0D2D4B88]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF4D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D2D5200]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M04_L81:
       call      qword ptr [7FFE0D13DC80]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L46
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0D049058
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D4D20]
       int       3
M04_L86:
       call      qword ptr [7FFE0D2D5020]
       mov       rbx,rax
       jmp       near ptr M04_L41
M04_L87:
       mov       rbx,rcx
       jmp       near ptr M04_L41
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C980E18
       call      qword ptr [r11]
M04_L90:
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,22CEA390008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFE0D2D4258]
       int       3
; Total bytes of code 244
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
       jmp       qword ptr [7FFE0CA35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C970DF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D2E97F8],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1AABB800A58
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C970DF8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1AAA5801FE0
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D1AF418]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L11
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5338]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        short M00_L09
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D217180]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5350]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L30
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L11:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       short M00_L07
M00_L12:
       test      r13,r13
       je        short M00_L13
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L15:
       mov       ecx,edx
       jmp       short M00_L14
M00_L16:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2C4FD8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L21
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r14+10]
M00_L17:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L19:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L20:
       mov       ecx,edx
       jmp       short M00_L18
M00_L21:
       test      r13,r13
       je        short M00_L22
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        near ptr M00_L31
M00_L23:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L19
M00_L24:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L26
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D217180]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D2C5320]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L26:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L25
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L30:
       mov       r14,r13
       jmp       short M00_L34
M00_L31:
       mov       eax,edx
       jmp       near ptr M00_L23
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        short M00_L29
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L24
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C970E00
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2C4FD8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L12
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5368]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5380]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5338]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5398]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D217198]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D216F88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D249048
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFAEB80]
       mov       ecx,65
       mov       rdx,7FFE0CE1B048
       call      qword ptr [7FFE0CC477B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CCF5508
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE1B048
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D21DDE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D21DE00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2227
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
       je        short M02_L00
       test      rdi,rdi
       je        short M02_L01
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,847
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D2C4FF0]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L48
M04_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M04_L19
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L49
       test      r13d,r13d
       je        near ptr M04_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M04_L20
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L21
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L53
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M04_L22
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L63
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L23
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L24
       test      r13d,r13d
       jne       near ptr M04_L67
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L68
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L76
       cmp       esi,1
       jle       near ptr M04_L15
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D8]
       test      rdi,rdi
       je        near ptr M04_L27
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M04_L71
       cmp       [r14+8],esi
       jl        near ptr M04_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L28
M04_L13:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L29
M04_L14:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L15:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L34
M04_L16:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L35
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L72
       test      r8,r8
       je        short M04_L17
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C970E18
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L18
M04_L17:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L18:
       inc       edi
       jmp       near ptr M04_L16
M04_L19:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB108
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFE0D22C9B8
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFE0D2BB448
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB148
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFE0D2BBAB8
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L24:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L26
M04_L25:
       cmp       [rdi],rax
       jne       near ptr M04_L66
       cmp       [rdi+8],r13d
       jb        near ptr M04_L67
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L26:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BBAD8
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFE0D2BBC38
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFE0D2B7910
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFE0D2B79A8
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L14
M04_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L73
       test      r14,r14
       je        near ptr M04_L74
       test      r8,r8
       je        short M04_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C970E18
       call      qword ptr [r11]
M04_L31:
       test      eax,eax
       je        short M04_L33
M04_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L33:
       inc       edi
M04_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L35
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L30
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB168
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L30
M04_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L75
       test      ebx,ebx
       jl        near ptr M04_L76
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L42
M04_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D2170D8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L43
M04_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       near ptr M04_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M04_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M04_L85
       cmp       byte ptr [r14+24],0
       jne       short M04_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M04_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L41:
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
M04_L42:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB250
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L37
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB270
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L38
M04_L44:
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
       call      qword ptr [7FFE0D217138]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D217138]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L47
M04_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M04_L39
M04_L47:
       mov       rcx,rsi
       mov       rdx,7FFE0D2B9440
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L45
M04_L48:
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
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFA6178]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFE0D2B2370
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L55
M04_L54:
       mov       edx,4
M04_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CB9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2C5428]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D04ACC8]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C970E08
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFE0D2BB470
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M04_L61
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L58
M04_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CB9E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C970E10
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L65
M04_L64:
       mov       eax,4
M04_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CB9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFE0D2C5158]
       int       3
M04_L67:
       call      qword ptr [7FFE0CB97198]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0CFAE9E8]
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFE0CE2CC00]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFE0CC4C240]
       int       3
M04_L72:
       test      r8,r8
       jne       near ptr M04_L17
       jmp       near ptr M04_L18
M04_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L31
M04_L74:
       test      r8,r8
       je        near ptr M04_L33
       jmp       near ptr M04_L32
M04_L75:
       call      qword ptr [7FFE0D2C4B28]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFA6178]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFE0D2C4B58]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF3D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D2C51D0]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M04_L81:
       call      qword ptr [7FFE0D12DC20]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L46
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4CF0]
       int       3
M04_L86:
       call      qword ptr [7FFE0D2C4FF0]
       mov       rbx,rax
       jmp       near ptr M04_L41
M04_L87:
       mov       rbx,rcx
       jmp       near ptr M04_L41
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C970E10
       call      qword ptr [r11]
M04_L90:
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,1EB3A740008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFE0D2C4348]
       int       3
; Total bytes of code 244
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
       jmp       qword ptr [7FFE0CA25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFE0CA46850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C990D20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D27B910],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,19996801FE0
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C990D28
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,19996801FC8
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D167D10]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       short M00_L07
M00_L05:
       test      r13,r13
       je        short M00_L06
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        short M00_L04
M00_L07:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       near ptr M00_L18
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L11
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D11F558]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L10:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D23D8D8]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L11:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L13
M00_L12:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L10
M00_L13:
       mov       ecx,r8d
       jmp       short M00_L12
M00_L14:
       cmp       qword ptr [r14+10],0
       jne       short M00_L16
       mov       r13,r12
M00_L15:
       mov       r14,r13
       jmp       near ptr M00_L34
M00_L16:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D23D8F0]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        near ptr M00_L05
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r12+18]
M00_L17:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D11F558]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L18:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D23D908]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L15
M00_L19:
       test      r13,r13
       je        short M00_L20
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L20:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L22
M00_L21:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L22:
       mov       ecx,edx
       jmp       short M00_L21
M00_L23:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23D068]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L28
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L24
       mov       r13,[r14+10]
M00_L24:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L27
M00_L25:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L26:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L27:
       mov       ecx,edx
       jmp       short M00_L25
M00_L28:
       test      r13,r13
       je        short M00_L29
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L29:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        short M00_L31
M00_L30:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L26
M00_L31:
       mov       eax,edx
       jmp       short M00_L30
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        near ptr M00_L14
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L09
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C990D30
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L23
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23D068]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L19
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D23D920]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D23D938]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D23D8F0]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D23D950]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D11F570]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D11F360]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D215858
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D11F5D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFC6EB0]
       mov       ecx,65
       mov       rdx,7FFE0CE3B048
       call      qword ptr [7FFE0CC677B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CD15508
       call      qword ptr [7FFE0CC677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA47840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE3B048
       call      qword ptr [7FFE0CC677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA47840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D23D4D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D23D4E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2224
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
       je        short M02_L00
       test      rdi,rdi
       je        short M02_L01
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,847
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D11F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D11F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D23D080]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L50
M04_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M04_L13
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L51
       test      r13d,r13d
       je        near ptr M04_L52
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M04_L14
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE0CBBF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L59
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L55
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M04_L16
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L65
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L17
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L18
       test      r13d,r13d
       jne       near ptr M04_L69
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L72
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L71
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L70
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L77
       cmp       esi,1
       jle       near ptr M04_L25
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D8]
       test      rdi,rdi
       je        near ptr M04_L21
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       jne       near ptr M04_L22
       mov       ecx,2
       call      qword ptr [7FFE0CC6C240]
       int       3
M04_L13:
       mov       rcx,rdx
       mov       rdx,7FFE0D1FF830
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L14:
       mov       rdx,7FFE0D1FFAE8
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L15:
       mov       rdx,7FFE0D1FFC00
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L16:
       mov       rcx,rdx
       mov       rdx,7FFE0D1FF870
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L17:
       mov       rcx,rdi
       mov       rdx,7FFE0D280280
       call      qword ptr [7FFE0CC67B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L18:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L20
M04_L19:
       cmp       [rdi],rax
       jne       near ptr M04_L68
       cmp       [rdi+8],r13d
       jb        near ptr M04_L69
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L20:
       mov       rcx,rdx
       mov       rdx,7FFE0D2802A0
       call      qword ptr [7FFE0CC67B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L19
M04_L21:
       mov       rcx,r14
       mov       rdx,7FFE0D280518
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L22:
       cmp       [r14+8],esi
       jl        near ptr M04_L31
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L29
M04_L23:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L30
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L30
M04_L24:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L25:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L36
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L36
M04_L26:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L37
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L73
       test      r8,r8
       je        short M04_L27
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C990D08
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L28
M04_L27:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L28:
       inc       edi
       jmp       near ptr M04_L26
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFE0D2806C8
       call      qword ptr [7FFE0CC67B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L23
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFE0D280760
       call      qword ptr [7FFE0CC67B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L24
M04_L31:
       mov       ecx,10
       call      qword ptr [7FFE0D23D338]
       int       3
M04_L32:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L74
       test      r14,r14
       je        near ptr M04_L75
       test      r8,r8
       je        short M04_L34
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C990D08
       call      qword ptr [r11]
M04_L33:
       test      eax,eax
       je        short M04_L35
M04_L34:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L35:
       inc       edi
M04_L36:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L37
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L32
       mov       rcx,rdx
       mov       rdx,7FFE0D1FF890
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L32
M04_L37:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L76
       test      ebx,ebx
       jl        near ptr M04_L77
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L38:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L46
M04_L39:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D11F4B0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L47
M04_L40:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       je        near ptr M04_L49
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
       call      qword ptr [7FFE0D11F510]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D11F510]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L48
M04_L41:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L42:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M04_L43:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M04_L85
       cmp       byte ptr [rbx+24],0
       jne       short M04_L44
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D11F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D11F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L44:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L45:
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
M04_L46:
       mov       rcx,rdx
       mov       rdx,7FFE0D1FF978
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L39
M04_L47:
       mov       rcx,rdx
       mov       rdx,7FFE0D1FF998
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rsi
       mov       rdx,7FFE0D1FD0F0
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L41
M04_L49:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L43
M04_L50:
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
M04_L51:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFC6178]
       int       3
M04_L52:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M04_L53
       jmp       short M04_L54
M04_L53:
       mov       rdx,7FFE0D1FFAF0
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L54:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L55:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L58
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L56
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L57
M04_L56:
       mov       edx,4
M04_L57:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CBBE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L58:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23D800]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L59:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D01BDE0]
       mov       [rbp-58],rax
M04_L60:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C990CF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L64
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M04_L61
       jmp       short M04_L62
M04_L61:
       mov       rcx,r14
       mov       rdx,7FFE0D1FFC28
       call      qword ptr [7FFE0CA4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L62:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M04_L63
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L60
M04_L63:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CBBE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L60
M04_L64:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C990D00
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L65:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L66
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L67
M04_L66:
       mov       eax,4
M04_L67:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CBBE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L68:
       call      qword ptr [7FFE0D23D290]
       int       3
M04_L69:
       call      qword ptr [7FFE0CBB7198]
       int       3
M04_L70:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L71:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0D115368]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L72:
       call      qword ptr [7FFE0CE4CC00]
       int       3
M04_L73:
       test      r8,r8
       je        near ptr M04_L28
       jmp       near ptr M04_L27
M04_L74:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L33
M04_L75:
       test      r8,r8
       je        near ptr M04_L35
       jmp       near ptr M04_L34
M04_L76:
       call      qword ptr [7FFE0D23D350]
       int       3
M04_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFC6178]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF5D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D23D410]
       jmp       near ptr M04_L38
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M04_L81:
       call      qword ptr [7FFE0D115F98]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L42
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0CFFA138
       call      qword ptr [7FFE0CC677B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D23CBA0]
       int       3
M04_L86:
       call      qword ptr [7FFE0D23D080]
       mov       rsi,rax
       jmp       near ptr M04_L45
M04_L87:
       mov       rsi,rcx
       jmp       near ptr M04_L45
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C990D00
       call      qword ptr [r11]
M04_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2795
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,1DA2BA10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFE0D23E6D0]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FFE0CA45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C970DF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D2E98D0],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,24E95800A58
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C970DF8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,24E7F801FE0
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D1AF6F8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L11
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5350]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        short M00_L09
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D217180]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5368]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L30
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L11:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       short M00_L07
M00_L12:
       test      r13,r13
       je        short M00_L13
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L15:
       mov       ecx,edx
       jmp       short M00_L14
M00_L16:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2C4FD8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L21
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r14+10]
M00_L17:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L19:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L20:
       mov       ecx,edx
       jmp       short M00_L18
M00_L21:
       test      r13,r13
       je        short M00_L22
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        near ptr M00_L31
M00_L23:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L19
M00_L24:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L26
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D217180]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D2C5338]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L26:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L25
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L30:
       mov       r14,r13
       jmp       short M00_L34
M00_L31:
       mov       eax,edx
       jmp       near ptr M00_L23
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        short M00_L29
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L24
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C970E00
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2C4FD8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L12
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5380]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5398]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C5350]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2C53B0]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D217198]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D216F88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D249048
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFAEB80]
       mov       ecx,65
       mov       rdx,7FFE0CE1B048
       call      qword ptr [7FFE0CC477B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CCF5508
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE1B048
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D21DD40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D21DD58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2227
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
       je        short M02_L00
       test      rdi,rdi
       je        short M02_L01
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,847
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D2C4FF0]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L48
M04_L00:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M04_L19
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L49
       test      r13d,r13d
       je        near ptr M04_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M04_L20
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L21
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L53
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M04_L22
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L63
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L23
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L24
       test      r13d,r13d
       jne       near ptr M04_L67
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L68
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L76
       cmp       esi,1
       jle       near ptr M04_L15
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D8]
       test      rdi,rdi
       je        near ptr M04_L27
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M04_L71
       cmp       [r14+8],esi
       jl        near ptr M04_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L28
M04_L13:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L29
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L29
M04_L14:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L15:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L34
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L34
M04_L16:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L35
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L72
       test      r8,r8
       je        short M04_L17
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C970E18
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L18
M04_L17:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L18:
       inc       edi
       jmp       near ptr M04_L16
M04_L19:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB108
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFE0D22C9B8
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFE0D2BB448
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB148
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFE0D2BBAB8
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L24:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L26
M04_L25:
       cmp       [rdi],rax
       jne       near ptr M04_L66
       cmp       [rdi+8],r13d
       jb        near ptr M04_L67
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L26:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BBAD8
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFE0D2BBC38
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFE0D2B7940
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFE0D2B79D8
       call      qword ptr [7FFE0CC47B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L14
M04_L30:
       mov       rax,r14
       cmp       r12d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r12d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L73
       test      r13,r13
       je        near ptr M04_L74
       test      r8,r8
       je        short M04_L32
       mov       rcx,r13
       mov       rdx,r8
       mov       r11,7FFE0C970E18
       call      qword ptr [r11]
M04_L31:
       test      eax,eax
       je        short M04_L33
M04_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L33:
       inc       edi
M04_L34:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L35
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r14,[r15+8]
       mov       r8,r14
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r8+rax*8+10]
       mov       r13,rax
       lea       eax,[rdi-1]
       mov       r12d,eax
       cmp       r12d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L30
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB168
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L30
M04_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L75
       test      ebx,ebx
       jl        near ptr M04_L76
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L42
M04_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D2170D8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L43
M04_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       near ptr M04_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M04_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [r14+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M04_L85
       cmp       byte ptr [r14+24],0
       jne       short M04_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2171E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M04_L40:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L41:
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
M04_L42:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB250
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L37
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFE0D2BB270
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L38
M04_L44:
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
       call      qword ptr [7FFE0D217138]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D217138]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L47
M04_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
       mov       r14,rbx
       jmp       near ptr M04_L39
M04_L47:
       mov       rcx,rsi
       mov       rdx,7FFE0D2B9D68
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L45
M04_L48:
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
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFA6178]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFE0D2B2318
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L55
M04_L54:
       mov       edx,4
M04_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CB9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2C5440]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D04ACC8]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C970E08
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFE0D2BB470
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M04_L61
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L58
M04_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CB9E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C970E10
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L65
M04_L64:
       mov       eax,4
M04_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CB9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFE0D2C5158]
       int       3
M04_L67:
       call      qword ptr [7FFE0CB97198]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0CFAE538]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFE0CE2CC00]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFE0CC4C240]
       int       3
M04_L72:
       test      r8,r8
       je        near ptr M04_L18
       jmp       near ptr M04_L17
M04_L73:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [r11]
       jmp       near ptr M04_L31
M04_L74:
       test      r8,r8
       je        near ptr M04_L33
       jmp       near ptr M04_L32
M04_L75:
       call      qword ptr [7FFE0D2C4B40]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFA6178]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFE0D2C4B70]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF3D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D2C51D0]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M04_L81:
       call      qword ptr [7FFE0D12DC20]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L46
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0D038FA0
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2C4EE8]
       int       3
M04_L86:
       call      qword ptr [7FFE0D2C4FF0]
       mov       rbx,rax
       jmp       near ptr M04_L41
M04_L87:
       mov       rbx,rcx
       jmp       near ptr M04_L41
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C970E10
       call      qword ptr [r11]
M04_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2809
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,28F14670008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFE0D2C4228]
       int       3
; Total bytes of code 244
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
       jmp       qword ptr [7FFE0CA25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFE0CA16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C960CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D24BDD8],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,16BC8401FE8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C960D00
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,16BC8401FC8
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D1361D8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L11
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D20DA28]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        short M00_L09
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D0EF558]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D20DA40]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L30
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L11:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       short M00_L07
M00_L12:
       test      r13,r13
       je        short M00_L13
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L15:
       mov       ecx,edx
       jmp       short M00_L14
M00_L16:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D20D4A0]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L21
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r14+10]
M00_L17:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L19:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L20:
       mov       ecx,edx
       jmp       short M00_L18
M00_L21:
       test      r13,r13
       je        short M00_L22
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        near ptr M00_L31
M00_L23:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L19
M00_L24:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L26
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D0EF558]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D20DA10]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L26:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L25
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L30:
       mov       r14,r13
       jmp       short M00_L34
M00_L31:
       mov       eax,edx
       jmp       near ptr M00_L23
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        short M00_L29
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L24
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C960D08
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D20D4A0]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L12
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D20DA58]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D20DA70]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D20DA28]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D20DA88]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D0EF570]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D0EF360]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D1E50E0
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D0EF5D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CF96EB0]
       mov       ecx,65
       mov       rdx,7FFE0CE0B048
       call      qword ptr [7FFE0CC377B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CCE5508
       call      qword ptr [7FFE0CC377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE0B048
       call      qword ptr [7FFE0CC377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D20D9E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D20D9F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2228
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
       je        near ptr M02_L01
       test      rdi,rdi
       je        short M02_L00
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,851
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M02_L01:
       mov       ecx,847
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D0EF5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D0EF5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D20D4B8]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L13
M04_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M04_L14
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L51
       test      r13d,r13d
       je        near ptr M04_L52
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L16
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE0CB8F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L59
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L55
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M04_L17
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L65
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L18
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L19
       test      r13d,r13d
       jne       near ptr M04_L69
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L72
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L71
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L70
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L77
       cmp       esi,1
       jle       near ptr M04_L26
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D8]
       test      rdi,rdi
       je        near ptr M04_L22
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       jne       near ptr M04_L23
       mov       ecx,2
       call      qword ptr [7FFE0CC3C240]
       int       3
M04_L13:
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
M04_L14:
       mov       rcx,rdx
       mov       rdx,7FFE0D250B88
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L15:
       mov       rdx,7FFE0D250E40
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L16:
       mov       rdx,7FFE0D250F58
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L17:
       mov       rcx,rdx
       mov       rdx,7FFE0D250BC8
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L18:
       mov       rcx,rdi
       mov       rdx,7FFE0D2515C8
       call      qword ptr [7FFE0CC37B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L19:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L21
M04_L20:
       cmp       [rdi],rax
       jne       near ptr M04_L68
       cmp       [rdi+8],r13d
       jb        near ptr M04_L69
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L21:
       mov       rcx,rdx
       mov       rdx,7FFE0D2515E8
       call      qword ptr [7FFE0CC37B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L20
M04_L22:
       mov       rcx,r14
       mov       rdx,7FFE0D251860
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L23:
       cmp       [r14+8],esi
       jl        near ptr M04_L32
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L30
M04_L24:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L31
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L31
M04_L25:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L26:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L37
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L37
       jmp       short M04_L28
M04_L27:
       inc       edi
M04_L28:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L38
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L73
       test      r8,r8
       je        short M04_L29
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C960D20
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L27
M04_L29:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M04_L27
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFE0D251A10
       call      qword ptr [7FFE0CC37B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L24
M04_L31:
       mov       rcx,rdi
       mov       rdx,7FFE0D251AA8
       call      qword ptr [7FFE0CC37B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L25
M04_L32:
       mov       ecx,10
       call      qword ptr [7FFE0D20D770]
       int       3
M04_L33:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L74
       test      r14,r14
       je        near ptr M04_L75
       test      r8,r8
       je        short M04_L35
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C960D20
       call      qword ptr [r11]
M04_L34:
       test      eax,eax
       je        short M04_L36
M04_L35:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L36:
       inc       edi
M04_L37:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L38
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L33
       mov       rcx,rdx
       mov       rdx,7FFE0D250BE8
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L33
M04_L38:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L76
       test      ebx,ebx
       jl        near ptr M04_L77
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L39:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L47
M04_L40:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D0EF4B0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L48
M04_L41:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       je        near ptr M04_L50
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
       call      qword ptr [7FFE0D0EF510]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D0EF510]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L49
M04_L42:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L43:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M04_L44:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M04_L85
       cmp       byte ptr [rbx+24],0
       jne       short M04_L45
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D0EF5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D0EF5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L45:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L46:
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
M04_L47:
       mov       rcx,rdx
       mov       rdx,7FFE0D250CD0
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rdx
       mov       rdx,7FFE0D250CF0
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L41
M04_L49:
       mov       rcx,rsi
       mov       rdx,7FFE0D1CE228
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L42
M04_L50:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L44
M04_L51:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CF96178]
       int       3
M04_L52:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M04_L53
       jmp       short M04_L54
M04_L53:
       mov       rdx,7FFE0D250E48
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L54:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L55:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L58
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L56
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L57
M04_L56:
       mov       edx,4
M04_L57:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CB8E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L58:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D20DB30]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L59:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0CFEBDE0]
       mov       [rbp-58],rax
M04_L60:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C960D10
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L64
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M04_L61
       jmp       short M04_L62
M04_L61:
       mov       rcx,r14
       mov       rdx,7FFE0D250F80
       call      qword ptr [7FFE0CA1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L62:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M04_L63
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L60
M04_L63:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CB8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L60
M04_L64:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C960D18
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L65:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L66
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L67
M04_L66:
       mov       eax,4
M04_L67:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CB8E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L68:
       call      qword ptr [7FFE0D20D6C8]
       int       3
M04_L69:
       call      qword ptr [7FFE0CB87198]
       int       3
M04_L70:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L71:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0D0E5350]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L72:
       call      qword ptr [7FFE0CE1CC00]
       int       3
M04_L73:
       test      r8,r8
       je        near ptr M04_L27
       jmp       near ptr M04_L29
M04_L74:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L34
M04_L75:
       test      r8,r8
       je        near ptr M04_L36
       jmp       near ptr M04_L35
M04_L76:
       call      qword ptr [7FFE0D20D788]
       int       3
M04_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CF96178]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF2D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D20D848]
       jmp       near ptr M04_L39
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M04_L81:
       call      qword ptr [7FFE0D0E5F80]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L43
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0CFCA138
       call      qword ptr [7FFE0CC377B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D20D008]
       int       3
M04_L86:
       call      qword ptr [7FFE0D20D4B8]
       mov       rsi,rax
       jmp       near ptr M04_L46
M04_L87:
       mov       rsi,rcx
       jmp       near ptr M04_L46
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C960D18
       call      qword ptr [r11]
M04_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2801
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,1AC5D450008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFE0D20DD88]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FFE0CA15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C9A0CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D28BEB8],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,18EE7C01FE8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C9A0D00
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,18EE7C01FC8
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D1767F8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L11
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D24DA58]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        short M00_L09
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D12F558]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D24DA70]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L30
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L11:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       short M00_L07
M00_L12:
       test      r13,r13
       je        short M00_L13
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L15:
       mov       ecx,edx
       jmp       short M00_L14
M00_L16:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D24D5D8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L21
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r14+10]
M00_L17:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L19:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L20:
       mov       ecx,edx
       jmp       short M00_L18
M00_L21:
       test      r13,r13
       je        short M00_L22
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        near ptr M00_L31
M00_L23:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L19
M00_L24:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L26
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D12F558]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D24DA40]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L26:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L25
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L30:
       mov       r14,r13
       jmp       short M00_L34
M00_L31:
       mov       eax,edx
       jmp       near ptr M00_L23
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        short M00_L29
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L24
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C9A0D08
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D24D5D8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L12
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D24DA88]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D24DAA0]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D24DA58]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D24DAB8]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D12F570]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D12F360]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D2250E0
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D12F5D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFD6EB0]
       mov       ecx,65
       mov       rdx,7FFE0CE4B048
       call      qword ptr [7FFE0CC777B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CD25508
       call      qword ptr [7FFE0CC777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA57840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE4B048
       call      qword ptr [7FFE0CC777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA57840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D24DA10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D24DA28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2227
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
       je        short M02_L00
       test      rdi,rdi
       je        short M02_L01
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,847
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D12F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D12F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D24D4B8]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L13
M04_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+70]
       test      r14,r14
       je        near ptr M04_L14
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L51
       test      r13d,r13d
       je        near ptr M04_L52
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L16
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L59
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L55
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+78]
       test      rdi,rdi
       je        near ptr M04_L17
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L65
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L18
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L19
       test      r13d,r13d
       jne       near ptr M04_L69
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L72
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L71
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L70
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L77
       cmp       esi,1
       jle       near ptr M04_L26
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0D8]
       test      rdi,rdi
       je        near ptr M04_L22
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       jne       near ptr M04_L23
       mov       ecx,2
       call      qword ptr [7FFE0CC7C240]
       int       3
M04_L13:
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
M04_L14:
       mov       rcx,rdx
       mov       rdx,7FFE0D292CA0
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L15:
       mov       rdx,7FFE0D292EA0
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L16:
       mov       rdx,7FFE0D292FB8
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L17:
       mov       rcx,rdx
       mov       rdx,7FFE0D292CE0
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L18:
       mov       rcx,rdi
       mov       rdx,7FFE0D293628
       call      qword ptr [7FFE0CC77B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L19:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L21
M04_L20:
       cmp       [rdi],rax
       jne       near ptr M04_L68
       cmp       [rdi+8],r13d
       jb        near ptr M04_L69
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L21:
       mov       rcx,rdx
       mov       rdx,7FFE0D293648
       call      qword ptr [7FFE0CC77B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L20
M04_L22:
       mov       rcx,r14
       mov       rdx,7FFE0D2938C0
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L23:
       cmp       [r14+8],esi
       jl        near ptr M04_L32
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L30
M04_L24:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L31
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L31
M04_L25:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L26:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L37
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L37
       jmp       short M04_L28
M04_L27:
       inc       edi
M04_L28:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L38
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L73
       test      r8,r8
       je        short M04_L29
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C9A0D20
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L27
M04_L29:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M04_L27
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFE0D293A70
       call      qword ptr [7FFE0CC77B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L24
M04_L31:
       mov       rcx,rdi
       mov       rdx,7FFE0D293B08
       call      qword ptr [7FFE0CC77B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L25
M04_L32:
       mov       ecx,10
       call      qword ptr [7FFE0D24D3F8]
       int       3
M04_L33:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L74
       test      r14,r14
       je        near ptr M04_L75
       test      r8,r8
       je        short M04_L35
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C9A0D20
       call      qword ptr [r11]
M04_L34:
       test      eax,eax
       je        short M04_L36
M04_L35:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L36:
       inc       edi
M04_L37:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L38
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M04_L33
       mov       rcx,rdx
       mov       rdx,7FFE0D292D00
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L33
M04_L38:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L76
       test      ebx,ebx
       jl        near ptr M04_L77
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L39:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M04_L47
M04_L40:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D12F4B0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M04_L48
M04_L41:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       je        near ptr M04_L50
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
       call      qword ptr [7FFE0D12F510]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D12F510]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L49
M04_L42:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L43:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M04_L44:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M04_L85
       cmp       byte ptr [rbx+24],0
       jne       short M04_L45
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D12F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D12F5B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L45:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L46:
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
M04_L47:
       mov       rcx,rdx
       mov       rdx,7FFE0D292D48
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rdx
       mov       rdx,7FFE0D292D68
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L41
M04_L49:
       mov       rcx,rsi
       mov       rdx,7FFE0D20BB18
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L42
M04_L50:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L44
M04_L51:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFD6178]
       int       3
M04_L52:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M04_L53
       jmp       short M04_L54
M04_L53:
       mov       rdx,7FFE0D292EA8
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L54:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L55:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L58
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L56
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L57
M04_L56:
       mov       edx,4
M04_L57:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CBCE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L58:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D24DB48]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L59:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D02BDE0]
       mov       [rbp-58],rax
M04_L60:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C9A0D10
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L64
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M04_L61
       jmp       short M04_L62
M04_L61:
       mov       rcx,r14
       mov       rdx,7FFE0D292FE0
       call      qword ptr [7FFE0CA5C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L62:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M04_L63
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L60
M04_L63:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CBCE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L60
M04_L64:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C9A0D18
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L65:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L66
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L67
M04_L66:
       mov       eax,4
M04_L67:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CBCE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L68:
       call      qword ptr [7FFE0D24D7D0]
       int       3
M04_L69:
       call      qword ptr [7FFE0CBC7198]
       int       3
M04_L70:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L71:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0D125398]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L72:
       call      qword ptr [7FFE0CE5CC00]
       int       3
M04_L73:
       test      r8,r8
       je        near ptr M04_L27
       jmp       near ptr M04_L29
M04_L74:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L34
M04_L75:
       test      r8,r8
       je        near ptr M04_L36
       jmp       near ptr M04_L35
M04_L76:
       call      qword ptr [7FFE0D24D3E0]
       int       3
M04_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFD6178]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF6D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D24D410]
       jmp       near ptr M04_L39
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M04_L81:
       call      qword ptr [7FFE0D125FC8]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L43
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0D00A138
       call      qword ptr [7FFE0CC777B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D24C630]
       int       3
M04_L86:
       call      qword ptr [7FFE0D24D4B8]
       mov       rsi,rax
       jmp       near ptr M04_L46
M04_L87:
       mov       rsi,rcx
       jmp       near ptr M04_L46
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C9A0D18
       call      qword ptr [r11]
M04_L90:
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,1CF7CAE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFE0D24E748]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FFE0CA55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C971328
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D3B1330],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,27BBF002AB8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C971330
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,27BBF001FE8
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D332ED8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L11
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D6970]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        short M00_L09
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D23F4C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D6988]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L30
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L11:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       short M00_L07
M00_L12:
       test      r13,r13
       je        short M00_L13
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L15:
       mov       ecx,edx
       jmp       short M00_L14
M00_L16:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2D66B8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L21
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r14+10]
M00_L17:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L19:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L20:
       mov       ecx,edx
       jmp       short M00_L18
M00_L21:
       test      r13,r13
       je        short M00_L22
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        near ptr M00_L31
M00_L23:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L19
M00_L24:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L26
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D23F4C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D2D6958]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L26:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L25
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L30:
       mov       r14,r13
       jmp       short M00_L34
M00_L31:
       mov       eax,edx
       jmp       near ptr M00_L23
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        short M00_L29
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L24
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C971338
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2D66B8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L12
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D69A0]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D69B8]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D6970]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D2D69D0]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D23F4E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D23F2D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D2CA208
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23F540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFAE208]
       mov       ecx,65
       mov       rdx,7FFE0CE1B048
       call      qword ptr [7FFE0CC477B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CCF5508
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE1B048
       call      qword ptr [7FFE0CC477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D2356F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D235710]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2227
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
       je        near ptr M02_L01
       test      rdi,rdi
       je        short M02_L00
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,851
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M02_L01:
       mov       ecx,847
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23F528]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23F528]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D2D6610]
M03_L03:
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
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L19
M04_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+70]
       test      r14,r14
       je        near ptr M04_L20
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L49
       test      r13d,r13d
       je        near ptr M04_L50
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M04_L21
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        near ptr M04_L22
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L57
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M04_L53
M04_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+78]
       test      rdi,rdi
       je        near ptr M04_L23
M04_L06:
       test      esi,esi
       je        near ptr M04_L11
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L63
M04_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L24
M04_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L25
       test      r13d,r13d
       jne       near ptr M04_L67
       xor       eax,eax
       xor       r12d,r12d
M04_L09:
       cmp       esi,r12d
       jg        near ptr M04_L70
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L69
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L68
M04_L10:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L76
       cmp       esi,1
       jle       near ptr M04_L15
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0E8]
       test      rdi,rdi
       je        near ptr M04_L28
M04_L12:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M04_L71
       cmp       [r14+8],esi
       jl        near ptr M04_L77
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L29
M04_L13:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L30
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L30
M04_L14:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L15:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L35
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L35
       jmp       short M04_L17
M04_L16:
       inc       edi
M04_L17:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L36
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L81
       cmp       ebx,r11d
       jae       near ptr M04_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L72
       test      r8,r8
       je        short M04_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C971350
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
M04_L18:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M04_L16
M04_L19:
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
M04_L20:
       mov       rcx,rdx
       mov       rdx,7FFE0D316470
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L21:
       mov       rdx,7FFE0D149C98
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L22:
       mov       rdx,7FFE0D2F71F8
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L23:
       mov       rcx,rdx
       mov       rdx,7FFE0D3164B0
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L24:
       mov       rcx,rdi
       mov       rdx,7FFE0D316A90
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L08
M04_L25:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L27
M04_L26:
       cmp       [rdi],rax
       jne       near ptr M04_L66
       cmp       [rdi+8],r13d
       jb        near ptr M04_L67
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L09
M04_L27:
       mov       rcx,rdx
       mov       rdx,7FFE0D316AB0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L26
M04_L28:
       mov       rcx,r14
       mov       rdx,7FFE0D316C10
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFE0D313A00
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFE0D313A98
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L14
M04_L31:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L88
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L73
       test      r14,r14
       je        near ptr M04_L74
       test      r8,r8
       je        short M04_L33
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C971350
       call      qword ptr [r11]
M04_L32:
       test      eax,eax
       je        short M04_L34
M04_L33:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L81
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L34:
       inc       edi
M04_L35:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L36
       cmp       edi,edx
       jae       near ptr M04_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M04_L31
       mov       rcx,rdx
       mov       rdx,7FFE0D3164D0
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L31
M04_L36:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L75
       test      ebx,ebx
       jl        near ptr M04_L76
       test      ebx,ebx
       jg        near ptr M04_L78
M04_L37:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M04_L45
M04_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D23F420]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M04_L46
M04_L39:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       je        near ptr M04_L48
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
       call      qword ptr [7FFE0D23F480]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D23F480]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L47
M04_L40:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L82
       cmp       edi,[rbx+10]
       jae       near ptr M04_L81
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L88
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L41:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L83
       test      r14,r14
       je        near ptr M04_L84
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
       jo        near ptr M04_L89
       cmp       ecx,0FF
       ja        near ptr M04_L89
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M04_L42:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M04_L87
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L86
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M04_L85
       cmp       byte ptr [rbx+24],0
       jne       short M04_L43
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23F528]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D23F528]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L43:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L44:
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
M04_L45:
       mov       rcx,rdx
       mov       rdx,7FFE0D316518
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L38
M04_L46:
       mov       rcx,rdx
       mov       rdx,7FFE0D316538
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L39
M04_L47:
       mov       rcx,rsi
       mov       rdx,7FFE0D3128D8
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L42
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFA6178]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFE0D211018
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L52:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L53:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M04_L56
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M04_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L54
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L55
M04_L54:
       mov       edx,4
M04_L55:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFE0CB9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D2D6A30]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D02BF70]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C971340
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFE0D2F7220
       call      qword ptr [7FFE0CA2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L60:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M04_L61
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M04_L58
M04_L61:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE0CB9E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C971348
       call      qword ptr [r11]
       jmp       near ptr M04_L05
M04_L63:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L64
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L65
M04_L64:
       mov       eax,4
M04_L65:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CB9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFE0D2D6808]
       int       3
M04_L67:
       call      qword ptr [7FFE0CB97198]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0D057270]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFE0CE2CC00]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFE0CC4C240]
       int       3
M04_L72:
       test      r8,r8
       je        near ptr M04_L16
       jmp       near ptr M04_L18
M04_L73:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L32
M04_L74:
       test      r8,r8
       je        near ptr M04_L34
       jmp       near ptr M04_L33
M04_L75:
       call      qword ptr [7FFE0D2D64C0]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFA6178]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFE0D11FE58]
       int       3
M04_L78:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L79
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF3D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D2D5F08]
       jmp       near ptr M04_L37
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M04_L81:
       call      qword ptr [7FFE0D235368]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L41
M04_L83:
       mov       ecx,847
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFE0D00A1D8
       call      qword ptr [7FFE0CC477B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D2D6100]
       int       3
M04_L86:
       call      qword ptr [7FFE0D2D6610]
       mov       rsi,rax
       jmp       near ptr M04_L44
M04_L87:
       mov       rsi,rcx
       jmp       near ptr M04_L44
M04_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M04_L90
       mov       rcx,[rbp-58]
       mov       r11,7FFE0C971348
       call      qword ptr [r11]
M04_L90:
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,2BC540E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFE0D2D4C60]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FFE0CA25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.ToImmutableSortedSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,rsi
       mov       r11,7FFE0C981710
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFE0D3E5650],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,23526000BF8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFE0C981718
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,23526000BB8
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE0D315AB8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L46
       xor       r15d,r15d
       inc       edi
       jmp       near ptr M00_L35
M00_L04:
       mov       edx,eax
       jmp       near ptr M00_L11
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D3A7558]
       mov       r13,rax
       cmp       byte ptr [r12+24],0
       je        short M00_L09
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rsp+28],rax
       test      r13,r13
       jne       short M00_L06
       mov       r13,[r12+18]
M00_L06:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,[rsp+28]
       mov       r9,r13
       call      qword ptr [7FFE0D3A5860]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D3A7570]
       mov       r14,rax
       mov       r13,r14
       jmp       near ptr M00_L30
M00_L08:
       mov       ecx,edx
       jmp       near ptr M00_L37
M00_L09:
       test      r13,r13
       je        short M00_L10
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+25]
       mov       rcx,[r12+18]
       movzx     eax,byte ptr [rcx+25]
       cmp       edx,eax
       jl        near ptr M00_L04
M00_L11:
       add       edx,1
       jo        near ptr M00_L56
       cmp       edx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],dl
       mov       rdx,[r12+10]
       mov       edx,[rdx+20]
       add       edx,[rcx+20]
       inc       edx
       mov       [r12+20],edx
       jmp       short M00_L07
M00_L12:
       test      r13,r13
       je        short M00_L13
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        short M00_L15
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       rcx,[r14+10]
       mov       ecx,[rcx+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L38
M00_L15:
       mov       ecx,edx
       jmp       short M00_L14
M00_L16:
       test      eax,eax
       jge       near ptr M00_L43
       mov       rax,[rsp+50]
       mov       rcx,[rax+10]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A71F8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L21
       mov       r12,[r14+8]
       test      r13,r13
       jne       short M00_L17
       mov       r13,[r14+10]
M00_L17:
       mov       r14,[r14+18]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       test      r13,r13
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r13+25]
       movzx     edx,byte ptr [r14+25]
       cmp       ecx,edx
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r13+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
M00_L19:
       mov       [rsp+50],r12
       jmp       near ptr M00_L39
M00_L20:
       mov       ecx,edx
       jmp       short M00_L18
M00_L21:
       test      r13,r13
       je        short M00_L22
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+10]
       movzx     eax,byte ptr [rcx+25]
       mov       rdx,[r14+18]
       movzx     edx,byte ptr [rdx+25]
       cmp       eax,edx
       jl        near ptr M00_L31
M00_L23:
       add       eax,1
       jo        near ptr M00_L56
       cmp       eax,0FF
       ja        near ptr M00_L56
       mov       [r14+25],al
       mov       ecx,[rcx+20]
       mov       rax,[r14+18]
       add       ecx,[rax+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       r12,r14
       jmp       short M00_L19
M00_L24:
       mov       rdx,[r14+10]
       mov       r13,rdx
       cmp       byte ptr [r12+24],0
       je        short M00_L26
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       r12,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+30],rdx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdx
       mov       rdx,[rsp+38]
       mov       r8,r12
       mov       r9,r13
       call      qword ptr [7FFE0D3A5860]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE0D3A7540]
       mov       r13,rax
       jmp       near ptr M00_L33
M00_L26:
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+10]
       movzx     ecx,byte ptr [rcx+25]
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [rdx+25]
       cmp       ecx,r8d
       jl        short M00_L28
M00_L27:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       rcx,[r12+10]
       mov       ecx,[rcx+20]
       add       ecx,[rdx+20]
       inc       ecx
       mov       [r12+20],ecx
       mov       r13,r12
       jmp       short M00_L25
M00_L28:
       mov       ecx,r8d
       jmp       short M00_L27
M00_L29:
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L05
       mov       r13,r12
M00_L30:
       mov       r14,r13
       jmp       short M00_L34
M00_L31:
       mov       eax,edx
       jmp       near ptr M00_L23
M00_L32:
       mov       r12,[rsp+50]
       test      r12,r12
       je        near ptr M00_L55
       mov       rdx,[r12+18]
       mov       r14,rdx
       movzx     ecx,byte ptr [r14+25]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+25]
       sub       ecx,eax
       cmp       ecx,2
       jl        near ptr M00_L40
       mov       rcx,r14
       test      rcx,rcx
       je        near ptr M00_L55
       mov       rax,[rcx+18]
       movzx     eax,byte ptr [rax+25]
       mov       rcx,[rcx+10]
       movzx     ecx,byte ptr [rcx+25]
       sub       eax,ecx
       js        short M00_L29
       cmp       qword ptr [r14+10],0
       jne       near ptr M00_L24
       mov       r13,r12
M00_L33:
       mov       r14,r13
M00_L34:
       add       r15,8
M00_L35:
       dec       edi
       je        near ptr M00_L45
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L52
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L44
       mov       rax,r14
       mov       [rsp+50],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFE0C981720
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A71F8]
       mov       r13,rax
       cmp       byte ptr [rsp+70],0
       je        near ptr M00_L39
       cmp       byte ptr [r14+24],0
       je        near ptr M00_L12
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+48],rax
       test      r13,r13
       jne       short M00_L36
       mov       r13,[r14+18]
M00_L36:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+48],0
       je        near ptr M00_L53
       test      r13,r13
       je        near ptr M00_L54
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       movzx     ecx,byte ptr [r12+25]
       movzx     edx,byte ptr [r13+25]
       cmp       ecx,edx
       jl        near ptr M00_L08
M00_L37:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
M00_L38:
       mov       [rsp+50],r14
M00_L39:
       cmp       byte ptr [rsp+70],0
       jne       near ptr M00_L32
       mov       r12,[rsp+50]
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L40:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D3A7588]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D3A75A0]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D3A7558]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFE0D3A75B8]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L42:
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L43:
       xor       ecx,ecx
       mov       [rsp+70],ecx
       jmp       near ptr M00_L34
M00_L44:
       mov       dword ptr [rsp+70],1
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
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L34
M00_L45:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFE0D3A5878]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFE0D3A5668]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFE0D3B5FD0
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A58D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L48:
       call      qword ptr [7FFE0CFBEBE0]
       mov       ecx,65
       mov       rdx,7FFE0CE2B048
       call      qword ptr [7FFE0CC577B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE0CD05508
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE0CE2B048
       call      qword ptr [7FFE0CC577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0CA37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0D136580]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE0D136598]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L51:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L52:
       mov       ecx,873
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2227
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
       je        near ptr M02_L01
       test      rdi,rdi
       je        short M02_L00
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
       jo        short M02_L02
       cmp       ecx,0FF
       ja        short M02_L02
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
M02_L00:
       mov       ecx,851
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M02_L01:
       mov       ecx,847
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M02_L02:
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
       je        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       je        short M03_L02
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M03_L01
       cmp       byte ptr [rbx+24],0
       jne       short M03_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A58C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A58C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M03_L00:
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
M03_L01:
       mov       ecx,873
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D3A7210]
M03_L03:
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
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rax,[rcx+8]
       cmp       qword ptr [rax+10],0
       jne       short M04_L00
       test      esi,esi
       je        near ptr M04_L23
M04_L00:
       mov       rdi,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r14,[rax+60]
       test      r14,r14
       je        near ptr M04_L24
M04_L01:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,esi
       add       r13d,[rdi+20]
       js        near ptr M04_L65
       test      r13d,r13d
       je        near ptr M04_L66
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        near ptr M04_L25
       mov       rcx,rax
M04_L02:
       mov       edx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M04_L26
       mov       rcx,rax
M04_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L29
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jle       near ptr M04_L09
       mov       r12,[r15+8]
       mov       ecx,[r12+8]
       mov       eax,[r15+10]
       mov       [rbp-5C],eax
       sub       ecx,eax
       cmp       ecx,r13d
       jge       near ptr M04_L08
       mov       ecx,eax
       add       ecx,r13d
       jo        near ptr M04_L101
       cmp       dword ptr [r12+8],0
       jne       near ptr M04_L27
       mov       edx,4
M04_L05:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,eax
       jl        near ptr M04_L69
       cmp       [r12+8],edx
       je        short M04_L08
       mov       [rbp-44],edx
       test      edx,edx
       jle       near ptr M04_L71
       mov       rcx,[r15]
       mov       r8,[rcx+30]
       mov       r8,[r8]
       mov       r8,[r8+78]
       test      r8,r8
       je        near ptr M04_L28
       mov       rcx,r8
M04_L06:
       mov       edx,[rbp-44]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-70],rax
       mov       r8d,[rbp-5C]
       test      r8d,r8d
       jg        near ptr M04_L70
M04_L07:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L08:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A7630]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
M04_L09:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+68]
       test      rdi,rdi
       je        near ptr M04_L39
M04_L10:
       test      esi,esi
       je        near ptr M04_L15
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       sub       edx,[r15+10]
       cmp       edx,esi
       jl        near ptr M04_L75
M04_L11:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L40
M04_L12:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       jne       near ptr M04_L41
       test      r13d,r13d
       jne       near ptr M04_L79
       xor       eax,eax
       xor       r12d,r12d
M04_L13:
       cmp       esi,r12d
       jg        near ptr M04_L82
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M04_L81
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFE6C661380
       cmp       dword ptr [7FFE6C983A10],0
       jne       near ptr M04_L80
M04_L14:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M04_L15:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M04_L88
       cmp       esi,1
       jle       near ptr M04_L19
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0E8]
       test      rdi,rdi
       je        near ptr M04_L44
M04_L16:
       mov       r14,[r15+8]
       test      r14,r14
       je        near ptr M04_L83
       cmp       [r14+8],esi
       jl        near ptr M04_L89
       add       r14,10
       mov       rdx,[rdi+18]
       mov       r13,[rdx+28]
       test      r13,r13
       je        near ptr M04_L45
M04_L17:
       mov       rdx,[rdi+18]
       cmp       qword ptr [rdx+8],30
       jle       near ptr M04_L46
       mov       r12,[rdx+30]
       test      r12,r12
       je        near ptr M04_L46
M04_L18:
       mov       rcx,r13
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbp-58],r14
       mov       [rbp-50],esi
       lea       rdx,[rbp-58]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
M04_L19:
       inc       dword ptr [r15+14]
       mov       esi,1
       mov       edi,1
       test      rbx,rbx
       je        near ptr M04_L51
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L51
       jmp       short M04_L21
M04_L20:
       inc       edi
M04_L21:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       near ptr M04_L52
       cmp       edi,edx
       jae       near ptr M04_L93
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M04_L100
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M04_L93
       cmp       ebx,r11d
       jae       near ptr M04_L100
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L84
       test      r8,r8
       je        short M04_L22
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C981738
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L20
M04_L22:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L93
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L100
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L93
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
       jmp       near ptr M04_L20
M04_L23:
       mov       rax,rcx
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L24:
       mov       rcx,rdx
       mov       rdx,7FFE0D3CA2D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L25:
       mov       rdx,7FFE0D116768
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L26:
       mov       rdx,7FFE0D29DFE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L27:
       mov       edx,[r12+8]
       add       edx,edx
       jmp       near ptr M04_L05
M04_L28:
       mov       rdx,7FFE0D116768
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L06
M04_L29:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE0D06AE10]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       cmp       [rax],eax
M04_L30:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rax],rcx
       jne       near ptr M04_L37
       mov       rcx,rax
       call      qword ptr [7FFE0CDC2C40]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M04_L31:
       test      eax,eax
       je        near ptr M04_L38
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M04_L34
M04_L32:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M04_L36
       mov       r8,[rax+8]
M04_L33:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M04_L35
       lea       r10d,[rdx+1]
       mov       [r15+10],r10d
       mov       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-68]
       jmp       short M04_L30
M04_L34:
       mov       rcx,r14
       mov       rdx,7FFE0D29E010
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M04_L32
M04_L35:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE0CBAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M04_L30
M04_L36:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       r8,rax
       mov       rax,[rbp-68]
       jmp       short M04_L33
M04_L37:
       mov       rcx,rax
       mov       r11,7FFE0C981728
       call      qword ptr [r11]
       jmp       near ptr M04_L31
M04_L38:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       near ptr M04_L74
       mov       rcx,rax
       call      qword ptr [7FFE0CDC2C38]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       near ptr M04_L09
M04_L39:
       mov       rcx,rdx
       mov       rdx,7FFE0D3CA310
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L10
M04_L40:
       mov       rcx,rdi
       mov       rdx,7FFE0D3CA9A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M04_L12
M04_L41:
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M04_L43
M04_L42:
       cmp       [rdi],rax
       jne       near ptr M04_L78
       cmp       [rdi+8],r13d
       jb        near ptr M04_L79
       mov       edx,r13d
       lea       rax,[rdi+rdx*8+10]
       mov       r12d,[rdi+8]
       sub       r12d,r13d
       jmp       near ptr M04_L13
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFE0D3CA9C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L42
M04_L44:
       mov       rcx,r14
       mov       rdx,7FFE0D3CAB28
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L16
M04_L45:
       mov       rcx,rdi
       mov       rdx,7FFE0D3C8A00
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L17
M04_L46:
       mov       rcx,rdi
       mov       rdx,7FFE0D3C8A98
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M04_L18
M04_L47:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M04_L100
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M04_L85
       test      r14,r14
       je        near ptr M04_L86
       test      r8,r8
       je        short M04_L49
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFE0C981738
       call      qword ptr [r11]
M04_L48:
       test      eax,eax
       je        short M04_L50
M04_L49:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M04_L93
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M04_L100
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M04_L93
       mov       rcx,r8
       movsxd    rdx,esi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       mov       esi,r14d
M04_L50:
       inc       edi
M04_L51:
       mov       edx,[r15+10]
       cmp       edi,edx
       jge       short M04_L52
       cmp       edi,edx
       jae       near ptr M04_L93
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M04_L100
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M04_L93
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L47
       mov       rcx,rdx
       mov       rdx,7FFE0D3CA330
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L47
M04_L52:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M04_L87
       test      ebx,ebx
       jl        near ptr M04_L88
       test      ebx,ebx
       jg        near ptr M04_L90
M04_L53:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L61
M04_L54:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE0D3A57B8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L62
M04_L55:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L92
       test      edi,edi
       je        near ptr M04_L64
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
       call      qword ptr [7FFE0D3A5818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE0D3A5818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L63
M04_L56:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M04_L94
       cmp       edi,[rbx+10]
       jae       near ptr M04_L93
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M04_L100
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M04_L57:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M04_L95
       test      r14,r14
       je        near ptr M04_L96
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
       jo        near ptr M04_L101
       cmp       ecx,0FF
       ja        near ptr M04_L101
       mov       [rbx+25],cl
       mov       ecx,[r15+20]
       add       ecx,[r14+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       byte ptr [rbx+24],1
M04_L58:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       je        near ptr M04_L99
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L98
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M04_L97
       cmp       byte ptr [rbx+24],0
       jne       short M04_L59
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A58C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0D3A58C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L59:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L60:
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L61:
       mov       rcx,rdx
       mov       rdx,7FFE0D3CA418
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L54
M04_L62:
       mov       rcx,rdx
       mov       rdx,7FFE0D3CA438
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L55
M04_L63:
       mov       rcx,rsi
       mov       rdx,7FFE0D3C7C30
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L56
M04_L64:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L58
M04_L65:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE0CFB6178]
       int       3
M04_L66:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M04_L67
       jmp       short M04_L68
M04_L67:
       mov       rdx,7FFE0D16DDA8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L68:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
M04_L69:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFE0CFB6178]
       int       3
M04_L70:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFE0CBA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbp-70]
       jmp       near ptr M04_L07
M04_L71:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M04_L72
       jmp       short M04_L73
M04_L72:
       mov       rdx,7FFE0D16DDA8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L73:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L08
M04_L74:
       mov       rcx,rax
       mov       r11,7FFE0C981730
       call      qword ptr [r11]
       jmp       near ptr M04_L09
M04_L75:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M04_L101
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M04_L76
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M04_L77
M04_L76:
       mov       eax,4
M04_L77:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFE0CBAE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L11
M04_L78:
       call      qword ptr [7FFE0D3A7390]
       int       3
M04_L79:
       call      qword ptr [7FFE0CBA7198]
       int       3
M04_L80:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L14
M04_L81:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE0CFBE550]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L14
M04_L82:
       call      qword ptr [7FFE0CE3CC00]
       int       3
M04_L83:
       mov       ecx,2
       call      qword ptr [7FFE0CC5C240]
       int       3
M04_L84:
       test      r8,r8
       je        near ptr M04_L20
       jmp       near ptr M04_L22
M04_L85:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M04_L48
M04_L86:
       test      r8,r8
       je        near ptr M04_L50
       jmp       near ptr M04_L49
M04_L87:
       call      qword ptr [7FFE0D3A70D8]
       int       3
M04_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFE0CFB6178]
       int       3
M04_L89:
       mov       ecx,10
       call      qword ptr [7FFE0D13C318]
       int       3
M04_L90:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M04_L91
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFE0CF4D110]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L91:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFE0D3A6478]
       jmp       near ptr M04_L53
M04_L92:
       mov       ecx,40B
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M04_L93:
       call      qword ptr [7FFE0D2452A8]
       int       3
M04_L94:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L57
M04_L95:
       mov       ecx,847
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M04_L96:
       mov       ecx,851
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M04_L97:
       mov       ecx,873
       mov       rdx,7FFE0D049130
       call      qword ptr [7FFE0CC577B0]
       mov       rcx,rax
       call      qword ptr [7FFE0D3A6FB8]
       int       3
M04_L98:
       call      qword ptr [7FFE0D3A7210]
       mov       rsi,rax
       jmp       near ptr M04_L60
M04_L99:
       mov       rsi,rcx
       jmp       near ptr M04_L60
M04_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M04_L103
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M04_L102
       mov       rcx,rax
       call      qword ptr [7FFE0CDC2C38]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M04_L103
M04_L102:
       mov       rcx,rax
       mov       r11,7FFE0C981730
       call      qword ptr [r11]
M04_L103:
       nop
       add       rsp,28
       ret
; Total bytes of code 3151
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
       je        near ptr M06_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L00
       test      rbx,rbx
       je        near ptr M06_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M06_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE6C6C9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE0CA35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE0CA35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       test      rbx,rbx
       je        short M06_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L02
M06_L01:
       mov       rax,275A5160008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFE0D246D48]
       int       3
; Total bytes of code 235
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
       jmp       qword ptr [7FFE0CA35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

