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
       mov       rax,227E6802A78
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
       call      qword ptr [7FFCE0176F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF8E0EA0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE0176F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF8E0EA8
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
       mov       rdx,227E6802A70
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,227E6802A78
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCDFBBC2A0]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBBC030]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE017DB60]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE0205C20]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0E98
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCDF8E0EB0
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
       mov       r11,7FFCDF8E0EB0
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
       call      qword ptr [7FFCE0205D10]
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
       call      qword ptr [7FFCE0205CF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD0CC90]
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
       call      qword ptr [7FFCE0176EF8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCDFF4F828]
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
       mov       rax,218B9C00A50
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
       call      qword ptr [7FFCE01A6598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF910DD8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE01A6598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF910DE0
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
       mov       rdx,218B9C00A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,218B9C00A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCDFBE7A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC68C90
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE01AD008]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE01AF018]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF910DD0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCDF910DE8
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
       mov       r11,7FFCDF910DE8
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
       call      qword ptr [7FFCE01AF150]
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
       call      qword ptr [7FFCE01AF138]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD17DE0]
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
       call      qword ptr [7FFCE01A6568]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCE01AD668]
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
       mov       rax,288D7C00A38
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L31
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L32
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L35
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
       jbe       near ptr M00_L34
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
       mov       rdx,7FFCDFC58C90
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE0187C18]
       int       3
M00_L06:
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
       call      qword ptr [7FFCE008E868]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L36
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
       mov       r11,7FFCDF900B50
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE008E868]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFCDF900B58
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
       jne       near ptr M00_L37
M00_L23:
       mov       ebx,1
       jmp       short M00_L29
M00_L24:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L33
       add       r14,10
       jmp       short M00_L26
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
       jne       short M00_L30
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L27
M00_L28:
       xor       ebx,ebx
M00_L29:
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
M00_L30:
       mov       ebx,1
       jmp       short M00_L29
M00_L31:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,288D7C00A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,288D7C00A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L32:
       xor       ebx,ebx
       jmp       short M00_L29
M00_L33:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FFCE0187AB0]
       jmp       near ptr M00_L02
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFCDF900B48
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L36:
       call      M00_L38
       jmp       near ptr M00_L28
M00_L37:
       mov       r11,7FFCDF900B60
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L39
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L39
       mov       rcx,rax
       mov       r11,7FFCDF900B60
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1001
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
       call      qword ptr [7FFCE0187CF0]
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
       call      qword ptr [7FFCE0187CD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD07DE0]
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
       call      qword ptr [7FFCE008E838]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCE018E730]
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
       mov       rax,27038C00A50
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
       call      qword ptr [7FFCE0196568]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE0196568]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF900DF8
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
       mov       rdx,27038C00A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27038C00A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC58C90
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE019CFF0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE019EFD0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF900DE8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCDF900E00
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
       mov       r11,7FFCDF900E00
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
       call      qword ptr [7FFCE019F138]
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
       call      qword ptr [7FFCE019F120]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD07DE0]
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
       call      qword ptr [7FFCE0196538]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCE019D650]
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
       mov       rax,25F94402A48
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
       call      qword ptr [7FFCE0196520]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF900DE0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE0196520]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF900DE8
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
       mov       rdx,25F94402A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25F94402A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC58C90
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE019CFF0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE019F018]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF900DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCDF900DF0
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
       mov       r11,7FFCDF900DF0
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
       call      qword ptr [7FFCE019F150]
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
       call      qword ptr [7FFCE019F138]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD07DE0]
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
       call      qword ptr [7FFCE019F018]
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
       call      qword ptr [7FFCE019D650]
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
       mov       rax,2686D800A50
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
       call      qword ptr [7FFCE01460B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF8D0DF0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE01460B8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF8D0DF8
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
       mov       rdx,2686D800A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF986BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2686D800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFCDFBA7A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC28C90
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE014CFF0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE014EFD0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF8D0DE8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFCDF8D0E00
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
       mov       r11,7FFCDF8D0E00
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
       call      qword ptr [7FFCE014F138]
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
       call      qword ptr [7FFCE014F120]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFCD7DE0]
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
       call      qword ptr [7FFCE0146088]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCE014D650]
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
       mov       rax,22BDB000A90
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
       call      qword ptr [7FFCE01BCE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF910F98
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE01BCE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF910FA0
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
       call      qword ptr [7FFCDFBE7A08]
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
       mov       rdx,22BDB000A88
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22BDB000A90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC68C90
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE00BE010]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE02741B0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF910F90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFCDF910FA8
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
       mov       r11,7FFCDF910FA8
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
       call      qword ptr [7FFCE02742A0]
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
       call      qword ptr [7FFCE0274288]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD17DE0]
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
       call      qword ptr [7FFCE01BCDF8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCE00BE718]
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
       mov       rax,1F8FAC00AF8
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
       call      qword ptr [7FFCE01CE850]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFCDF901210
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFCE01CE850]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFCDF901218
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
       call      qword ptr [7FFCDFBD7A08]
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
       mov       rdx,1F8FAC00AF0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F8FAC00AF8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFCDFC58C90
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFCE00A5BD8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFCE02F44E0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFCDF901208
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFCDF901220
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
       mov       r11,7FFCDF901220
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
       call      qword ptr [7FFCE02F4600]
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
       call      qword ptr [7FFCE02F45E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD07DE0]
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
       call      qword ptr [7FFCE01CE820]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFCE00A62E0]
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
       mov       r8,25F32C00A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE010CA38]
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
       call      qword ptr [7FFCE018FC78]
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
       mov       r11,7FFCDF8F0CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE018F900]
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
       call      qword ptr [7FFCE018F900]
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
       call      qword ptr [7FFCE0186820]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE0186850]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE0186628]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE01C0158
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0186898]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF4F3F0]
       mov       ecx,65
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE018FC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018E838]
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
       mov       r11,7FFCDF8F0CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE018D350]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE018F888]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFCF5F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE018D350]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE018F588]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE018F588]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE018F5E8]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF8F0CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25F32C00AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE018F918]
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE018C768]
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
       jmp       qword ptr [7FFCDF9AD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
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
       call      qword ptr [7FFCE0186880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0186880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
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
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
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
       mov       r11,7FFCDF8F0CD0
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
       mov       rdx,7FFCE021D258
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFCE01D1F10
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFCE021D598
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFCE021D298
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFCE021DC18
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFCE021DC38
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFCE021DD98
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFCE02197A0
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFCE0219838
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCDF8F0CD0
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
       mov       rdx,7FFCE021D2B8
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE0186778]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCE0186880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0186880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE021D3A0
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFCE021D3C0
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE01867D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE01867D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFCE021B588
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFF46A60]
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
       mov       rdx,7FFCE0217040
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE018FD08]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE01A9D18]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F0CC0
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
       mov       rdx,7FFCE021D5C0
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F0CC8
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
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFCE018FA80]
       int       3
M05_L67:
       call      qword ptr [7FFCDFB17198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCDFF4EE98]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFCDFDBD530]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFCDFBCC228]
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
       call      qword ptr [7FFCE018F420]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF46A60]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFCE018F450]
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
       call      qword ptr [7FFCDFECD9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE018FAF8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M05_L81:
       call      qword ptr [7FFCE009D380]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE01A5B68
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE018F618]
       int       3
M05_L86:
       call      qword ptr [7FFCE018F918]
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
       mov       r11,7FFCDF8F0CC8
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29FB1CC0008
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
       call      qword ptr [7FFCE018EE20]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       r8,11AD5002A40
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE012CAF8]
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
       call      qword ptr [7FFCE01AFC48]
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
       mov       r11,7FFCDF910CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01AF8D0]
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
       call      qword ptr [7FFCE01AF8D0]
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
       call      qword ptr [7FFCE01A67F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE01A6820]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE01A65F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE01E0158
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01A6868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF6F288]
       mov       ecx,65
       mov       rdx,7FFCDFDE2518
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE2518
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE01AFC30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE01AE808]
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
       mov       r11,7FFCDF910CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC68C90
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE01AD320]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE01AF858]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFD15F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC68C90
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE01AD320]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE01AF558]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE01AF558]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE01AF5B8]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF910CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,11AD5002AD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE01AF8E8]
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE01AC738]
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
       jmp       qword ptr [7FFCDF9CD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
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
       call      qword ptr [7FFCE01A6850]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01A6850]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
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
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
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
       mov       r11,7FFCDF910CC8
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
       mov       rdx,7FFCE023D288
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFCE01F1F10
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFCE023D5C8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFCE023D2C8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFCE023DC48
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFCE023DC68
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFCE023DDC8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFCE02398F8
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFCE0239990
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCDF910CC8
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
       mov       rdx,7FFCE023D2E8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE01A6748]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCE01A67A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE01A67A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFCE01A6850]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01A6850]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE023D3D0
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFCE023D3F0
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FFCE023B5C0
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFF66A60]
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
       mov       rdx,7FFCE0237020
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB3E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01AFCD8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE01C9D18]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF910CB8
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
       mov       rdx,7FFCE023D5F0
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB3E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF910CC0
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
       call      qword ptr [7FFCDFB3E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFCE01AFA50]
       int       3
M05_L67:
       call      qword ptr [7FFCDFB37198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCDFF6EE98]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFCDFDDD530]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFCDFBEC228]
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
       call      qword ptr [7FFCE01AF3F0]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF66A60]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFCE01AF420]
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
       call      qword ptr [7FFCDFEED9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE01AFAC8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M05_L81:
       call      qword ptr [7FFCE00BD368]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE01C5B68
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF5E8]
       int       3
M05_L86:
       call      qword ptr [7FFCE01AF8E8]
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
       mov       r11,7FFCDF910CC0
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,15B6A030008
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
       call      qword ptr [7FFCE01AEDF0]
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FFCDF9A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       r8,224E8400A30
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE00A4878]
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
       call      qword ptr [7FFCE019CCA8]
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
       mov       r11,7FFCDF8F0BB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE019C750]
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
       call      qword ptr [7FFCE019C750]
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
       call      qword ptr [7FFCE006EC40]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE006EC70]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE006EA48]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE014D628
       cmp       [rcx],ecx
       call      qword ptr [7FFCE006ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF47750]
       mov       ecx,65
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE019CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019CC90]
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
       mov       r11,7FFCDF8F0BA8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE019C618]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE019C6C0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFCF5F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE019C618]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE0197F60]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE0197F60]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE0197FC0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF8F0BB0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,224E8400A68
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE019C768]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L49:
       mov       rsi,rbp
       jmp       near ptr M00_L30
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2100
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE0197F48]
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
       jmp       qword ptr [7FFCDF9AD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
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
       call      qword ptr [7FFCE006ECA0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE006ECA0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
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
       je        near ptr M05_L50
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
       js        near ptr M05_L51
       test      r13d,r13d
       je        near ptr M05_L52
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
       call      qword ptr [7FFCDFB1F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L59
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L55
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
       jl        near ptr M05_L65
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L15
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L68
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L16
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L69
       cmp       [rdi+8],r13d
       jb        near ptr M05_L70
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
       ja        near ptr M05_L17
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
       je        near ptr M05_L18
       jmp       near ptr M05_L71
M05_L11:
       mov       rcx,rdx
       mov       rdx,7FFCE0174CF8
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L12:
       mov       rdx,7FFCE0174FB0
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L13:
       mov       rdx,7FFCE01750C8
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,rdx
       mov       rdx,7FFCE0174D38
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L15:
       mov       rcx,rdi
       mov       rdx,7FFCE0175748
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L16:
       mov       rcx,rdx
       mov       rdx,7FFCE0175768
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L17:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCE0064AF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L18:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L19:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L77
       cmp       esi,1
       jle       near ptr M05_L25
       mov       rdx,[r14+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0C0]
       test      rdi,rdi
       je        short M05_L21
M05_L20:
       mov       r14,[r15+8]
       test      r14,r14
       jne       short M05_L22
       mov       ecx,2
       call      qword ptr [7FFCDFBCC228]
       int       3
M05_L21:
       mov       rcx,r14
       mov       rdx,7FFCE01759E0
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M05_L20
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
M05_L26:
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
       je        short M05_L27
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFCDF8F0BD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L28
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
M05_L28:
       inc       edi
       jmp       near ptr M05_L26
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFCE0175B90
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L23
M05_L30:
       mov       rcx,rdi
       mov       rdx,7FFCE0175C28
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L24
M05_L31:
       mov       ecx,10
       call      qword ptr [7FFCE019CA20]
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
       mov       r11,7FFCDF8F0BD0
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
       mov       rdx,7FFCE0174D58
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L44
M05_L39:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFCE006EB98]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L45
M05_L40:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       jne       near ptr M05_L46
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L41:
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
       jne       short M05_L42
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE006ECA0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE006ECA0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L42:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L43:
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
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFCE0174E40
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L39
M05_L45:
       mov       rcx,rdx
       mov       rdx,7FFCE0174E60
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L40
M05_L46:
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
       call      qword ptr [7FFCE006EBF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE006EBF8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L49
M05_L47:
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
M05_L48:
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
       jmp       near ptr M05_L41
M05_L49:
       mov       rcx,rsi
       mov       rdx,7FFCE0172458
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L47
M05_L50:
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
M05_L51:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCDFF46A60]
       int       3
M05_L52:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L53
       jmp       short M05_L54
M05_L53:
       mov       rdx,7FFCE0174FB8
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L54:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L55:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L58
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L56
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L57
M05_L56:
       mov       edx,4
M05_L57:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L58:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE019CD50]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L59:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE01471E8]
       mov       [rbp-58],rax
M05_L60:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F0BC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L64
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M05_L61
       jmp       short M05_L62
M05_L61:
       mov       rcx,r14
       mov       rdx,7FFCE01750F0
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L62:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M05_L63
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L60
M05_L63:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFCDFB1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L60
M05_L64:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F0BC8
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L65:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L66
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L67
M05_L66:
       mov       eax,4
M05_L67:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L68:
       test      r13d,r13d
       jne       short M05_L70
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L69:
       call      qword ptr [7FFCE019C978]
       int       3
M05_L70:
       call      qword ptr [7FFCDFB17198]
       int       3
M05_L71:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L18
M05_L72:
       call      qword ptr [7FFCDFDBD530]
       int       3
M05_L73:
       test      r8,r8
       je        near ptr M05_L28
       jmp       near ptr M05_L27
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
       call      qword ptr [7FFCE019CA38]
       int       3
M05_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF46A60]
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
       call      qword ptr [7FFCDFECD9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE019CAF8]
       jmp       near ptr M05_L38
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M05_L81:
       call      qword ptr [7FFCE0065770]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L48
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE0143038
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE019C2A0]
       int       3
M05_L86:
       call      qword ptr [7FFCE019C768]
       mov       rbx,rax
       jmp       near ptr M05_L43
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L43
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
       mov       r11,7FFCDF8F0BC8
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2789
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26567360008
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
       call      qword ptr [7FFCE019DC20]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       r8,1ACB7400A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE00ECEF8]
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
       call      qword ptr [7FFCE016FC60]
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
       mov       r11,7FFCDF8D0CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE016F8D0]
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
       call      qword ptr [7FFCE016F8D0]
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
       call      qword ptr [7FFCE0166820]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE0166850]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE0166628]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE01A07F8
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0166898]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF2F3F0]
       mov       ecx,65
       mov       rdx,7FFCDFDA2518
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC54F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDA2518
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016FC48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016E808]
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
       mov       r11,7FFCDF8D0CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC28C90
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE016D320]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE016F858]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFCD5F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC28C90
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE016D320]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE016F558]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE016F558]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE016F5B8]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF8D0CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ACB7400AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE016F8E8]
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE016C738]
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
       jmp       qword ptr [7FFCDF98D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
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
       call      qword ptr [7FFCE0166880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0166880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
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
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
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
       mov       r11,7FFCDF8D0CC8
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
       mov       rdx,7FFCE01FD128
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFCE01B1C68
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFCE01FD468
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFCE01FD168
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFCE01FDAE8
       call      qword ptr [7FFCDFBA7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFCE01FDB08
       call      qword ptr [7FFCDFBA7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFCE01FDC68
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFCE01F98F0
       call      qword ptr [7FFCDFBA7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFCE01F9988
       call      qword ptr [7FFCDFBA7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCDF8D0CC8
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
       mov       rdx,7FFCE01FD188
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE0166778]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCE0166880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0166880]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE01FD270
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFCE01FD290
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE01667D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE01667D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFCE01FBD88
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFF26A60]
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
       mov       rdx,7FFCE01F6F00
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFAFE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE016FCF0]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE018A3A8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8D0CB8
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
       mov       rdx,7FFCE01FD490
       call      qword ptr [7FFCDF98C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFAFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8D0CC0
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
       call      qword ptr [7FFCDFAFE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFCE016FA50]
       int       3
M05_L67:
       call      qword ptr [7FFCDFAF7198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCDFF2EE98]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFCDFD9D530]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFCDFBAC228]
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
       call      qword ptr [7FFCE016F408]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF26A60]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFCE016F438]
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
       call      qword ptr [7FFCDFEAD9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE016FAC8]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L81:
       call      qword ptr [7FFCE007D3B0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE01861F8
       call      qword ptr [7FFCDFBA7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L86:
       call      qword ptr [7FFCE016F8E8]
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
       mov       r11,7FFCDF8D0CC0
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1ED363E0008
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
       call      qword ptr [7FFCE016EDF0]
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
       jmp       qword ptr [7FFCDF985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       r8,29470402A40
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE00FB698]
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
       call      qword ptr [7FFCE016FC78]
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
       mov       r11,7FFCDF8F0CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE016F8D0]
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
       call      qword ptr [7FFCE016F8D0]
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
       call      qword ptr [7FFCE0166388]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE01663B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE0166190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE019F560
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0166400]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF4EF40]
       mov       ecx,65
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016FC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016E820]
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
       mov       r11,7FFCDF8F0CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE016D338]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE016F858]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFCF5F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE016D338]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE016F558]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE016F558]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE016F5B8]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF8F0CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29470402AD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE016F8E8]
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE016C768]
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
       jmp       qword ptr [7FFCDF9AD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
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
       call      qword ptr [7FFCE01663E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01663E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
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
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
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
       mov       rdx,7FFCE021FA18
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L13:
       mov       rdx,7FFCE01C57E8
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L14:
       mov       rdx,7FFCE021FD58
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,rdx
       mov       rdx,7FFCE021FA58
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L16:
       mov       rcx,rdi
       mov       rdx,7FFCE02503D8
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L17:
       mov       rcx,rdx
       mov       rdx,7FFCE02503F8
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L18:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCE008C258]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r11,7FFCDF8F0CC8
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
       mov       rdx,7FFCE0250558
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L21
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFCE021CA38
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L22
M05_L30:
       mov       rcx,rdi
       mov       rdx,7FFCE021CAD0
       call      qword ptr [7FFCDFBC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCDF8F0CC8
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
       mov       rdx,7FFCE021FA78
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE01662E0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCE0166340]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE0166340]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFCE01663E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01663E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE021FB60
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rdx
       mov       rdx,7FFCE021FB80
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       mov       rdx,7FFCE021E678
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFF46A60]
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
       mov       rdx,7FFCE021A048
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE016FD08]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE0199120]
       mov       [rbp-58],rax
M05_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F0CB8
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
       mov       rdx,7FFCE021FD80
       call      qword ptr [7FFCDF9AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L58
M05_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F0CC0
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
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L66:
       test      r13d,r13d
       jne       short M05_L68
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L67:
       call      qword ptr [7FFCE016FA50]
       int       3
M05_L68:
       call      qword ptr [7FFCDFB17198]
       int       3
M05_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L19
M05_L70:
       call      qword ptr [7FFCDFDBD530]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFCDFBCC228]
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
       call      qword ptr [7FFCE016F420]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF46A60]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFCE016F450]
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
       call      qword ptr [7FFCDFECD9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE016FAC8]
       jmp       near ptr M05_L37
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L81:
       call      qword ptr [7FFCE008CED0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L41
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE0194F70
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE016F7E0]
       int       3
M05_L86:
       call      qword ptr [7FFCE016F8E8]
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
       mov       r11,7FFCDF8F0CC0
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D505450008
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
       call      qword ptr [7FFCE016EE08]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       r8,2394B400A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE012C598]
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
       call      qword ptr [7FFCE01AFC78]
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
       mov       r11,7FFCDF910CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01AF8E8]
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
       call      qword ptr [7FFCE01AF8E8]
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
       call      qword ptr [7FFCE01A6730]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE01A6760]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE01A6538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE01CFBD8
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01A67A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF6F138]
       mov       ecx,65
       mov       rdx,7FFCDFDE2518
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE2518
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE01AFC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE01AE838]
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
       mov       r11,7FFCDF910CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC68C90
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE01AD350]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE01AF870]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFD15F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC68C90
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE01AD350]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE01AF570]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE01AF570]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE01AF5D0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF910CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2394B400AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE01AF900]
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE01AC768]
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
       jmp       qword ptr [7FFCDF9CD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
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
       call      qword ptr [7FFCE01A6790]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01A6790]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
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
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
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
       mov       r11,7FFCDF910CC8
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
       mov       rdx,7FFCE023CBA8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFCE01F24E8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFCE023CEE8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFCE023CBE8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFCE023D568
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFCE023D588
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFCE023D6E8
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFCE0239BC8
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFCE0239C60
       call      qword ptr [7FFCDFBE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFCDF910CC8
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
       mov       rdx,7FFCE023CC08
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE01A6688]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCE01A6790]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01A6790]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE023CCF0
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFCE023CD10
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCE01A66E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE01A66E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFCE023B808
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCDFF66A60]
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
       mov       rdx,7FFCE0237180
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB3E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01AFD08]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE01C9798]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF910CB8
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
       mov       rdx,7FFCE023CF10
       call      qword ptr [7FFCDF9CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCDFB3E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF910CC0
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
       call      qword ptr [7FFCDFB3E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFCE01AFA68]
       int       3
M05_L67:
       call      qword ptr [7FFCDFB37198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCDFF6EE98]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFCDFDDD530]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFCDFBEC228]
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
       call      qword ptr [7FFCE01AF438]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF66A60]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFCE01AF468]
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
       call      qword ptr [7FFCDFEED9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE01AFAE0]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M05_L81:
       call      qword ptr [7FFCE00BD380]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE01C55E8
       call      qword ptr [7FFCDFBE7798]
       mov       rcx,rax
       call      qword ptr [7FFCE01AF7F8]
       int       3
M05_L86:
       call      qword ptr [7FFCE01AF900]
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
       mov       r11,7FFCDF910CC0
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,279CA4F0008
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
       call      qword ptr [7FFCE01AEE20]
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        near ptr M00_L31
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
       mov       r14,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       inc       ebp
       or        ebp,1
       xor       esi,esi
       lzcnt     esi,ebp
       xor       esi,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack<System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       add       esi,esi
       js        near ptr M00_L36
       mov       edx,esi
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       r8,16DCC002A40
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L29
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE011FF98]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,r8d
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L29
       xor       r15d,r15d
       inc       edi
M00_L08:
       dec       edi
       je        near ptr M00_L27
       mov       r13,[rsi+r15]
       mov       r12,[rbp+10]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M00_L26
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L24
       mov       rax,r14
       mov       [rsp+40],rax
       mov       r8,[rax+8]
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFCDF8E0E28
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L14
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0254A20]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        near ptr M00_L17
       cmp       byte ptr [r14+24],0
       je        short M00_L10
       mov       r12,[r14+8]
       mov       rax,[r14+10]
       mov       [rsp+38],rax
       test      r13,r13
       jne       short M00_L09
       mov       r13,[r14+18]
M00_L09:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L25
       test      r13,r13
       jne       near ptr M00_L43
       jmp       near ptr M00_L49
M00_L10:
       test      r13,r13
       je        short M00_L11
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L11:
       mov       rax,[r14+10]
       movzx     ecx,byte ptr [rax+25]
       mov       r9,[r14+18]
       movzx     edx,byte ptr [r9+25]
       cmp       ecx,edx
       jl        near ptr M00_L45
M00_L12:
       add       ecx,1
       jo        near ptr M00_L52
       cmp       ecx,0FF
       ja        near ptr M00_L52
       mov       [r14+25],cl
       mov       ecx,[rax+20]
       add       ecx,[r9+20]
       inc       ecx
       mov       [r14+20],ecx
M00_L13:
       mov       [rsp+40],r14
       jmp       short M00_L17
M00_L14:
       test      eax,eax
       jge       near ptr M00_L23
       mov       rax,[rsp+40]
       mov       rcx,[rax+10]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0254A20]
       mov       r13,rax
       cmp       byte ptr [rsp+60],0
       je        short M00_L17
       cmp       byte ptr [r14+24],0
       je        short M00_L19
       mov       r12,[r14+8]
       test      r13,r13
       je        near ptr M00_L46
M00_L15:
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
       call      qword ptr [7FFCE0167540]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r14,[rsp+30]
M00_L16:
       mov       [rsp+40],r14
M00_L17:
       cmp       byte ptr [rsp+60],0
       jne       short M00_L22
       mov       r14,[rsp+40]
M00_L18:
       add       r15,8
       jmp       near ptr M00_L08
M00_L19:
       test      r13,r13
       jne       near ptr M00_L47
M00_L20:
       mov       rdx,[r14+10]
       movzx     ecx,byte ptr [rdx+25]
       mov       rax,[r14+18]
       movzx     r8d,byte ptr [rax+25]
       cmp       ecx,r8d
       jl        near ptr M00_L48
M00_L21:
       add       ecx,1
       jo        near ptr M00_L52
       cmp       ecx,0FF
       ja        near ptr M00_L52
       mov       [r14+25],cl
       mov       edx,[rdx+20]
       add       edx,[rax+20]
       inc       edx
       mov       [r14+20],edx
       jmp       short M00_L16
M00_L22:
       mov       r14,[rsp+40]
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFCE0254D38]
       mov       r14,rax
       jmp       short M00_L18
M00_L23:
       xor       ecx,ecx
       mov       [rsp+60],ecx
       jmp       short M00_L18
M00_L24:
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
       jo        near ptr M00_L52
       cmp       ecx,0FF
       ja        near ptr M00_L52
       mov       [r12+25],cl
       mov       ecx,[r14+20]
       add       ecx,ecx
       inc       ecx
       mov       [r12+20],ecx
       mov       byte ptr [r12+24],0
       mov       r14,r12
       jmp       near ptr M00_L18
M00_L25:
       mov       ecx,847
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M00_L26:
       mov       ecx,873
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M00_L27:
       cmp       r14,[rbp+8]
       je        near ptr M00_L51
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L50
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rbp+10]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFCE0167570]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L28:
       jmp       short M00_L30
M00_L29:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE0167348]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L30:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE01B07F8
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01675B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L31:
       call      qword ptr [7FFCDFF3EF40]
       mov       ecx,65
       mov       rdx,7FFCDFDB2518
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB2518
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016F3A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F120]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0E18
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L34:
       mov       ecx,80B
       mov       rdx,7FFCDFC38C90
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE016D338]
       int       3
M00_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE02549C0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFCE5F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,783
       mov       rdx,7FFCDFC38C90
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFCE016D338]
       int       3
M00_L37:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE0254858]
       jmp       near ptr M00_L02
M00_L38:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE0254858]
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rbp
       call      qword ptr [7FFCE0254888]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF8E0E20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16DCC002B30
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L43:
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
       jge       short M00_L44
       mov       ecx,edx
M00_L44:
       add       ecx,1
       jo        near ptr M00_L52
       cmp       ecx,0FF
       ja        near ptr M00_L52
       mov       [r14+25],cl
       mov       ecx,[r12+20]
       add       ecx,[r13+20]
       inc       ecx
       mov       [r14+20],ecx
       mov       byte ptr [r14+24],0
       jmp       near ptr M00_L13
M00_L45:
       mov       ecx,edx
       jmp       near ptr M00_L12
M00_L46:
       mov       r13,[r14+10]
       jmp       near ptr M00_L15
M00_L47:
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L20
M00_L48:
       mov       ecx,r8d
       jmp       near ptr M00_L21
M00_L49:
       mov       ecx,851
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M00_L50:
       mov       rcx,rbp
       call      qword ptr [7FFCE0254978]
       mov       rsi,rax
       jmp       near ptr M00_L28
M00_L51:
       mov       rsi,rbp
       jmp       near ptr M00_L28
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2098
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       call      qword ptr [7FFCE016C750]
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
       jmp       qword ptr [7FFCDF99D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
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
       je        short M04_L02
       test      rdi,rdi
       je        short M04_L01
       cmp       byte ptr [rbx+24],0
       jne       short M04_L00
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01675A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01675A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       ecx,873
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M04_L02:
       mov       ecx,4AB
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
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
       js        near ptr M05_L52
       test      r13d,r13d
       je        near ptr M05_L53
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
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        near ptr M05_L23
       mov       rcx,rax
M05_L04:
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L60
       mov       rcx,[rdi+8]
       mov       r13d,[rcx+20]
       test      r13d,r13d
       jg        near ptr M05_L56
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
       jl        near ptr M05_L66
M05_L07:
       mov       rdx,[rdi+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M05_L25
M05_L08:
       mov       rdi,[r15+8]
       mov       r13d,[r15+10]
       test      rdi,rdi
       je        near ptr M05_L69
       mov       rax,[rdx+18]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M05_L26
M05_L09:
       cmp       [rdi],rax
       jne       near ptr M05_L70
       cmp       [rdi+8],r13d
       jb        near ptr M05_L71
       mov       eax,r13d
       lea       rax,[rdi+rax*8+10]
       mov       edx,[rdi+8]
       sub       edx,r13d
M05_L10:
       cmp       esi,edx
       jg        near ptr M05_L74
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L73
       mov       rcx,rax
       mov       rdx,rbx
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
       jne       near ptr M05_L72
M05_L11:
       add       [r15+10],esi
       inc       dword ptr [r15+14]
M05_L12:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       esi,[r15+10]
       test      esi,esi
       jl        near ptr M05_L80
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
       je        near ptr M05_L75
       cmp       [r14+8],esi
       jl        near ptr M05_L81
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
       jae       near ptr M05_L84
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L88
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L84
       cmp       ebx,r11d
       jae       near ptr M05_L88
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L76
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFCDF8E0E40
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L84
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L84
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
       mov       rdx,7FFCE02700F0
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFCE01C12F0
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFCE0270378
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFCE0270130
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFCE02709F8
       call      qword ptr [7FFCDFBB7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFCE0270A18
       call      qword ptr [7FFCDFBB7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFCE0270B78
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFCE023BFC8
       call      qword ptr [7FFCDFBB7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFCE023C060
       call      qword ptr [7FFCDFBB7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jne       near ptr M05_L77
       test      r14,r14
       je        near ptr M05_L78
       test      r8,r8
       je        short M05_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFCDF8E0E40
       call      qword ptr [r11]
M05_L31:
       test      eax,eax
       je        short M05_L33
M05_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L84
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L84
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
       jae       near ptr M05_L84
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L88
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L84
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFCE0270150
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L30
M05_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L79
       test      ebx,ebx
       jl        near ptr M05_L80
       test      ebx,ebx
       jg        near ptr M05_L82
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
       call      qword ptr [7FFCE0167498]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       jne       short M05_L41
       mov       ecx,40B
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M05_L39:
       mov       rcx,rdx
       mov       rdx,7FFCE0270198
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M05_L37
M05_L40:
       mov       rcx,rdx
       mov       rdx,7FFCE02701B8
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M05_L38
M05_L41:
       test      edi,edi
       jne       short M05_L43
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L42:
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
       jne       near ptr M05_L48
       mov       ecx,873
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
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
       call      qword ptr [7FFCE01674F8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE01674F8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M05_L46
M05_L44:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L85
       cmp       edi,[rbx+10]
       jae       near ptr M05_L84
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
       jne       short M05_L47
       mov       ecx,847
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFCE023D648
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L44
M05_L47:
       test      r14,r14
       je        near ptr M05_L51
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
       jmp       near ptr M05_L42
M05_L48:
       cmp       byte ptr [r14+24],0
       jne       short M05_L49
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01675A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01675A0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M05_L49:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L50:
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
M05_L51:
       mov       ecx,851
       mov       rdx,7FFCE01961E8
       call      qword ptr [7FFCDFBB7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02547E0]
       int       3
M05_L52:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCDFF36A60]
       int       3
M05_L53:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L54
       jmp       short M05_L55
M05_L54:
       mov       rdx,7FFCE01CFAC8
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L56:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       sub       ecx,[r15+10]
       cmp       ecx,r13d
       jge       short M05_L59
       mov       ecx,r13d
       add       ecx,[r15+10]
       jo        near ptr M05_L89
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       je        short M05_L57
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L58
M05_L57:
       mov       edx,4
M05_L58:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,r15
       call      qword ptr [7FFCDFB0E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L59:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0254DC8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L60:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE019A398]
       mov       [rbp-58],rax
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8E0E30
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L65
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M05_L62
       jmp       short M05_L63
M05_L62:
       mov       rcx,r14
       mov       rdx,7FFCE02703A0
       call      qword ptr [7FFCDF99C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L63:
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edi,[r15+10]
       cmp       [rcx+8],edi
       jbe       short M05_L64
       lea       edx,[rdi+1]
       mov       [r15+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L61
M05_L64:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFCDFB0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L61
M05_L65:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8E0E38
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L66:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L89
       mov       rax,[r15+8]
       cmp       dword ptr [rax+8],0
       je        short M05_L67
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       short M05_L68
M05_L67:
       mov       eax,4
M05_L68:
       mov       r8d,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,r8d
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFCDFB0E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L69:
       test      r13d,r13d
       jne       short M05_L71
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L70:
       call      qword ptr [7FFCE0254B70]
       int       3
M05_L71:
       call      qword ptr [7FFCDFB07198]
       int       3
M05_L72:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L73:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCDFFC6D00]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L74:
       call      qword ptr [7FFCDFDAD530]
       int       3
M05_L75:
       mov       ecx,2
       call      qword ptr [7FFCDFBBC228]
       int       3
M05_L76:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L77:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L78:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L79:
       call      qword ptr [7FFCE02544C8]
       int       3
M05_L80:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF36A60]
       int       3
M05_L81:
       mov       ecx,10
       call      qword ptr [7FFCE02544F8]
       int       3
M05_L82:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L83
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFCDFEBD9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L83:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE0254180]
       jmp       near ptr M05_L36
M05_L84:
       call      qword ptr [7FFCE007E190]
       int       3
M05_L85:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L86:
       call      qword ptr [7FFCE0254978]
       mov       rbx,rax
       jmp       near ptr M05_L50
M05_L87:
       mov       rbx,rcx
       jmp       near ptr M05_L50
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
       mov       r11,7FFCDF8E0E38
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2783
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1AE60FB0008
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
       call      qword ptr [7FFCE016F858]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       r8,1BE0F800AF0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFCE0282BF8]
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
       call      qword ptr [7FFCE02F5128]
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
       mov       r11,7FFCDF8F1020
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCE02F4D68]
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
       call      qword ptr [7FFCE02F4D68]
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
       call      qword ptr [7FFCE01BEC10]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFCE01BEC40]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFCE01BEA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFCE0243510
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01BEC88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCDFF4F318]
       mov       ecx,65
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC2518
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0097150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE0097168]
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
       mov       r11,7FFCDF8F1010
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE0095BA8]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE02F4CF0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDFCF5F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFCDFC48C90
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFCE0095BA8]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFCE02F4090]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFCE02F4090]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFCE02F40C0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFCDF8F1018
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BE0F800B40
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFCE02F4D80]
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
       jmp       near ptr 00007FFD3F6340D0
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFCE0094BE8]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCDF9AD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
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
       call      qword ptr [7FFCE01BEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01BEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
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
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
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
       mov       r11,7FFCDF8F1038
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
       mov       rdx,7FFCE0303E70
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFCE00777C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFCE03041B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFCE0303EB0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFCE0304830
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFCE0304850
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFCE03049B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFCE0302650
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFCE03026E8
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
       mov       r11,7FFCDF8F1038
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
       mov       rdx,7FFCE0303ED0
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
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M05_L42
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFCE01BEB68]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFCE01BEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE01BEC70]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFCE0303FB8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFCE0303FD8
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
       call      qword ptr [7FFCE01BEBC8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFCE01BEBC8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFCE025F158
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCDFF46A60]
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
       mov       rdx,7FFCE00B5108
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
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCE02F51B8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCE022D0C0]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F1028
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
       mov       rdx,7FFCE03041D8
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
       call      qword ptr [7FFCDFB1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFCDF8F1030
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
       call      qword ptr [7FFCDFB1E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFCE02F4EE8]
       int       3
M05_L67:
       call      qword ptr [7FFCDFB17198]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCDFFE7198]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFCDFDBD530]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFCDFBCC228]
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
       call      qword ptr [7FFCE02F4C48]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCDFF46A60]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFCE009FAE0]
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
       call      qword ptr [7FFCDFECD9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFCE01BFE10]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M05_L81:
       call      qword ptr [7FFCE0095CE0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L83:
       mov       ecx,847
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFCE0228F10
       call      qword ptr [7FFCDFBC7798]
       mov       rcx,rax
       call      qword ptr [7FFCE02F4348]
       int       3
M05_L86:
       call      qword ptr [7FFCE02F4D80]
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
       mov       r11,7FFCDF8F1030
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2788
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FE8E850008
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
       call      qword ptr [7FFCE01BF4F8]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

