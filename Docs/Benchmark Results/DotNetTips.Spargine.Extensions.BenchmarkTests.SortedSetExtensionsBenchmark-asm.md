## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1E169402A78
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
       call      qword ptr [7FF8A73B6F10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B20EA0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A73B6F10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B20EA8
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
       mov       rax,[rcx+90]
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
       mov       rdx,1E169402A70
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6BD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E169402A78
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF8A6DFC2A0]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6E88C90
       call      qword ptr [7FF8A6DFC030]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73BDB30]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A7445C08]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B20E98
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF8A6B20EB0
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
       mov       r11,7FF8A6B20EB0
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
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
       call      qword ptr [7FF8A7445CF8]
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
       call      qword ptr [7FF8A7445CE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F3CBB8]
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
       call      qword ptr [7FF8A73B6EE0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A717F888]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,22BD5800A50
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
       call      qword ptr [7FF8A73B64A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B20DD8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A73B64A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B20DE0
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
       mov       rax,[rcx+90]
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
       mov       rdx,22BD5800A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6BD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22BD5800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF8A6DF7A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6E78C90
       call      qword ptr [7FF8A6DF7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73BD008]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A73BF018]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B20DD0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF8A6B20DE8
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
       mov       r11,7FF8A6B20DE8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
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
       call      qword ptr [7FF8A73BF150]
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
       call      qword ptr [7FF8A73BF138]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F27E58]
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
       call      qword ptr [7FF8A73B6478]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A73BD668]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,2240D000A50
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
       call      qword ptr [7FF8A73B60D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B40DD8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A73B60D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B40DE0
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
       mov       rax,[rcx+90]
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
       mov       rdx,2240D000A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6BF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2240D000A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF8A6E17A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73BD3E0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A73BF3F0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B40DD0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF8A6B40DE8
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
       mov       r11,7FF8A6B40DE8
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
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
       call      qword ptr [7FF8A73BF528]
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
       call      qword ptr [7FF8A73BF510]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F47E58]
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
       call      qword ptr [7FF8A73B60A0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A73BDA40]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,29EE9C02A48
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
       call      qword ptr [7FF8A73D64D8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B40DF0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A73D64D8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B40DF8
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
       mov       rax,[rcx+90]
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
       mov       rdx,29EE9C02A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6BF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29EE9C02A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF8A6E17A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73DD038]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A73DF000]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B40DE8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF8A6B40E00
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
       mov       r11,7FF8A6B40E00
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
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
       call      qword ptr [7FF8A73DF168]
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
       call      qword ptr [7FF8A73DF150]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F47E58]
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
       call      qword ptr [7FF8A73D64A8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A73DD698]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1712EC00A38
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L25
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L17
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L28
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
       jbe       near ptr M00_L27
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
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73D7D50]
       int       3
M00_L06:
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L14
       mov       rdx,rbx
       add       rcx,8
       call      qword ptr [7FF8A72DE898]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L07:
       test      eax,eax
       je        near ptr M00_L29
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rcx
       jne       short M00_L11
       mov       rcx,[rbp-40]
       lea       r11,[rcx+8]
       mov       r11,[r11+10]
       test      r11,r11
       je        short M00_L10
       mov       r11,[r11+8]
M00_L08:
       mov       rdx,r11
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rax
       jne       short M00_L13
       mov       r11,[r11+30]
       test      r11,r11
       je        short M00_L12
       cmp       dword ptr [r11+8],0
       setg      al
       movzx     eax,al
M00_L09:
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L15
M00_L10:
       xor       r11d,r11d
       jmp       short M00_L08
M00_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF8A6B50B58
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L13
M00_L12:
       xor       eax,eax
       jmp       short M00_L09
M00_L13:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-40]
       jmp       short M00_L09
M00_L14:
       mov       r11,7FF8A6B50B50
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L15:
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L30
M00_L16:
       mov       edi,1
       jmp       short M00_L22
M00_L17:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L26
       add       r14,10
       jmp       short M00_L19
M00_L18:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L19:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L21
M00_L20:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L20
M00_L21:
       xor       edi,edi
M00_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],dil
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
       mov       edi,1
       jmp       short M00_L22
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1712EC00A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6C06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1712EC00A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       xor       edi,edi
       jmp       short M00_L22
M00_L26:
       call      qword ptr [7FF8A6E27A08]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FF8A73D7B58]
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FF8A6B50B48
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       jmp       near ptr M00_L21
M00_L30:
       mov       rcx,[rbp-40]
       mov       r11,7FF8A6B50B60
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L32
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L32
       mov       r11,7FF8A6B50B60
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 882
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
       jne       near ptr M01_L09
M01_L00:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+24]
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       edx,[rcx+10]
       test      edx,edx
       je        near ptr M01_L11
       dec       edx
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L08
       inc       dword ptr [rcx+14]
       mov       [rcx+10],edx
       mov       ecx,edx
       mov       r10,[rax+rcx*8+10]
       mov       ecx,edx
       mov       r8d,r8d
       cmp       rcx,r8
       jae       near ptr M01_L17
       mov       ecx,edx
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       lea       rcx,[rbx+10]
       mov       rdx,r10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M01_L12
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
M01_L01:
       test      rdi,rdi
       je        short M01_L07
M01_L02:
       movzx     ecx,byte ptr [rbx+1C]
       test      ecx,ecx
       jne       near ptr M01_L13
       mov       rbp,[rdi+10]
       mov       r14,[rdi+18]
M01_L03:
       mov       rcx,[rbx]
       mov       rdx,[rdi+8]
       cmp       [rcx],rsi
       jne       near ptr M01_L14
M01_L04:
       mov       r14,[rbx+8]
       mov       r15d,[r14+10]
       mov       rcx,[r14+8]
       cmp       [rcx+8],r15d
       jbe       near ptr M01_L15
       mov       edx,r15d
       mov       r8,rdi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r14+14]
       inc       r15d
       mov       [r14+10],r15d
M01_L05:
       mov       rdi,rbp
M01_L06:
       test      rdi,rdi
       jne       short M01_L02
M01_L07:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF8A73D7DE0]
       int       3
M01_L09:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A73D7DC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F57E58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
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
M01_L12:
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       jmp       near ptr M01_L01
M01_L13:
       mov       rbp,[rdi+18]
       mov       r14,[rdi+10]
       jmp       near ptr M01_L03
M01_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M01_L16
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF8A73D7B58]
       jmp       near ptr M01_L05
M01_L16:
       test      r14,r14
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L05
       mov       rdi,r14
       jmp       near ptr M01_L06
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 461
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L01
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 24
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
       call      qword ptr [7FF8A73DE6E8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,2903B800A50
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
       call      qword ptr [7FF8A73A6040]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B30DF0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A73A6040]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B30DF8
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
       mov       rax,[rcx+90]
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
       mov       rdx,2903B800A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6BE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2903B800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FF8A6E07A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6E88C90
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73AD020]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A73AEFE8]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B30DE8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FF8A6B30E00
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
       mov       r11,7FF8A6B30E00
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
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
       call      qword ptr [7FF8A73AF150]
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
       call      qword ptr [7FF8A73AF138]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F37E58]
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
       call      qword ptr [7FF8A73A6010]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A73AD680]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1CA8C400A50
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
       call      qword ptr [7FF8A73D7BA0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B50F58
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A73D7BA0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B50F60
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
       mov       rax,[rcx+90]
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
       call      qword ptr [7FF8A6E27A08]
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
       mov       rdx,1CA8C400A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6C06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CA8C400A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A73DD038]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A74B40D8]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B50F50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FF8A6B50F68
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
       mov       r11,7FF8A6B50F68
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
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
       call      qword ptr [7FF8A74B41C8]
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
       call      qword ptr [7FF8A74B41B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F57E58]
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
       call      qword ptr [7FF8A73D7B70]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A73DD698]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1DD54C00AF0
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
       call      qword ptr [7FF8A741E880]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FF8A6B51218
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF8A741E880]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FF8A6B51220
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
       mov       rax,[rcx+90]
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
       call      qword ptr [7FF8A6E27A08]
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
       mov       rdx,1DD54C00AE8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A6C06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DD54C00AF0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A72F5B18]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FF8A7544420]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF8A6B51210
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FF8A6B51228
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
       mov       r11,7FF8A6B51228
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
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
       call      qword ptr [7FF8A7544540]
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
       call      qword ptr [7FF8A7544528]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6F57E58]
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
       call      qword ptr [7FF8A741E850]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FF8A72F6220]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
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
       mov       rcx,[rbx+90]
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
; Total bytes of code 87
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1C28FC02A40
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A734C3B8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A73BFC78]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B40CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73BF918]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A73BF918]
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
       call      qword ptr [7FF8A73B63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73B6400]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73B61D8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A74003A0
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6448]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E1DED8]
       mov       ecx,65
       mov       rdx,7FF8A7013500
       call      qword ptr [7FF8A6E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6EC4F28
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7013500
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73BD068]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73BD080]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B40CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73BD380]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A73BF8A0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F46010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73BD380]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A73BF5A0]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A73BF5A0]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A73BF600]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B40CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C28FC02AD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A73BF930]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       call      qword ptr [7FF8A73BC7B0]
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
       jmp       qword ptr [7FF8A6BFD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6430]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6430]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
       je        near ptr M05_L18
       jmp       near ptr M05_L69
M05_L11:
       mov       rcx,rdx
       mov       rdx,7FF8A74A0268
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L12:
       mov       rdx,7FF8A7416F48
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L13:
       mov       rdx,7FF8A74A05A8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,rdx
       mov       rdx,7FF8A74A02A8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L15:
       mov       rcx,rdi
       mov       rdx,7FF8A74A0C28
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L16:
       mov       rcx,rdx
       mov       rdx,7FF8A74A0C48
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L17:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A73BC6F0]
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
       mov       rdi,[rdx+0C0]
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
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L34
M05_L24:
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
       je        short M05_L25
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FF8A6B40CD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L26
M05_L25:
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
M05_L26:
       inc       edi
       jmp       near ptr M05_L24
M05_L27:
       mov       rcx,r14
       mov       rdx,7FF8A74A0DA8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L20
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A746C988
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FF8A746CA20
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L22
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
       mov       r11,7FF8A6B40CD0
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
       mov       rdx,7FF8A74A02C8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73B6328]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8A73B6430]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6430]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A74A03B0
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FF8A74A03D0
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73B6388]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73B6388]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF8A746E5D8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7196AA8]
       int       3
M05_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L51
       jmp       short M05_L52
M05_L51:
       mov       rdx,7FF8A746A090
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D6E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73BFD08]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A73E9F20]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B40CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L59
       jmp       short M05_L60
M05_L59:
       mov       rcx,r14
       mov       rdx,7FF8A74A05D0
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B40CC8
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
       call      qword ptr [7FF8A6D6E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FF8A73BFA98]
       int       3
M05_L68:
       call      qword ptr [7FF8A6D67198]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L18
M05_L70:
       call      qword ptr [7FF8A700D578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E1C228]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L26
       jmp       near ptr M05_L25
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
       call      qword ptr [7FF8A73BF468]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A7196AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A73BF498]
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
       call      qword ptr [7FF8A711DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73BFB10]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M05_L81:
       call      qword ptr [7FF8A72DCF30]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A73E5D70
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF630]
       int       3
M05_L86:
       call      qword ptr [7FF8A73BF930]
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
       mov       r11,7FF8A6B40CC8
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,20324A00008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73BEE38]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,2DF5B400A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A733B5D8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A73AFC60]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B30CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73AF8E8]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A73AF8E8]
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
       call      qword ptr [7FF8A73A6370]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73A63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73A6178]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A73DF6F8
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73A63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E0DED8]
       mov       ecx,65
       mov       rdx,7FF8A7003500
       call      qword ptr [7FF8A6E07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6EB4F28
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BE7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7003500
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BE7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73AFB88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73AE820]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B30CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6E88C90
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73AD338]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A73AF870]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F36010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6E88C90
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73AD338]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A73AF570]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A73AF570]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A73AF5D0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B30CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2DF5B400AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A73AF900]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       call      qword ptr [7FF8A73AC768]
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
       jmp       qword ptr [7FF8A6BED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73A63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73A63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
       je        near ptr M05_L18
       jmp       near ptr M05_L69
M05_L11:
       mov       rcx,rdx
       mov       rdx,7FF8A7490278
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L12:
       mov       rdx,7FF8A74057E8
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L13:
       mov       rdx,7FF8A74905B8
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,rdx
       mov       rdx,7FF8A74902B8
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L15:
       mov       rcx,rdi
       mov       rdx,7FF8A7490C38
       call      qword ptr [7FF8A6E07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L16:
       mov       rcx,rdx
       mov       rdx,7FF8A7490C58
       call      qword ptr [7FF8A6E07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L17:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A73AC198]
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
       mov       rdi,[rdx+0C0]
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
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L34
M05_L24:
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
       je        short M05_L25
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FF8A6B30CC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L26
M05_L25:
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
M05_L26:
       inc       edi
       jmp       near ptr M05_L24
M05_L27:
       mov       rcx,r14
       mov       rdx,7FF8A7490DB8
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L20
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A745C978
       call      qword ptr [7FF8A6E07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FF8A745CA10
       call      qword ptr [7FF8A6E07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L22
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
       mov       r11,7FF8A6B30CC8
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
       mov       rdx,7FF8A74902D8
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73A62C8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8A73A63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73A63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A74903C0
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FF8A74903E0
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73A6328]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73A6328]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF8A745E640
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7186AA8]
       int       3
M05_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L51
       jmp       short M05_L52
M05_L51:
       mov       rdx,7FF8A745A0A0
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D5E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73AFCF0]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A73D92B8]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B30CB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L59
       jmp       short M05_L60
M05_L59:
       mov       rcx,r14
       mov       rdx,7FF8A74905E0
       call      qword ptr [7FF8A6BEC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D5E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B30CC0
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
       call      qword ptr [7FF8A6D5E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FF8A73AFA68]
       int       3
M05_L68:
       call      qword ptr [7FF8A6D57198]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L18
M05_L70:
       call      qword ptr [7FF8A6FFD578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E0C228]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L26
       jmp       near ptr M05_L25
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
       call      qword ptr [7FF8A73AF408]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A7186AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A73AF438]
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
       call      qword ptr [7FF8A710DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73AFAE0]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M05_L81:
       call      qword ptr [7FF8A72CCF18]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A73D5108
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A73AF600]
       int       3
M05_L86:
       call      qword ptr [7FF8A73AF900]
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
       mov       r11,7FF8A6B30CC0
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,31FDA1C0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73AEE08]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6BE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1BA5D002A40
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A735C038]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A73CFC60]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B50CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73CF8E8]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A73CF8E8]
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
       call      qword ptr [7FF8A73C62B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73C62E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73C60B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A73FEF20
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73C6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E2DED8]
       mov       ecx,65
       mov       rdx,7FF8A7023500
       call      qword ptr [7FF8A6E27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6ED4F28
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6C07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7023500
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6C07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73CFB88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73CE820]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B50CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73CD338]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A73CF870]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F56010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73CD338]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A73CF570]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A73CF570]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A73CF5D0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B50CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BA5D002AD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A73CF900]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       call      qword ptr [7FF8A73CC768]
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
       jmp       qword ptr [7FF8A6C0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73C6310]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73C6310]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
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
       mov       rdi,[rdx+0C0]
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
       mov       r11,7FF8A6B50CC8
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
       mov       rdx,7FF8A74A0688
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FF8A7425680
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FF8A74A09C8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FF8A74A06C8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FF8A74A1048
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FF8A74A1068
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FF8A74A11C8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FF8A747CD40
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A747CDD8
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF8A6B50CC8
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
       mov       rdx,7FF8A74A06E8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73C6208]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8A73C6310]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73C6310]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A74A07D0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FF8A74A07F0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73C6268]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73C6268]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF8A747EA08
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A71A6AA8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FF8A747A350
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D7E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73CFCF0]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A73F8AE0]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B50CB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FF8A74A09F0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D7E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B50CC0
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
       call      qword ptr [7FF8A6D7E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FF8A73CFA68]
       int       3
M05_L67:
       call      qword ptr [7FF8A6D77198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A71AEEE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FF8A701D578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E2C228]
       int       3
M05_L72:
       test      r8,r8
       jne       near ptr M05_L19
       jmp       near ptr M05_L17
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
       call      qword ptr [7FF8A73CF408]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A71A6AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A73CF438]
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
       call      qword ptr [7FF8A712DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73CFAE0]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M05_L81:
       call      qword ptr [7FF8A72ECF00]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A73F4930
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A73CF600]
       int       3
M05_L86:
       call      qword ptr [7FF8A73CF900]
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
       mov       r11,7FF8A6B50CC0
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,1FAF1F30008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73CEE08]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6C05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1C17C400A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A735DB18]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A73DFCC0]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B40CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73DFA20]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A73DFA20]
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
       call      qword ptr [7FF8A73D6880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73D68B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73D6688]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A7410FB8
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D68F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E1DED8]
       mov       ecx,65
       mov       rdx,7FF8A7013500
       call      qword ptr [7FF8A6E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6EC4F28
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7013500
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73DD098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73DD0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B40CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73DD398]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A73DF9C0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F46010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73DD398]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A73DF840]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A73DF840]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A73DF8A0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B40CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C17C400AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A73DF978]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       call      qword ptr [7FF8A73DC7B0]
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
       jmp       qword ptr [7FF8A6BFD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 192
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
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
       mov       rdi,[rdx+0C0]
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
       mov       r11,7FF8A6B40CC8
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
       mov       rdx,7FF8A746E0B8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FF8A7421E88
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FF8A746E340
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FF8A746E0F8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FF8A746E9C0
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FF8A746E9E0
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FF8A746EB40
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FF8A7469AB8
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A7469B50
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF8A6B40CC8
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
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M05_L29
       mov       rcx,rdx
       mov       rdx,7FF8A746E118
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L43
M05_L36:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF8A73D67D8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
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
       call      qword ptr [7FF8A73D6838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73D6838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FF8A73D68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A746E160
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FF8A746E180
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FF8A746B8F8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7196AA8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FF8A7466F30
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D6E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73DFD50]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A73FAB68]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B40CB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FF8A746E368
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B40CC0
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
       call      qword ptr [7FF8A6D6E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FF8A73DFB70]
       int       3
M05_L67:
       call      qword ptr [7FF8A6D67198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A719F378]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FF8A700D578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E1C228]
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
       call      qword ptr [7FF8A73DF498]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A7196AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A73DF4C8]
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
       call      qword ptr [7FF8A711DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73DF8D0]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M05_L81:
       call      qword ptr [7FF8A72ED3F8]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A73F69B8
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73DF7C8]
       int       3
M05_L86:
       call      qword ptr [7FF8A73DF978]
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
       mov       r11,7FF8A6B40CC0
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,201FB240008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73DEE50]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,20E61800A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A734C118]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A73BFD08]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B40CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73BF8E8]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A73BF8E8]
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
       call      qword ptr [7FF8A73B6418]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73B6448]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73B6220]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A7400158
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6490]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E1DED8]
       mov       ecx,65
       mov       rdx,7FF8A7013500
       call      qword ptr [7FF8A6E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6EC4F28
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7013500
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73BFBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73BE838]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B40CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73BD350]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A73BF870]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F46010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6E98C90
       call      qword ptr [7FF8A6E17798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73BD350]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A73BF360]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A73BF360]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A73BF3C0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B40CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20E61800AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A73BF900]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       call      qword ptr [7FF8A73BC7C8]
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
       jmp       qword ptr [7FF8A6BFD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6478]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6478]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
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
       mov       rdx,7FF8A746F760
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L13:
       mov       rdx,7FF8A7425138
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L14:
       mov       rdx,7FF8A746FAA0
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,rdx
       mov       rdx,7FF8A746F7A0
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L16:
       mov       rcx,rdi
       mov       rdx,7FF8A74A0158
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L17:
       mov       rcx,rdx
       mov       rdx,7FF8A74A0178
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L18:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A72DC2E8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdi,[rdx+0C0]
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
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M05_L35
       jmp       short M05_L26
M05_L25:
       inc       edi
M05_L26:
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jge       near ptr M05_L36
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
       je        short M05_L27
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FF8A6B40CC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L25
M05_L27:
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
       jmp       near ptr M05_L25
M05_L28:
       mov       rcx,r14
       mov       rdx,7FF8A74A02D8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FF8A746DF40
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L22
M05_L30:
       mov       rcx,rdi
       mov       rdx,7FF8A746DFD8
       call      qword ptr [7FF8A6E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF8A6B40CC8
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
       mov       ecx,[r15+10]
       cmp       edi,ecx
       jge       short M05_L36
       cmp       edi,ecx
       jae       near ptr M05_L81
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       edx,edi
       mov       r14,[r8+rdx*8+10]
       lea       edx,[rdi-1]
       mov       r13d,edx
       cmp       r13d,ecx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L31
       mov       rcx,rdx
       mov       rdx,7FF8A746F7C0
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L45
M05_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF8A73B6370]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
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
       call      qword ptr [7FF8A73B63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73B63D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FF8A73B6478]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B6478]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A746F8A8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rdx
       mov       rdx,7FF8A746F8C8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FF8A746D778
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7196AA8]
       int       3
M05_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L51
       jmp       short M05_L52
M05_L51:
       mov       rdx,7FF8A7469EF8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D6E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73BFD98]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A73E9D18]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B40CB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L59
       jmp       short M05_L60
M05_L59:
       mov       rcx,r14
       mov       rdx,7FF8A746FAC8
       call      qword ptr [7FF8A6BFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B40CC0
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
       call      qword ptr [7FF8A6D6E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FF8A73BFA68]
       int       3
M05_L68:
       call      qword ptr [7FF8A6D67198]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L19
M05_L70:
       call      qword ptr [7FF8A700D578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E1C228]
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
       call      qword ptr [7FF8A73BF7B0]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A7196AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A73BF7E0]
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
       call      qword ptr [7FF8A711DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73BFAE0]
       jmp       near ptr M05_L37
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M05_L81:
       call      qword ptr [7FF8A72DCF60]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L41
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A73E5B68
       call      qword ptr [7FF8A6E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF648]
       int       3
M05_L86:
       call      qword ptr [7FF8A73BF900]
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
       mov       r11,7FF8A6B40CC0
       call      qword ptr [r11]
M05_L90:
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,24EE05D0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73BEE20]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,1B611C00A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A733CAD8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A73BFC90]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B20CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73BF918]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A73BF918]
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
       call      qword ptr [7FF8A73B6880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73B68B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73B6688]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A73F0FB8
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B68F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6DFDED8]
       mov       ecx,65
       mov       rdx,7FF8A6FF3500
       call      qword ptr [7FF8A6DF7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6EA4F28
       call      qword ptr [7FF8A6DF7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BD7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A6FF3500
       call      qword ptr [7FF8A6DF7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BD7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73BD080]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73BD098]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B20CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6E78C90
       call      qword ptr [7FF8A6DF7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73BD398]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A73BF8A0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F26010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6E78C90
       call      qword ptr [7FF8A6DF7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73BD398]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A73BF390]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A73BF390]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A73BF3F0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B20CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B611C00AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A73BF930]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       call      qword ptr [7FF8A73BC768]
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
       jmp       qword ptr [7FF8A6BDD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+98]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
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
       mov       rdi,[rdx+0C0]
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
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M05_L34
       jmp       short M05_L18
M05_L17:
       inc       edi
M05_L18:
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
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FF8A6B20CC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
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
       mov       rdx,7FF8A744C7E8
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FF8A74119A0
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FF8A744CB28
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FF8A744C828
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FF8A744D1A8
       call      qword ptr [7FF8A6DF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FF8A744D1C8
       call      qword ptr [7FF8A6DF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FF8A744D328
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A744AFD0
       call      qword ptr [7FF8A6DF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FF8A744B068
       call      qword ptr [7FF8A6DF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF8A6B20CC8
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
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       edx,edi
       mov       r14,[r8+rdx*8+10]
       lea       edx,[rdi-1]
       mov       r13d,edx
       cmp       r13d,ecx
       jae       near ptr M05_L81
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FF8A744C848
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73B67D8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8A73B68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73B68E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A744C930
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FF8A744C950
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73B6838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73B6838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF8A744A808
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8A7176AA8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FF8A7446F30
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D4E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73BFD20]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A73DAB68]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B20CB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L61
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L58
       jmp       short M05_L59
M05_L58:
       mov       rcx,r14
       mov       rdx,7FF8A744CB50
       call      qword ptr [7FF8A6BDC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D4E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B20CC0
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
       call      qword ptr [7FF8A6D4E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FF8A73BFA98]
       int       3
M05_L67:
       call      qword ptr [7FF8A6D47198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A717EEE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FF8A6FED578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6DFC228]
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
       call      qword ptr [7FF8A73BF7E0]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A7176AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A73BF810]
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
       call      qword ptr [7FF8A70FDA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73BFB10]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M05_L81:
       call      qword ptr [7FF8A72CD428]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A73D69B8
       call      qword ptr [7FF8A6DF7798]
       mov       rcx,rax
       call      qword ptr [7FF8A73BF678]
       int       3
M05_L86:
       call      qword ptr [7FF8A73BF930]
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
       mov       r11,7FF8A6B20CC0
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,1F690BD0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73BEE50]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,24064800A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A73A2B98]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A74C4D68]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B50E80
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A74C4978]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A74C4978]
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
       call      qword ptr [7FF8A73D7F78]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73D7FA8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73D7D80]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A74403A0
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73DC000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E2DED8]
       mov       ecx,65
       mov       rdx,7FF8A7023500
       call      qword ptr [7FF8A6E27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6ED4F28
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6C07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7023500
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6C07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A73DEA48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A73DEA60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B50E70
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73DCBA0]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A74C4900]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F56010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6EA8C90
       call      qword ptr [7FF8A6E27798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A73DCBA0]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A74C4420]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A74C4420]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A74C4450]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B50E78
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24064800B38
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A74C4990]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
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
       call      qword ptr [7FF8A72ED428]
       int       3
M02_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF8A6C0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D7FD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D7FD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+70]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
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
       mov       r11,7FF8A6B50E98
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
       mov       rdx,7FF8A74AE090
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FF8A73093D0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FF8A74AE3D0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FF8A74AE0D0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FF8A74AEA50
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FF8A74AEA70
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FF8A74AEBD0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A74AC870
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FF8A74AC908
       call      qword ptr [7FF8A6E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF8A6B50E98
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
       mov       rdx,7FF8A74AE0F0
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73D7ED0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8A73D7FD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73D7FD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FF8A74AE1D8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FF8A74AE1F8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A73D7F30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73D7F30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FF8A74AB900
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8A71A6AA8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FF8A743A020
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D7E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A74C4E10]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A7429F20]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B50E88
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
       mov       rdx,7FF8A74AE3F8
       call      qword ptr [7FF8A6C0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A6D7E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B50E90
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
       call      qword ptr [7FF8A6D7E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FF8A74C4AF8]
       int       3
M05_L67:
       call      qword ptr [7FF8A6D77198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A7226B38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FF8A701D578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E2C228]
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
       call      qword ptr [7FF8A74C4840]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A71A6AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A74C4870]
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
       call      qword ptr [7FF8A712DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A74C41B0]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M05_L81:
       call      qword ptr [7FF8A72EEC28]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A7425D70
       call      qword ptr [7FF8A6E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A74C46D8]
       int       3
M05_L86:
       call      qword ptr [7FF8A74C4990]
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
       mov       r11,7FF8A6B50E90
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,280E3830008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FF8A73DF888]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6C05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
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
       je        near ptr M00_L43
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L42
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
       jl        near ptr M00_L36
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       ebp,ecx
       jg        near ptr M00_L37
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
       js        near ptr M00_L38
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
       jbe       near ptr M00_L39
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
       jbe       near ptr M00_L41
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
       jbe       near ptr M00_L40
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
       je        near ptr M00_L44
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L07:
       mov       r8,25EEB400AF0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF8A74C3938]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L31
       mov       r14,[rbp+8]
       xor       r15d,r15d
       inc       edi
       jmp       short M00_L10
M00_L08:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF8A7535140]
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
       je        near ptr M00_L45
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L28
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FF8A6B31020
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7534E40]
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
       je        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L47
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       call      qword ptr [7FF8A7534E40]
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
       call      qword ptr [7FF8A73FEC10]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
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
       jo        near ptr M00_L50
       cmp       ecx,0FF
       ja        near ptr M00_L50
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L09
M00_L29:
       cmp       r14,[rbp+8]
       je        near ptr M00_L49
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A73FEC40]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FF8A73FEA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF8A7483510
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73FEC88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       call      qword ptr [7FF8A6E0DED8]
       mov       ecx,65
       mov       rdx,7FF8A7003500
       call      qword ptr [7FF8A6E07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A6EB4F28
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BE7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF8A7003500
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A6BE7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A72C55A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A72C55C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF8A6B31010
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FF8A6E88C90
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A72C5BD8]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A7534DE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A6F36010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FF8A6E88C90
       call      qword ptr [7FF8A6E07798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A72C5BD8]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF8A7534378]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF8A7534378]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FF8A75343A8]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF8A6B31018
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25EEB400B40
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FF8A7534D98]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2099
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
       jmp       near ptr 00007FF9068840D0
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FF8A72C4BD0]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF8A6BED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 196
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       cmp       [rsi],esi
       test      rbx,rbx
       je        short M04_L01
       test      rdi,rdi
       je        short M04_L02
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73FEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73FEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M04_L00:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,4AB
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
; Total bytes of code 162
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
       mov       rax,[rdx+50]
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
       call      00007FF9068037A0
       cmp       dword ptr [7FF906B43A90],0
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
       mov       r11,7FF8A6B31038
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
       mov       rdx,7FF8A7545B60
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FF8A72AC7D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FF8A7545DE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FF8A7545BA0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FF8A7546468
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FF8A7546488
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FF8A75465E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FF8A7542C40
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FF8A7542CD8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FF8A6B31038
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
       mov       rdx,7FF8A7545BC0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        short M05_L39
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF8A73FEB68]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        short M05_L40
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       short M05_L41
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L44
M05_L39:
       mov       rcx,rdx
       mov       rdx,7FF8A7545C08
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M05_L37
M05_L40:
       mov       rcx,rdx
       mov       rdx,7FF8A7545C28
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M05_L38
M05_L41:
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
       call      qword ptr [7FF8A73FEBC8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FF8A73FEBC8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L42:
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
M05_L43:
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
M05_L44:
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
       jne       short M05_L45
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73FEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A73FEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L45:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L46:
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
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FF8A749F520
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L42
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8A7186AA8]
       int       3
M05_L49:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L50
       jmp       short M05_L51
M05_L50:
       mov       rdx,7FF8A72F7F00
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
       call      qword ptr [7FF8A6D5E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A75351D0]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A746D0C0]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B31028
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
       mov       rdx,7FF8A7545E10
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
       call      qword ptr [7FF8A6D5E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FF8A6B31030
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
       call      qword ptr [7FF8A6D5E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FF8A7534F90]
       int       3
M05_L67:
       call      qword ptr [7FF8A6D57198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8A7216D78]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FF8A6FFD578]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FF8A6E0C228]
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
       call      qword ptr [7FF8A7534C48]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF8A7186AA8]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FF8A72CFA98]
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
       call      qword ptr [7FF8A710DA28]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FF8A73FFE10]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M05_L81:
       call      qword ptr [7FF8A72C5D10]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L43
M05_L83:
       mov       ecx,847
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FF8A7468F10
       call      qword ptr [7FF8A6E07798]
       mov       rcx,rax
       call      qword ptr [7FF8A7534300]
       int       3
M05_L86:
       call      qword ptr [7FF8A7534D98]
       mov       rsi,rax
       jmp       near ptr M05_L46
M05_L87:
       mov       rsi,rcx
       jmp       near ptr M05_L46
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
       mov       r11,7FF8A6B31030
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2771
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
       je        near ptr M07_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M07_L00
       test      rbx,rbx
       je        near ptr M07_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M07_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9068852E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A6BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A6BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L00:
       test      rbx,rbx
       je        short M07_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L02
M07_L01:
       mov       rax,29F6A2B0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       call      qword ptr [7FF8A73FF4F8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FF8A6BE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

