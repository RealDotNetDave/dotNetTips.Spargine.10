## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,127B4C00A00
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
       call      qword ptr [7FFB842452A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839C0E08
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB842452A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFB839C0E10
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
       mov       rdx,127B4C009F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,127B4C00A00
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFB83A7F570]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C27D98
       call      qword ptr [7FFB83A7F300]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8424C7B0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8424E328]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839C0E00
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFB839C0E18
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
       mov       r11,7FFB839C0E18
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
       call      qword ptr [7FFB8424E460]
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
       call      qword ptr [7FFB8424E448]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83DF7D20]
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
       call      qword ptr [7FFB84245278]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB84247060]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,19F83C00A10
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
       call      qword ptr [7FFB842653B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839E0DE0
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB842653B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFB839E0DE8
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
       mov       rdx,19F83C00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A96BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19F83C00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFB83A9F498]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C37D98
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8426C408]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8426E3A0]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839E0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFB839E0DF0
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
       mov       r11,7FFB839E0DF0
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
       call      qword ptr [7FFB8426E4D8]
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
       call      qword ptr [7FFB8426E4C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83E07C78]
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
       call      qword ptr [7FFB84265380]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB8426CA50]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,22BD1800A10
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
       call      qword ptr [7FFB84265440]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839E0DE0
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB84265440]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFB839E0DE8
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
       mov       rdx,22BD1800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A96BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22BD1800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFB83A9F498]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C37D98
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8426C3C0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8426E388]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839E0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFB839E0DF0
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
       mov       r11,7FFB839E0DF0
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
       call      qword ptr [7FFB8426E4C0]
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
       call      qword ptr [7FFB8426E4A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83E07C48]
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
       call      qword ptr [7FFB84265410]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB8426CA20]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1D325800A10
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
       call      qword ptr [7FFB842553B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839D0DE0
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB842553B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFB839D0DE8
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
       mov       rdx,1D325800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A86BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D325800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFB83A8F498]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C27D98
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8425C408]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8425E3A0]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839D0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFB839D0DF0
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
       mov       r11,7FFB839D0DF0
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
       call      qword ptr [7FFB8425E4D8]
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
       call      qword ptr [7FFB8425E4C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83DF7C78]
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
       call      qword ptr [7FFB84255380]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB8425CA50]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,20B09C00A10
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
       call      qword ptr [7FFB84265488]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839E0DE8
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB84265488]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFB839E0DF0
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
       mov       rdx,20B09C00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A96BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20B09C00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFB83A9F498]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C37D98
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8426C408]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8426E3A0]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839E0DE0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFB839E0DF8
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
       mov       r11,7FFB839E0DF8
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
       call      qword ptr [7FFB8426E4D8]
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
       call      qword ptr [7FFB8426E4C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83E07C78]
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
       call      qword ptr [7FFB8426E3A0]
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
       call      qword ptr [7FFB8426CA50]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1F70F400A10
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
       call      qword ptr [7FFB84214ED0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839C0DE8
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L16:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB84214ED0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L18
       mov       rcx,rax
       mov       r11,7FFB839C0DF0
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
       mov       rdx,1F70F400A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F70F400A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C17D98
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8421C3F0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8421E3A0]
       jmp       near ptr M00_L07
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L03
M00_L36:
       mov       r11,7FFB839C0DF8
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
       mov       r11,7FFB839C0DF8
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
       call      qword ptr [7FFB8421E4D8]
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
       call      qword ptr [7FFB8421E4C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83DE7C78]
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
       call      qword ptr [7FFB84214EA0]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB8421CA38]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1FFADC00A10
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
       call      qword ptr [7FFB83A8F498]
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
       call      qword ptr [7FFB84246AA8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839D0F90
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB84246AA8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFB839D0F98
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
       mov       rdx,1FFADC00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A86BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FFADC00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       short M00_L28
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C27D98
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB8424C408]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8424F0F0]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839D0F88
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFB839D0FA0
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
       mov       r11,7FFB839D0FA0
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
       call      qword ptr [7FFB8424F210]
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
       call      qword ptr [7FFB8424F1F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83DF7C78]
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
       call      qword ptr [7FFB84246A78]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB8424CA50]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,29716000AB8
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
       call      qword ptr [7FFB83A7F498]
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
       call      qword ptr [7FFB8428D950]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFB839C1250
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB8428D950]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L15
       mov       rcx,rax
       mov       r11,7FFB839C1258
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
       mov       rdx,29716000AB0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29716000AB8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       short M00_L28
M00_L32:
       mov       ecx,783
       mov       rdx,7FFB83C17D98
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB841450F8]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFB8428F510]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839C1248
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFB839C1260
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
       mov       r11,7FFB839C1260
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
       call      qword ptr [7FFB8428F630]
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
       call      qword ptr [7FFB8428F618]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83DE7C78]
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
       call      qword ptr [7FFB8428D920]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFB841457D0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839C0CB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB84303110],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,2DC13C00A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839C0CB8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,2DC13C00A08
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB841CCF98]
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
       call      qword ptr [7FFB8424EFE8]
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
       call      qword ptr [7FFB84245758]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F000]
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
       call      qword ptr [7FFB8424EC88]
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
       call      qword ptr [7FFB84245758]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8424EFD0]
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
       mov       r11,7FFB839C0CC0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8424EC88]
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
       call      qword ptr [7FFB8424F018]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F030]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424EFE8]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F048]
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
       call      qword ptr [7FFB84245770]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84245560]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84275DE8
       cmp       [rcx],ecx
       call      qword ptr [7FFB842457D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB8400F528]
       mov       ecx,65
       mov       rdx,7FFB83E6D8F8
       call      qword ptr [7FFB83A7F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D454F0
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E6D8F8
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8424C228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8424C240]
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
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
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
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
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
       call      qword ptr [7FFB842457B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842457B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8424ECA0]
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0C0]
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
       jmp       short M04_L17
M04_L16:
       inc       edi
M04_L17:
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
       je        short M04_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFB839C0CD8
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
       mov       rcx,rdx
       mov       rdx,7FFB842DE880
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFB84281998
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFB842DEBC0
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFB842DE8C0
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFB842DF230
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB842DF250
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFB842DF3B0
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFB842DB080
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB842DB118
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839C0CD8
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
       mov       rdx,7FFB842DE8E0
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB842456B0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFB842457B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842457B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB842DE9C8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L37
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFB842DE9E8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB84245710]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB84245710]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFB842DCBB0
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB84006AC0]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842D86D8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A771E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8424F0D8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB8425F888]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839C0CC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB842DEBE8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839C0CD0
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
       call      qword ptr [7FFB83A771E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8424EE08]
       int       3
M04_L67:
       call      qword ptr [7FFB83C4F228]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB8400EF10]
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E7D638]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A7FD50]
       int       3
M04_L72:
       test      r8,r8
       je        near ptr M04_L16
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
       call      qword ptr [7FFB8424E7D8]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB84006AC0]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8424E808]
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
       call      qword ptr [7FFB83F8DAD0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8424EE80]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M04_L81:
       call      qword ptr [7FFB8415C198]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L46
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424E9A0]
       int       3
M04_L86:
       call      qword ptr [7FFB8424ECA0]
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
       mov       r11,7FFB839C0CD0
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,31C92C60008
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
       call      qword ptr [7FFB8424E190]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839D0CA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB84311D18],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,24C6FC00A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839D0CB0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,24C6FC00A08
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB841DCBF8]
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
       call      qword ptr [7FFB8425EFD0]
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
       call      qword ptr [7FFB84255728]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425EFE8]
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
       call      qword ptr [7FFB8425EC70]
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
       call      qword ptr [7FFB84255728]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8425EFB8]
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
       mov       r11,7FFB839D0CB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8425EC70]
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
       call      qword ptr [7FFB8425F000]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425F018]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425EFD0]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425F030]
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
       call      qword ptr [7FFB84255740]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84255530]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84285DE8
       cmp       [rcx],ecx
       call      qword ptr [7FFB842557A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB8401F510]
       mov       ecx,65
       mov       rdx,7FFB83E7D8F8
       call      qword ptr [7FFB83A8F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D54FE0
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E7D8F8
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8425C1E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8425C1F8]
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
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
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
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
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
       call      qword ptr [7FFB84255788]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84255788]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8425EC88]
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0C0]
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
       jmp       short M04_L17
M04_L16:
       inc       edi
M04_L17:
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
       je        short M04_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFB839D0CD0
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
       mov       rcx,rdx
       mov       rdx,7FFB842EE878
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFB842917B0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFB842EEBB8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFB842EE8B8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFB842EF228
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB842EF248
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFB842EF3A8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFB842EB078
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB842EB110
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839D0CD0
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
       mov       rdx,7FFB842EE8D8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        short M04_L39
M04_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFB84255680]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M04_L40
M04_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       short M04_L41
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L44
M04_L39:
       mov       rcx,rdx
       mov       rdx,7FFB842EE9C0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M04_L37
M04_L40:
       mov       rcx,rdx
       mov       rdx,7FFB842EE9E0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M04_L38
M04_L41:
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
       call      qword ptr [7FFB842556E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB842556E0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L47
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
       call      qword ptr [7FFB84255788]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84255788]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,rsi
       mov       rdx,7FFB842ECBA8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L42
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
       call      qword ptr [7FFB84016A90]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842E8678
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A871E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8425F0C0]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB8426F878]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839D0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB842EEBE0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839D0CC8
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
       call      qword ptr [7FFB83A871E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8425EDF0]
       int       3
M04_L67:
       call      qword ptr [7FFB83C5F228]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB8401EEE0]
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E8D608]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A8FD50]
       int       3
M04_L72:
       test      r8,r8
       jne       near ptr M04_L18
       jmp       near ptr M04_L16
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
       call      qword ptr [7FFB8425E7C0]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB84016A90]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8425E7F0]
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
       call      qword ptr [7FFB83F9DAA0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8425EE68]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M04_L81:
       call      qword ptr [7FFB8416C180]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L43
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8426B6C8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E988]
       int       3
M04_L86:
       call      qword ptr [7FFB8425EC88]
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
       mov       r11,7FFB839D0CC8
       call      qword ptr [r11]
M04_L90:
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28CEEA50008
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
       call      qword ptr [7FFB8425E178]
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839B0CA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB842F31D0],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1FD8A800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839B0CB0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1FD8A800A08
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB841BD258]
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
       call      qword ptr [7FFB8423EFB8]
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
       call      qword ptr [7FFB84235710]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8423EFD0]
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
       call      qword ptr [7FFB8423EC40]
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
       call      qword ptr [7FFB84235710]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8423EFA0]
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
       mov       r11,7FFB839B0CB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8423EC40]
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
       call      qword ptr [7FFB8423EFE8]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8423F000]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8423EFB8]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8423F018]
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
       call      qword ptr [7FFB84235728]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84235518]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84265DE8
       cmp       [rcx],ecx
       call      qword ptr [7FFB84235788]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB83FFF528]
       mov       ecx,65
       mov       rdx,7FFB83E5D8F8
       call      qword ptr [7FFB83A6F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D354F0
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E5D8F8
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8423C1F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8423C210]
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
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
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
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
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
       call      qword ptr [7FFB84235770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84235770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8423EC58]
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0C0]
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
       jmp       short M04_L17
M04_L16:
       inc       edi
M04_L17:
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
       je        short M04_L18
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFB839B0CD0
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
       mov       rcx,rdx
       mov       rdx,7FFB842CE740
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFB84271F08
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFB842CEA80
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFB842CE780
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFB842CF0F0
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB842CF110
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFB842CF270
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFB842CB188
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB842CB220
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839B0CD0
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
       mov       rdx,7FFB842CE7A0
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        short M04_L39
M04_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFB84235668]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M04_L40
M04_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       short M04_L41
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L44
M04_L39:
       mov       rcx,rdx
       mov       rdx,7FFB842CE888
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M04_L37
M04_L40:
       mov       rcx,rdx
       mov       rdx,7FFB842CE8A8
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M04_L38
M04_L41:
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
       call      qword ptr [7FFB842356C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB842356C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L47
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
       call      qword ptr [7FFB84235770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84235770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rcx,rsi
       mov       rdx,7FFB842CCA78
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L42
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
       call      qword ptr [7FFB83FF6AC0]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842C8670
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8423F0A8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB8424F878]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839B0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB842CEAA8
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839B0CC8
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
       call      qword ptr [7FFB83A671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8423EDC0]
       int       3
M04_L67:
       call      qword ptr [7FFB83C3F2A0]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83FFEF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E6D638]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A6FD50]
       int       3
M04_L72:
       test      r8,r8
       je        near ptr M04_L16
       jmp       near ptr M04_L18
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
       call      qword ptr [7FFB8423E7A8]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB83FF6AC0]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8423E7D8]
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
       call      qword ptr [7FFB83F7DAD0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8423EE38]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M04_L81:
       call      qword ptr [7FFB8414C1B0]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L43
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8424B6C8
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8423E958]
       int       3
M04_L86:
       call      qword ptr [7FFB8423EC58]
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
       mov       r11,7FFB839B0CC8
       call      qword ptr [r11]
M04_L90:
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23E098A0008
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
       call      qword ptr [7FFB8423E160]
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
       jmp       qword ptr [7FFB83A65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839B0CA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB842F3228],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1F22A800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839B0CB0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1F22A800A08
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB8419C478]
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
       call      qword ptr [7FFB8420F048]
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
       call      qword ptr [7FFB84205230]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8420F060]
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
       call      qword ptr [7FFB8420EC40]
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
       call      qword ptr [7FFB84205230]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8420F030]
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
       mov       r11,7FFB839B0CB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8420EC40]
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
       call      qword ptr [7FFB8420F078]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8420F090]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8420F048]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8420F0A8]
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
       call      qword ptr [7FFB84205248]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84205038]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84245530
       cmp       [rcx],ecx
       call      qword ptr [7FFB842052A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB83FFF000]
       mov       ecx,65
       mov       rdx,7FFB83E5D8F8
       call      qword ptr [7FFB83A6F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D34FE0
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E5D8F8
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8420C600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8420C618]
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
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
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
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
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
       call      qword ptr [7FFB84205290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84205290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8420EC58]
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0C0]
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
       mov       r11,7FFB839B0CD0
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
       mov       rdx,7FFB842E15D0
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L20:
       mov       rdx,7FFB84265938
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L21:
       mov       rdx,7FFB842E1910
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L22:
       mov       rcx,rdx
       mov       rdx,7FFB842E1610
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L23:
       mov       rcx,rdi
       mov       rdx,7FFB842E1F80
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB842E1FA0
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L25
M04_L27:
       mov       rcx,r14
       mov       rdx,7FFB842E2100
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,rdi
       mov       rdx,7FFB842AFAC0
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB842AFB58
       call      qword ptr [7FFB83A6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839B0CD0
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
       mov       rdx,7FFB842E1630
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB84205188]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFB84205290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84205290]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB842E1718
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L37
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFB842E1738
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB842051E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB842051E8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFB842AF2E0
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83FF6A90]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842ABA60
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8420F138]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB8421F0E8]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839B0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB842E1938
       call      qword ptr [7FFB83A6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839B0CC8
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
       call      qword ptr [7FFB83A671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8420EDC0]
       int       3
M04_L67:
       call      qword ptr [7FFB83C3F228]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83FFEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E6D608]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A6FD50]
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
       call      qword ptr [7FFB8420EB08]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB83FF6A90]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8420EB38]
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
       call      qword ptr [7FFB83F7DAA0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8420EE38]
       jmp       near ptr M04_L36
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M04_L81:
       call      qword ptr [7FFB84127C60]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L46
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8421AF38
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8420E9A0]
       int       3
M04_L86:
       call      qword ptr [7FFB8420EC58]
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
       mov       r11,7FFB839B0CC8
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,232A96A0008
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
       call      qword ptr [7FFB8420E160]
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
       jmp       qword ptr [7FFB83A65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839D0CA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB84313110],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1AFCB800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839D0CB0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1AFCB800A08
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB841DCF18]
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
       call      qword ptr [7FFB8425F078]
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
       call      qword ptr [7FFB84255758]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425F090]
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
       call      qword ptr [7FFB8425EC70]
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
       call      qword ptr [7FFB84255758]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8425F060]
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
       mov       r11,7FFB839D0CB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8425EC70]
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
       call      qword ptr [7FFB8425F0A8]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425F0C0]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425F078]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8425F0D8]
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
       call      qword ptr [7FFB84255770]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84255560]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84285DE8
       cmp       [rcx],ecx
       call      qword ptr [7FFB842557D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB8401F528]
       mov       ecx,65
       mov       rdx,7FFB83E7D8F8
       call      qword ptr [7FFB83A8F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D55110
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E7D8F8
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8425C228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8425C240]
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
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
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
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
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
       call      qword ptr [7FFB842557B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842557B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8425EC88]
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
       mov       r14,[rax+60]
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       mov       rdi,[rax+68]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0C0]
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
       mov       r11,7FFB839D0CD0
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
       mov       rdx,7FFB842EE0A0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L21:
       mov       rdx,7FFB842A19A0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L22:
       mov       rdx,7FFB842EE3E0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L23:
       mov       rcx,rdx
       mov       rdx,7FFB842EE0E0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L24:
       mov       rcx,rdi
       mov       rdx,7FFB842EEA50
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB842EEA70
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L26
M04_L28:
       mov       rcx,r14
       mov       rdx,7FFB842EEBD0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB842EC7F8
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFB842EC890
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839D0CD0
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
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L31
       mov       rcx,rdx
       mov       rdx,7FFB842EE100
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L43
M04_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFB842556B0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L44
M04_L39:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       near ptr M04_L45
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M04_L40:
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
       jne       short M04_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842557B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842557B8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M04_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L42:
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
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFB842EE1E8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L38
M04_L44:
       mov       rcx,rdx
       mov       rdx,7FFB842EE208
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L39
M04_L45:
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
       call      qword ptr [7FFB84255710]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB84255710]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L48
M04_L46:
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
M04_L47:
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
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rsi
       mov       rdx,7FFB842EC018
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L46
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB84016AC0]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842E86F8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A871E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8425F168]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB8426F888]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839D0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB842EE408
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839D0CC8
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
       call      qword ptr [7FFB83A871E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8425EDF0]
       int       3
M04_L67:
       call      qword ptr [7FFB83C5F228]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB8401EF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E8D638]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A8FD50]
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
       call      qword ptr [7FFB8425EB38]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB84016AC0]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8425EB68]
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
       call      qword ptr [7FFB83F9DAD0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8425EE68]
       jmp       near ptr M04_L37
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M04_L81:
       call      qword ptr [7FFB8416C180]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L47
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8426B6D8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8425E9D0]
       int       3
M04_L86:
       call      qword ptr [7FFB8425EC88]
       mov       rbx,rax
       jmp       near ptr M04_L42
M04_L87:
       mov       rbx,rcx
       jmp       near ptr M04_L42
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
       mov       r11,7FFB839D0CC8
       call      qword ptr [r11]
M04_L90:
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F04AAE0008
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
       call      qword ptr [7FFB8425E190]
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839C0CA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB84312318],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1FD07802A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839C0CB0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1FD07802A00
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB841CCD18]
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
       call      qword ptr [7FFB8424F048]
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
       call      qword ptr [7FFB84245770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F060]
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
       call      qword ptr [7FFB8424ECD0]
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
       call      qword ptr [7FFB84245770]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8424F030]
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
       mov       r11,7FFB839C0CB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8424ECD0]
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
       call      qword ptr [7FFB8424F078]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F090]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F048]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424F0A8]
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
       call      qword ptr [7FFB84245788]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84245578]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84275DE8
       cmp       [rcx],ecx
       call      qword ptr [7FFB842457E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB8400F540]
       mov       ecx,65
       mov       rdx,7FFB83E6D8F8
       call      qword ptr [7FFB83A7F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D44FE0
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E6D8F8
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8424C1E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8424C1F8]
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
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
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
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M02_L01:
       mov       ecx,851
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
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
       call      qword ptr [7FFB842457D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842457D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8424ECE8]
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
       mov       r14,[rax+60]
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
       mov       rax,[rdx+88]
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
       mov       rax,[rdx+98]
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
       mov       rdi,[rax+68]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0C0]
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
       mov       r11,7FFB839C0CD0
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
       mov       rdx,7FFB842DE0C8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L21:
       mov       rdx,7FFB8426F6C8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L22:
       mov       rdx,7FFB842DE408
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L23:
       mov       rcx,rdx
       mov       rdx,7FFB842DE108
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L24:
       mov       rcx,rdi
       mov       rdx,7FFB842DEA78
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB842DEA98
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L26
M04_L28:
       mov       rcx,r14
       mov       rdx,7FFB842DEBF8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB842DC820
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFB842DC8B8
       call      qword ptr [7FFB83A7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839C0CD0
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
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L31
       mov       rcx,rdx
       mov       rdx,7FFB842DE128
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L45
M04_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFB842456C8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
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
       call      qword ptr [7FFB84245728]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB84245728]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFB842457D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB842457D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB842DE210
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L38
M04_L46:
       mov       rcx,rdx
       mov       rdx,7FFB842DE230
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L39
M04_L47:
       mov       rcx,rsi
       mov       rdx,7FFB842DBE00
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB84006A90]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842D85E8
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A771E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8424F138]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB8425F888]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839C0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0A8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB842DE430
       call      qword ptr [7FFB83A7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839C0CC8
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
       call      qword ptr [7FFB83A771E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8424EE50]
       int       3
M04_L67:
       call      qword ptr [7FFB83C4F228]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB8400F378]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E7D608]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A7FD50]
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
       call      qword ptr [7FFB8424EB98]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB84006A90]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8424EBC8]
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
       call      qword ptr [7FFB83F8DAA0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8424EEC8]
       jmp       near ptr M04_L37
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M04_L81:
       call      qword ptr [7FFB8415C198]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L41
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8425B6D8
       call      qword ptr [7FFB83A7F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424EA00]
       int       3
M04_L86:
       call      qword ptr [7FFB8424ECE8]
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
       mov       r11,7FFB839C0CC8
       call      qword ptr [r11]
M04_L90:
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23D9C880008
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
       call      qword ptr [7FFB8424E1F0]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839D0FD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB84335EA0],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,24F15000AF8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839D0FE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,24F15000A08
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB841FEE98]
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
       call      qword ptr [7FFB8424FDE0]
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
       call      qword ptr [7FFB842471C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424FDF8]
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
       call      qword ptr [7FFB8424FAB0]
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
       call      qword ptr [7FFB842471C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB8424FDC8]
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
       mov       r11,7FFB839D0FE8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8424FAB0]
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
       call      qword ptr [7FFB8424FE10]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424FE28]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424FDE0]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB8424FE40]
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
       call      qword ptr [7FFB842471E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB84246FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB84298820
       cmp       [rcx],ecx
       call      qword ptr [7FFB84247240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB8401F528]
       mov       ecx,65
       mov       rdx,7FFB83E7D8F8
       call      qword ptr [7FFB83A8F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D554F0
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E7D8F8
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84247A80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84247A98]
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
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
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
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M02_L01:
       mov       ecx,847
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
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
       call      qword ptr [7FFB84247228]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84247228]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8424FA08]
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
       mov       rax,[rdx+70]
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
       mov       rax,[rdx+0A8]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0D0]
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
       mov       r11,7FFB839D1000
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
       mov       rdx,7FFB84319C58
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L21:
       mov       rdx,7FFB841776E8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L22:
       mov       rdx,7FFB84319EE0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L23:
       mov       rcx,rdx
       mov       rdx,7FFB84319C98
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L24:
       mov       rcx,rdi
       mov       rdx,7FFB8431A550
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FFB8431A570
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L26
M04_L28:
       mov       rcx,r14
       mov       rdx,7FFB8431A6D0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB843171F0
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFB84317288
       call      qword ptr [7FFB83A8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFB839D1000
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
       mov       rdx,7FFB84319CB8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M04_L43
M04_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFB84247120]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M04_L44
M04_L39:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       near ptr M04_L45
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M04_L40:
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
       jne       short M04_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84247228]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB84247228]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M04_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L42:
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
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFB84319D00
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L38
M04_L44:
       mov       rcx,rdx
       mov       rdx,7FFB84319D20
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L39
M04_L45:
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
       call      qword ptr [7FFB84247180]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB84247180]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L48
M04_L46:
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
M04_L47:
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
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rsi
       mov       rdx,7FFB843160F0
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L46
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB84016AC0]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB842B92D8
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A871E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8424FED0]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB842923E0]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839D0FF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB84319F08
       call      qword ptr [7FFB83A8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839D0FF8
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
       call      qword ptr [7FFB83A871E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8424FC00]
       int       3
M04_L67:
       call      qword ptr [7FFB83C5F240]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB8401EF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E8D638]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A8FD50]
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
       call      qword ptr [7FFB8424F8B8]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB84016AC0]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB8424D5A8]
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
       call      qword ptr [7FFB83F9DAD0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8424F2B8]
       jmp       near ptr M04_L37
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M04_L81:
       call      qword ptr [7FFB8415DD40]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L47
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB8427E1B8
       call      qword ptr [7FFB83A8F228]
       mov       rcx,rax
       call      qword ptr [7FFB8424F708]
       int       3
M04_L86:
       call      qword ptr [7FFB8424FA08]
       mov       rbx,rax
       jmp       near ptr M04_L42
M04_L87:
       mov       rbx,rcx
       jmp       near ptr M04_L42
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
       mov       r11,7FFB839D0FF8
       call      qword ptr [r11]
M04_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2813
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28F93ED0008
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
       call      qword ptr [7FFB8424E970]
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFB839B1050
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB843B4D40],1
       je        near ptr M00_L50
M00_L00:
       mov       rdx,1B7BA400B00
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB839B1058
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L51
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       r8,1B7BA400AB0
       mov       rbp,[r8]
       mov       r14,[rbp+8]
       cmp       qword ptr [r14+10],0
       je        near ptr M00_L46
       mov       r8d,[r14+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFB84331278]
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
       call      qword ptr [7FFB843C4180]
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
       call      qword ptr [7FFB8428DC20]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
M00_L07:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB843C4198]
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
       call      qword ptr [7FFB8428FDB0]
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
       call      qword ptr [7FFB8428DC20]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
       mov       r13,[rsp+30]
M00_L25:
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB843C4168]
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
       mov       r11,7FFB839B1060
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L16
       mov       r10,[rsp+50]
       mov       rcx,[r10+18]
       lea       r9,[rsp+70]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB8428FDB0]
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
       call      qword ptr [7FFB843C41B0]
       test      eax,eax
       je        short M00_L42
       mov       rdx,[r12+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB843C41C8]
       test      eax,eax
       jg        short M00_L41
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB843C4180]
       mov       r14,rax
       jmp       near ptr M00_L34
M00_L41:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableSortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB843C41E0]
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
       call      qword ptr [7FFB8428DC38]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(Node<System.__Canon>)
       jmp       short M00_L47
M00_L46:
       mov       [rsp+58],rsi
       mov       [rsp+60],edi
       lea       rdx,[rsp+58]
       mov       rcx,rbp
       call      qword ptr [7FFB8428DA28]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
M00_L47:
       mov       [rsp+68],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FFB842DCCC0
       cmp       [rcx],ecx
       call      qword ptr [7FFB8428DC98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB83FFF528]
       mov       ecx,65
       mov       rdx,7FFB83E5D8F8
       call      qword ptr [7FFB83A6F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D354F0
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E5D8F8
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84134BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84134BD0]
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
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M00_L53:
       mov       ecx,847
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M00_L54:
       mov       ecx,851
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M00_L55:
       mov       ecx,869
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
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
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M02_L01:
       mov       ecx,847
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
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
       call      qword ptr [7FFB8428DC80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8428DC80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M03_L02:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB8428FDC8]
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
       mov       r14,[rax+60]
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
       mov       rax,[rdx+50]
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
       mov       rax,[rdx+0A8]
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
       mov       rdi,[rax+68]
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
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
       mov       rdi,[rdx+0D0]
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
       mov       r11,7FFB839B1078
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
       mov       rdx,7FFB843A2388
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L21:
       mov       rdx,7FFB84117078
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L22:
       mov       rdx,7FFB843A26C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L23:
       mov       rcx,rdx
       mov       rdx,7FFB843A23C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L06
M04_L24:
       mov       rcx,rdi
       mov       rdx,7FFB843A2D38
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
       mov       rdx,7FFB843A2D58
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M04_L26
M04_L28:
       mov       rcx,r14
       mov       rdx,7FFB843A2EB8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L29:
       mov       rcx,rdi
       mov       rdx,7FFB843A0B68
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M04_L13
M04_L30:
       mov       rcx,rdi
       mov       rdx,7FFB843A0C00
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
       mov       r11,7FFB839B1078
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
       mov       r11,[rax+70]
       test      r11,r11
       jne       near ptr M04_L31
       mov       rcx,rdx
       mov       rdx,7FFB843A23E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rax,[rax+78]
       test      rax,rax
       je        near ptr M04_L43
M04_L38:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFB8428DB78]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M04_L44
M04_L39:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M04_L80
       test      edi,edi
       jne       near ptr M04_L45
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M04_L40:
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
       jne       short M04_L41
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8428DC80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8428DC80]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r14+24],1
M04_L41:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L42:
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
M04_L43:
       mov       rcx,rdx
       mov       rdx,7FFB843A24D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M04_L38
M04_L44:
       mov       rcx,rdx
       mov       rdx,7FFB843A24F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L39
M04_L45:
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
       call      qword ptr [7FFB8428DBD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB8428DBD8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M04_L48
M04_L46:
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
M04_L47:
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
       jmp       near ptr M04_L40
M04_L48:
       mov       rcx,rsi
       mov       rdx,7FFB8430D680
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L46
M04_L49:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB83FF6AC0]
       int       3
M04_L50:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M04_L51
       jmp       short M04_L52
M04_L51:
       mov       rdx,7FFB84166288
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M04_L56:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB843C4270]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M04_L05
M04_L57:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB842D6880]
       mov       [rbp-58],rax
M04_L58:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839B1068
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L62
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rcx,r14
       mov       rdx,7FFB843A26F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M04_L58
M04_L62:
       mov       rcx,[rbp-58]
       mov       r11,7FFB839B1070
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
       call      qword ptr [7FFB83A671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M04_L07
M04_L66:
       call      qword ptr [7FFB8428FF30]
       int       3
M04_L67:
       call      qword ptr [7FFB83C3F228]
       int       3
M04_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L10
M04_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83FFEF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L10
M04_L70:
       call      qword ptr [7FFB83E6D638]
       int       3
M04_L71:
       mov       ecx,2
       call      qword ptr [7FFB83A6FD50]
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
       call      qword ptr [7FFB8428FC90]
       int       3
M04_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFB83FF6AC0]
       int       3
M04_L77:
       mov       ecx,10
       call      qword ptr [7FFB84136328]
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
       call      qword ptr [7FFB83F7DAD0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M04_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFB8428EEF8]
       jmp       near ptr M04_L37
M04_L80:
       mov       ecx,40B
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M04_L81:
       call      qword ptr [7FFB84135218]
       int       3
M04_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M04_L47
M04_L83:
       mov       ecx,847
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M04_L84:
       mov       ecx,851
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M04_L85:
       mov       ecx,873
       mov       rdx,7FFB842D26D0
       call      qword ptr [7FFB83A6F228]
       mov       rcx,rax
       call      qword ptr [7FFB8428F390]
       int       3
M04_L86:
       call      qword ptr [7FFB8428FDC8]
       mov       rbx,rax
       jmp       near ptr M04_L42
M04_L87:
       mov       rbx,rcx
       jmp       near ptr M04_L42
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
       mov       r11,7FFB839B1070
       call      qword ptr [r11]
M04_L90:
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F839550008
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
       call      qword ptr [7FFB8428E5B0]
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
       jmp       qword ptr [7FFB83A65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

