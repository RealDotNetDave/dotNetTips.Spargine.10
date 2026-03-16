## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,25107800AD8
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
       call      qword ptr [7FFA030ED518]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA028C10C0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA030ED518]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA028C10C8
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
       mov       rdx,25107800AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25107800AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFA02B97A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFA02C18C90
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA031F4720]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFA031FE388]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFA028C10B8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFA028C10D0
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
       mov       r11,7FFA028C10D0
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
       call      qword ptr [7FFA031FE478]
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
       call      qword ptr [7FFA031FE460]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CE7B40]
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
       call      qword ptr [7FFA030ED4E8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA031F50E0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,10F2D002AD8
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
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA0314F240]
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
       call      qword ptr [7FFA031458C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA02890D10
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA031458C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFA02890D18
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
M00_L30:
       mov       ebx,1
       jmp       short M00_L29
M00_L31:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,10F2D002AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,10F2D002AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L32:
       xor       ebx,ebx
       jmp       short M00_L29
M00_L33:
       call      qword ptr [7FFA02B67A08]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FFA0314F0A8]
       jmp       near ptr M00_L02
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFA02890D08
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L36:
       call      M00_L38
       jmp       near ptr M00_L28
M00_L37:
       mov       r11,7FFA02890D20
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
       mov       r11,7FFA02890D20
       call      qword ptr [r11]
M00_L39:
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
       call      qword ptr [7FFA0314F2D0]
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
       call      qword ptr [7FFA0314F2B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CB7B40]
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
       call      qword ptr [7FFA03145890]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA031C5CB0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1B5DD400AD8
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
       call      qword ptr [7FFA0316D680]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA028C10C0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA0316D680]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA028C10C8
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
       mov       rdx,1B5DD400AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B5DD400AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFA02B97A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFA02C18C90
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA031F4C30]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFA031FE838]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFA028C10B8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFA028C10D0
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
       mov       r11,7FFA028C10D0
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
       call      qword ptr [7FFA031FE928]
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
       call      qword ptr [7FFA031FE910]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CE7B40]
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
       call      qword ptr [7FFA0316D650]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA031F55F0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,129A7C00AD8
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
       call      qword ptr [7FFA0315D560]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA028B10C0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA0315D560]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA028B10C8
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
       mov       rdx,129A7C00AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,129A7C00AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFA02B87A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFA02C08C90
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA031E4BD0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFA031EE850]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFA028B10B8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFA028B10D0
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
       mov       r11,7FFA028B10D0
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
       call      qword ptr [7FFA031EE940]
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
       call      qword ptr [7FFA031EE928]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CD7B40]
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
       call      qword ptr [7FFA0315D530]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA031E5590]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,2C9B8C00AE0
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
       call      qword ptr [7FFA031559C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA028A0D10
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA031559C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA028A0D18
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
       mov       rdx,2C9B8C00AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02956BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C9B8C00AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFA02B77A08]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFA02BF8C90
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA0315F120]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFA0315F0C0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFA028A0D08
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFA028A0D20
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
       mov       r11,7FFA028A0D20
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
       call      qword ptr [7FFA0315F1B0]
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
       call      qword ptr [7FFA0315F198]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CC7B40]
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
       call      qword ptr [7FFA0315F0C0]
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
       call      qword ptr [7FFA031D5CC8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,22F39802AD8
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
       mov       rdx,7FFA02C08C90
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA0316F3C0]
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
       call      qword ptr [7FFA031659C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA028B0F60
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA031659C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L36
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFA028B0F68
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
M00_L30:
       mov       ebx,1
       jmp       short M00_L29
M00_L31:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22F39802AD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02966BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22F39802AD8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L32:
       xor       ebx,ebx
       jmp       short M00_L29
M00_L33:
       call      qword ptr [7FFA02B87A08]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FFA0316F120]
       jmp       near ptr M00_L02
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFA028B0F58
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L36:
       call      M00_L38
       jmp       near ptr M00_L28
M00_L37:
       mov       r11,7FFA028B0F70
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
       mov       r11,7FFA028B0F70
       call      qword ptr [r11]
M00_L39:
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
       call      qword ptr [7FFA0316F4C8]
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
       call      qword ptr [7FFA0316F4B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CD7B40]
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
       call      qword ptr [7FFA03165998]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA0316F8D0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,119B1800AF0
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
       call      qword ptr [7FFA031D4300]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA02891248
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA031D4300]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA02891250
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
       call      qword ptr [7FFA02B67A08]
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
       mov       rdx,119B1800AE8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,119B1800AF0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA03087A80]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFA031DFCA8]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFA02891240
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFA02891258
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
       mov       r11,7FFA02891258
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
       call      qword ptr [7FFA031DFD98]
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
       call      qword ptr [7FFA031DFD80]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CB7B40]
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
       call      qword ptr [7FFA031D42D0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA031D52F0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1D748C02C48
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
       call      qword ptr [7FFA0321EEB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFA02891D20
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFA0321EEB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFA02891D28
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
       call      qword ptr [7FFA02B67A08]
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
       mov       rdx,1D748C02C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA02946BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D748C02C48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFA0302EB38]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFA03374C60]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFA02891D18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFA02891D30
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
       mov       r11,7FFA02891D30
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
       call      qword ptr [7FFA03374D80]
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
       call      qword ptr [7FFA03374D68]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CB7B40]
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
       call      qword ptr [7FFA0321EE80]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFA0302F978]
       int       3
; Total bytes of code 44
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,19945402010
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
       call      qword ptr [7FFA03145C80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA03145C80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,19945402010
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA0314FFD8]
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
       call      qword ptr [7FFA03145980]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA03145920]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02EC6CD0]
       mov       ecx,65
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0302CA20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0302CA38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA031550A8
       call      qword ptr [7FFA031459C8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03099518]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA0314FD98]
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
       mov       rcx,7FFA031A2718
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA03145C80]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA03145C80]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA031A271C
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
       mov       rax,[rax+0A0]
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
       call      qword ptr [7FFA02D376F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       call      qword ptr [7FFA02B6C228]
       int       3
M02_L15:
       mov       rcx,rdx
       mov       rdx,7FFA031B08D8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L16:
       mov       rcx,rax
       mov       rdx,7FFA031B0EF8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L17:
       mov       rcx,rdx
       mov       rdx,7FFA031B13A8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L18:
       mov       rdx,7FFA031B19C0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L19:
       mov       rcx,rdi
       mov       rdx,7FFA031B1A10
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L20:
       mov       rcx,rdi
       mov       rdx,7FFA031B1A28
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L21:
       mov       rcx,rdi
       mov       rdx,7FFA031B1A30
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L22:
       mov       rdx,7FFA031B21C8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FFA02890D78
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
       mov       rdx,7FFA031B2390
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L24
M02_L31:
       mov       rcx,r14
       mov       rdx,7FFA031B2428
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M02_L25
M02_L32:
       mov       ecx,10
       call      qword ptr [7FFA0314FBE8]
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
       mov       r11,7FFA02890D78
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
       mov       rdx,7FFA031B13B8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA03145BA8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA03145C80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA03145C80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA031B1400
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L40
M02_L46:
       mov       rdx,7FFA031B0E38
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA03145BD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA03145BD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFA0312D120
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L48
M02_L51:
       mov       ecx,885
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
       int       3
M02_L52:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L53:
       mov       rcx,rax
       mov       r11,7FFA02890D60
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
       mov       rdx,7FFA031B1548
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B1690
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B15C8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B1678
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B19D0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L12
M02_L68:
       mov       ecx,80B
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFA0314F8D0]
       int       3
M02_L69:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFA0314FDF8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA02CB5CF8]
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
       mov       rdx,7FFA031B19D0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B19E0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L75:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L76:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02890D68
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
       mov       rdx,7FFA031B19F8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L76
M02_L80:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02890D70
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
       mov       rdx,7FFA031B13A8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L84:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA02F6CED0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02EC6BE0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0314FBD0]
       int       3
M02_L89:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EC5F98]
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
       call      qword ptr [7FFA02E5CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA0314FC00]
       jmp       near ptr M02_L39
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
       int       3
M02_L93:
       call      qword ptr [7FFA0302D158]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L49
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA0314FCA8]
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
       mov       r11,7FFA02890D70
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
       call      qword ptr [7FFA03145C50]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA031B0928
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA031B0E28
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA0314FFD8]
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
       call      qword ptr [7FFA03145980]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA03145920]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0314F648]
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
       mov       rdx,7FFA031B08D8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA031B0EF8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA031459C8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA030999A0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA0314FD98]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D9DA490008
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
       call      qword ptr [7FFA031C44E0]
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
       mov       r11,7FFA02890D80
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
       mov       rdx,7FFA031B1548
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B1690
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B15C8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA031B1678
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1F6C6C00AD0
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
       call      qword ptr [7FFA030CD890]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA030CD890]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1F6C6C00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA031DF180]
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
       call      qword ptr [7FFA030CD590]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA030CD530]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02EDE9B8]
       mov       ecx,65
       mov       rdx,7FFA02D499F8
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D499F8
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030C4930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030C4948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA031A88E0
       call      qword ptr [7FFA030CD5D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03136F88]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA031DF048]
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
       mov       rcx,7FFA03292940
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA030CD890]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA030CD890]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA03292944
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
       call      qword ptr [7FFA02D476F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA028A0FB0
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
       mov       rdx,7FFA03282C48
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA03283268
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA03283718
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA03280CE0
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA03280D20
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA0318D850
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA03280D38
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FFA03284040
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FFA0325E648
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFA0325E6E0
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA028A0FB0
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
       mov       rdx,7FFA03283728
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA030CD7B8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA030CD7E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA030CD7E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFA030CD890]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA030CD890]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA03283770
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L46:
       mov       rdx,7FFA032831A8
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rdi
       mov       rdx,7FFA0325FB30
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L42
M02_L49:
       mov       ecx,885
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FFA028A0F98
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
       mov       rdx,7FFA032838B8
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03283A00
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03283938
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032839E8
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03222B88
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02BF8C90
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031D4E10]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA031DF0A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CC5CF8]
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
       mov       rdx,7FFA03222B88
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA03280CF0
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FFA028A0FA0
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
       mov       rdx,7FFA03280D08
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02ACE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FFA028A0FA8
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
       mov       rdx,7FFA03283718
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA03054E40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02EDE8C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B7C228]
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
       call      qword ptr [7FFA031DEAA8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02ED5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA031DEAD8]
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
       call      qword ptr [7FFA02E6CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA031DEEB0]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
       int       3
M02_L93:
       call      qword ptr [7FFA030C5068]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L41
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA031DEF58]
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
       mov       r11,7FFA028A0FA8
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
       call      qword ptr [7FFA030CD860]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA03282C98
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA03283198
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA031DF180]
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
       call      qword ptr [7FFA030CD590]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA030CD530]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02F6B1B0
       call      qword ptr [7FFA02B77798]
       mov       rcx,rax
       call      qword ptr [7FFA031DEBE0]
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
       mov       rdx,7FFA03282C48
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA03283268
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA030CD5D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03137350]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA031DF048]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23745C10008
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
       call      qword ptr [7FFA031D75B8]
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
       mov       r11,7FFA028A0FB8
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
       mov       rdx,7FFA032838B8
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03283A00
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03283938
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032839E8
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,20C60800AD0
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
       call      qword ptr [7FFA0313D818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,20C60800AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA031CF1E0]
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
       call      qword ptr [7FFA0313D518]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0313D4B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02ECEA00]
       mov       ecx,65
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03134978]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03134990]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA03198490
       call      qword ptr [7FFA0313D560]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA031171C8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA031CF030]
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
       mov       rcx,7FFA0328A158
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D818]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D818]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA0328A15C
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
       call      qword ptr [7FFA02D376F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA02890FA0
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
       mov       rdx,7FFA03271838
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA03272190
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA03272640
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA03272C58
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA03272C98
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA0317D200
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA03272CB0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FFA032733F8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FFA0324E828
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFA0324E8C0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA02890FA0
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
       mov       rdx,7FFA03272650
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA0313D740]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0313D770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA0313D770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFA0313D818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA03272698
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L46:
       mov       rdx,7FFA032720D0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rdi
       mov       rdx,7FFA03270258
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L48:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L42
M02_L49:
       mov       ecx,885
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FFA02890F88
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
       mov       rdx,7FFA032727E0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272928
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272860
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272910
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03212B68
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031C4EA0]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA031CF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CB5CF8]
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
       mov       rdx,7FFA03212B68
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272C68
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02890F90
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
       mov       rdx,7FFA03272C80
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02890F98
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
       mov       rdx,7FFA03272640
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA03044E88]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02ECE910]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
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
       call      qword ptr [7FFA031CEB38]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EC5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA031CEB68]
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
       call      qword ptr [7FFA02E5CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA031CF108]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
       int       3
M02_L93:
       call      qword ptr [7FFA031350B0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L41
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA031CF180]
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
       mov       r11,7FFA02890F98
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
       call      qword ptr [7FFA0313D7E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA03271888
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA03271D88
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA031CF1E0]
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
       call      qword ptr [7FFA0313D518]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0313D4B8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CECB8]
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
       mov       rdx,7FFA03271838
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA03272190
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA0313D560]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03117650]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA031CF030]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24CDF720008
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
       call      qword ptr [7FFA031C7648]
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
       mov       r11,7FFA02890FA8
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
       mov       rdx,7FFA032727E0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272928
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272860
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272910
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,272B3000AD0
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
       call      qword ptr [7FFA0316D8C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D8C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,272B3000AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA031FF1B0]
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
       call      qword ptr [7FFA0316D5C0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0316D560]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02EFEA00]
       mov       ecx,65
       mov       rdx,7FFA02D699F8
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D699F8
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03164930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03164948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA031C88E0
       call      qword ptr [7FFA0316D608]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03147048]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA031FF000]
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
       mov       rcx,7FFA032BA140
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D8C0]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D8C0]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA032BA144
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
       call      qword ptr [7FFA02D676F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA028C0FA0
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
       mov       rdx,7FFA032A1790
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA032A20E8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA032A2598
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA032A2BB0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA032A2BF0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA031AD200
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA032A2C08
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L28:
       mov       rdx,7FFA032A3350
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L29:
       mov       rcx,r14
       mov       rdx,7FFA0327E7F0
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L30:
       mov       rcx,r14
       mov       rdx,7FFA0327E888
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA028C0FA0
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
       mov       rdx,7FFA032A25A8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA0316D7E8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0316D8C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D8C0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA032A25F0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L38
M02_L44:
       mov       rdx,7FFA032A2028
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA0316D818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA0316D818]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFA032A0BC8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L46
M02_L49:
       mov       ecx,885
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
       int       3
M02_L50:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L51:
       mov       rcx,rax
       mov       r11,7FFA028C0F88
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
       mov       rdx,7FFA032A2738
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A2880
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A27B8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A2868
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03242BB8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02C18C90
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031F4E58]
       int       3
M02_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA031FF060]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CE5CF8]
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
       mov       rdx,7FFA03242BB8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A2BC0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L73:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L74:
       mov       rcx,[rbp-58]
       mov       r11,7FFA028C0F90
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
       mov       rdx,7FFA032A2BD8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02AEE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L74
M02_L78:
       mov       rcx,[rbp-58]
       mov       r11,7FFA028C0F98
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
       mov       rdx,7FFA032A2598
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L82:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA03074E88]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02EFE910]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B9C228]
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
       call      qword ptr [7FFA031FEB08]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EF5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA031FEB38]
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
       call      qword ptr [7FFA02E8CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA031FF0D8]
       jmp       near ptr M02_L37
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
       int       3
M02_L93:
       call      qword ptr [7FFA03165068]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L47
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA031FF150]
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
       mov       r11,7FFA028C0F98
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
       call      qword ptr [7FFA0316D890]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA032A17E0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA032A1CE0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA031FF1B0]
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
       call      qword ptr [7FFA0316D5C0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0316D560]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FEE80]
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
       mov       rdx,7FFA032A1790
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA032A20E8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA0316D608]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA031474D0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA031FF000]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B331FD0008
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
       call      qword ptr [7FFA031F7600]
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
       mov       r11,7FFA028C0FA8
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
       mov       rdx,7FFA032A2738
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A2880
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A27B8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A2868
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1E3FCC00AD0
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
       call      qword ptr [7FFA0316D908]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D908]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,1E3FCC00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA031FF1E0]
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
       call      qword ptr [7FFA0316D608]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0316D5A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02EFEA00]
       mov       ecx,65
       mov       rdx,7FFA02D699F8
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D699F8
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03164978]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03164990]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA031C88E0
       call      qword ptr [7FFA0316D650]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03146FB8]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA031FF018]
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
       mov       rcx,7FFA032B7B18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D908]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D908]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA032B7B1C
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
       call      qword ptr [7FFA02D676F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA028C0FA0
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
       mov       rdx,7FFA032A0ED0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA032A1828
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA032A1CD8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA032A22F0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA032A2330
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA031AD780
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA032A2348
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA03074E88]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02EFE910]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFA032A2A90
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFA0327FCE8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFA0327FD80
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA028C0FA0
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
       mov       rdx,7FFA032A1CE8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA0316D830]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0316D860]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA0316D860]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFA0316D908]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D908]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA032A1D30
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FFA032A1768
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFA0327F910
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFA028C0F88
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
       mov       rdx,7FFA032A1E78
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A1FC0
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A1EF8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A1FA8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03242C40
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02C18C90
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031F4EA0]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA031FF078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CE5CF8]
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
       mov       rdx,7FFA03242C40
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A2300
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFA028C0F90
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
       mov       rdx,7FFA032A2318
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02AEE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFA028C0F98
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFA032A1CD8
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B9C228]
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
       call      qword ptr [7FFA031FEE50]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EF5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA031FEE80]
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
       call      qword ptr [7FFA02E8CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA031FF0F0]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
       int       3
M02_L93:
       call      qword ptr [7FFA031650B0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA031FF168]
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
       mov       r11,7FFA028C0F98
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
       call      qword ptr [7FFA0316D8D8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA032A0F20
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA032A1420
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA031FF1E0]
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
       call      qword ptr [7FFA0316D608]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0316D5A8]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02F8B758
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA031FED60]
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
       mov       rdx,7FFA032A0ED0
       call      qword ptr [7FFA0297C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA032A1828
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA0316D650]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03147670]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA031FF018]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2247BDC0008
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
       call      qword ptr [7FFA031F76C0]
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
       mov       r11,7FFA028C0FA8
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
       mov       rdx,7FFA032A1E78
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A1FC0
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A1EF8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032A1FA8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,18099C00AD0
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
       call      qword ptr [7FFA0313D7D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D7D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,18099C00AD0
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA031CF1B0]
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
       call      qword ptr [7FFA0313D4D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0313D470]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02ECEA00]
       mov       ecx,65
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03134930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03134948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA031988D0
       call      qword ptr [7FFA0313D518]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03117048]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA031CEFE8]
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
       mov       rcx,7FFA032888E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D7D0]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D7D0]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA032888EC
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
       call      qword ptr [7FFA02D376F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA02890FA0
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
       mov       rdx,7FFA03271098
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA032719F0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA03271EA0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA032724B8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA032724F8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA0317D248
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA03272510
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA03044E88]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02ECE910]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFA03272C58
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFA0324E948
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFA0324E9E0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFA02890FA0
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
       mov       rdx,7FFA03271EB0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA0313D6F8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0313D7D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D7D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA03271EF8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L47:
       mov       rdx,7FFA03271930
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA0313D728]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA0313D728]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFA032704C8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L49
M02_L52:
       mov       ecx,885
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFA02890F88
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
       mov       rdx,7FFA03272040
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272188
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032720C0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272170
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03212BA0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031C4E58]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA031CF048]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CB5CF8]
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
       mov       rdx,7FFA03212BA0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA032724C8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02890F90
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
       mov       rdx,7FFA032724E0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02890F98
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFA03271EA0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
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
       call      qword ptr [7FFA031CEB08]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EC5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA031CEB38]
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
       call      qword ptr [7FFA02E5CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA031CF0C0]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
       int       3
M02_L93:
       call      qword ptr [7FFA03135068]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L50
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA031CF138]
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
       mov       r11,7FFA02890F98
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
       call      qword ptr [7FFA0313D7A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA032710E8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA032715E8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA031CF1B0]
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
       call      qword ptr [7FFA0313D4D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0313D470]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA031CEE68]
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
       mov       rdx,7FFA03271098
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA032719F0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA0313D518]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA031174D0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA031CEFE8]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C118D60008
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
       call      qword ptr [7FFA031C7678]
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
       mov       r11,7FFA02890FA8
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
       mov       rdx,7FFA03272040
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272188
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA032720C0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFA03272170
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,21EA6402B20
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
       call      qword ptr [7FFA031E56E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA031E56E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,21EA6402B20
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA03344D50]
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
       call      qword ptr [7FFA031E53E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA031E5380]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02ECEA00]
       mov       ecx,65
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0304EB20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0304EB38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA031FAC60
       call      qword ptr [7FFA031E5428]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA032BEF48]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA03344C18]
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
       mov       rcx,7FFA03362560
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA031E56E0]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA031E56E0]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA03362564
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
       call      qword ptr [7FFA02D376F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA02891498
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
       mov       rdx,7FFA03357938
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA03357F58
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA03358408
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA03320B50
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA03320B90
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA03036950
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA03320BA8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA03046658]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02ECE910]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFA03358D30
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFA033555F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFA03355688
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
       mov       r11,7FFA02891498
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
       mov       rdx,7FFA03358418
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA031E5608]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA031E5638]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA031E5638]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFA031E56E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA031E56E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA03358460
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FFA03357E98
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFA033549D8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L43
M02_L51:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M02_L45
M02_L52:
       mov       ecx,885
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFA02891480
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
       mov       rdx,7FFA033585A8
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
       mov       rdx,7FFA033586F0
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
       mov       rdx,7FFA03358628
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
       mov       rdx,7FFA033586D8
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
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M02_L67
       jmp       short M02_L68
M02_L67:
       mov       rdx,7FFA031A29F8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA0304F0F0]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA03344C78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CB5CF8]
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
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M02_L73
       jmp       short M02_L74
M02_L73:
       mov       rdx,7FFA031A29F8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA03320B60
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02891488
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
       mov       rdx,7FFA03320B78
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02891490
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFA03358408
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
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
       call      qword ptr [7FFA033449D8]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EC5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA03344318]
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
       call      qword ptr [7FFA02E5CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA031EF8E8]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
       int       3
M02_L93:
       call      qword ptr [7FFA031477E0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA03344B28]
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
       mov       r11,7FFA02891490
       call      qword ptr [r11]
M02_L102:
       nop
       add       rsp,28
       ret
; Total bytes of code 3279
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
       call      qword ptr [7FFA031E56B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA03357988
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA03357E88
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA03344D50]
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
       call      qword ptr [7FFA031E53E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA031E5380]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02F5B758
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03344870]
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
       mov       rdx,7FFA03357938
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L19:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M03_L20
       mov       rcx,rax
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFA03357F58
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA031E5428]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA032BFA90]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA03344C18]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25F3B540008
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
       call      qword ptr [7FFA031E7C60]
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
       mov       r11,7FFA028914A0
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
       mov       rdx,7FFA033585A8
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
       mov       rdx,7FFA033586F0
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
       mov       rdx,7FFA03358628
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
       mov       rdx,7FFA033586D8
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,221A6400C48
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
       call      qword ptr [7FFA0321F000]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0321F000]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,221A6400C48
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FFA033755C0]
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
       call      qword ptr [7FFA0321ED00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0321ECA0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M00_L08
M00_L10:
       mov       rax,rcx
       jmp       short M00_L08
M00_L11:
       mov       rax,rdi
       jmp       short M00_L08
M00_L12:
       call      qword ptr [7FFA02EC6CD0]
       mov       ecx,65
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D399F8
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0302F738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0302F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,873
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
       int       3
M00_L14:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,7FFA03332C30
       call      qword ptr [7FFA0321ED48]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA03289028]
       mov       rcx,[rdi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M00_L07
M00_L15:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA03375410]
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
       mov       rcx,7FFA033A1528
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0321F000]
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0321F000]
       mov       byte ptr [rbx+24],1
M01_L01:
       mov       rcx,7FFA033A152C
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
       mov       rax,[rdx+0B8]
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
       mov       r11,[rdx+0D0]
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
       mov       r11,[rdx+0D8]
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
       call      qword ptr [7FFA02D376F8]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1<System.__Canon>)
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
       mov       r11,7FFA02891C60
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
       mov       rdx,7FFA033887F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFA033890E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L23:
       mov       rcx,rdx
       mov       rdx,7FFA03389598
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L24:
       mov       rdx,7FFA032BB370
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L25:
       mov       rdx,7FFA032BB3B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L26:
       mov       rdx,7FFA02FEE6A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,7FFA032BB3C8
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
       call      qword ptr [7FFA030263D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02EC6BE0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L13
M02_L31:
       mov       rdx,7FFA03389EC0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M02_L14
M02_L32:
       mov       rcx,r14
       mov       rdx,7FFA03387760
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L15
M02_L33:
       mov       rcx,r14
       mov       rdx,7FFA033877F8
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
       mov       r11,7FFA02891C60
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
       mov       rdx,7FFA033895A8
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
       call      qword ptr [7FFA0321EF28]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0321EF58]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rsi+1]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA0321EF58]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFA0321F000]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0321F000]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFA033895F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L41
M02_L49:
       mov       rdx,7FFA03389020
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L42
M02_L50:
       mov       rcx,rdi
       mov       rdx,7FFA03386E58
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
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
       int       3
M02_L53:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L54:
       mov       rcx,rax
       mov       r11,7FFA02891C48
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
       mov       rdx,7FFA03389738
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
       mov       rdx,7FFA03389880
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
       mov       rdx,7FFA033897B8
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
       mov       rdx,7FFA03389868
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
       mov       rdx,7FFA02FEEEE8
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
       mov       rdx,7FFA02BE8C90
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA0302E748]
       int       3
M02_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA03375470]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA02CB5CF8]
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
       mov       rdx,7FFA02FEEEE8
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
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M02_L75
       jmp       short M02_L76
M02_L75:
       mov       rdx,7FFA032BB380
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L76:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M02_L77:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02891C50
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        short M02_L78
       jmp       short M02_L79
M02_L78:
       mov       rdx,7FFA032BB398
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
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L77
M02_L81:
       mov       rcx,[rbp-58]
       mov       r11,7FFA02891C58
       call      qword ptr [r11]
       jmp       near ptr M02_L12
M02_L82:
       mov       rcx,rdx
       mov       rdx,7FFA03389598
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L30
M02_L83:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
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
       call      qword ptr [7FFA03375260]
       int       3
M02_L88:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EC5F98]
       int       3
M02_L89:
       mov       ecx,10
       call      qword ptr [7FFA0302F990]
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
       call      qword ptr [7FFA02E5CF00]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L91:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FFA03374510]
       jmp       near ptr M02_L40
M02_L92:
       mov       ecx,40B
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
       int       3
M02_L93:
       call      qword ptr [7FFA031657D0]
       int       3
M02_L94:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L44
M02_L95:
       mov       ecx,847
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
       int       3
M02_L96:
       mov       ecx,851
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
       int       3
M02_L97:
       mov       ecx,873
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
       int       3
M02_L98:
       mov       rcx,rdx
       call      qword ptr [7FFA03375548]
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
       mov       r11,7FFA02891C58
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
       call      qword ptr [7FFA0321EFD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M03_L03:
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
M03_L04:
       jmp       short M03_L09
M03_L05:
       mov       rdx,7FFA03388848
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M03_L01
M03_L06:
       mov       rdx,7FFA03388D48
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L02
M03_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA033755C0]
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
       call      qword ptr [7FFA0321ED00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFA0321ECA0]
       jmp       short M03_L12
M03_L14:
       mov       rax,rcx
       jmp       short M03_L12
M03_L15:
       mov       rax,rsi
       jmp       short M03_L12
M03_L16:
       mov       ecx,4D7
       mov       rdx,7FFA02EFC0B8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA03375170]
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
       mov       rdx,7FFA033887F8
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
       mov       rdx,7FFA033890E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFA0321ED48]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.IEnumerable, Int32 ByRef)
       test      eax,eax
       je        short M03_L22
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFA032893F0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M03_L11
M03_L22:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA03375410]
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,262252F0008
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
       call      qword ptr [7FFA0316FE58]
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
       mov       r11,7FFA02891C68
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
       mov       rdx,7FFA03389738
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
       mov       rdx,7FFA03389880
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
       mov       rdx,7FFA033897B8
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
       mov       rdx,7FFA03389868
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

