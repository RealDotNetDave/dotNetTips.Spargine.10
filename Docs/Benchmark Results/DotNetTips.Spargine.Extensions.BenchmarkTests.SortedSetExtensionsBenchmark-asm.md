## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,25D44C00A40
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
       call      qword ptr [7FFAE0F46598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE06B0DF8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F46598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE06B0E00
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
       mov       rax,[rcx+88]
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
       mov       rdx,25D44C00A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0766BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25D44C00A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFAE076F558]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE0917720
       call      qword ptr [7FFAE076F2E8]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0F4D548]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE0F4EFA0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE06B0DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFAE06B0E08
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
       mov       r11,7FFAE06B0E08
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
       call      qword ptr [7FFAE0F4F0D8]
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
       call      qword ptr [7FFAE0F4F0C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AD7DF8]
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
       call      qword ptr [7FFAE0F46568]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0D2F060]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,1A97C000A50
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
       call      qword ptr [7FFAE0F66478]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE06C0DD8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F66478]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE06C0DE0
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
       mov       rax,[rcx+88]
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
       mov       rdx,1A97C000A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0776BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A97C000A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFAE077F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE0917720
       call      qword ptr [7FFAE077F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0F6D530]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE0F6F450]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE06C0DD0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFAE06C0DE8
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
       mov       r11,7FFAE06C0DE8
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
       call      qword ptr [7FFAE0F6F588]
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
       call      qword ptr [7FFAE0F6F570]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AF7D20]
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
       call      qword ptr [7FFAE0F66448]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0F6DB90]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,1E557C00A50
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
       call      qword ptr [7FFAE0F36148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE06A0DD8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F36148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE06A0DE0
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
       mov       rax,[rcx+88]
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
       mov       rdx,1E557C00A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0756BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E557C00A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFAE075F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE08F7720
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0F3D500]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE0F3F420]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE06A0DD0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFAE06A0DE8
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
       mov       r11,7FFAE06A0DE8
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
       call      qword ptr [7FFAE0F3F558]
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
       call      qword ptr [7FFAE0F3F540]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AD7D20]
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
       call      qword ptr [7FFAE0F36118]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0F3DB60]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,163BEC00A50
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
       call      qword ptr [7FFAE0F36580]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE0690DE8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F36580]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE0690DF0
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
       mov       rax,[rcx+88]
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
       mov       rdx,163BEC00A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0746BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,163BEC00A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFAE074F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0F3D518]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE0F3F408]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE0690DE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFAE0690DF8
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
       mov       r11,7FFAE0690DF8
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
       call      qword ptr [7FFAE0F3F570]
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
       call      qword ptr [7FFAE0F3F558]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AC7D20]
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
       call      qword ptr [7FFAE0F36550]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0F3DB78]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,1C7F6400A50
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
       call      qword ptr [7FFAE0F36598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE0690DE0
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F36598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE0690DE8
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
       mov       rax,[rcx+88]
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
       mov       rdx,1C7F6400A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0746BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C7F6400A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFAE074F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0F3D518]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE0F3F450]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE0690DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFAE0690DF0
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
       mov       r11,7FFAE0690DF0
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
       call      qword ptr [7FFAE0F3F588]
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
       call      qword ptr [7FFAE0F3F570]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AC7D20]
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
       call      qword ptr [7FFAE0F3F450]
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
       call      qword ptr [7FFAE0F3DB78]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,2A96F800A50
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
       call      qword ptr [7FFAE0F36598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE0690DE8
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F36598]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE0690DF0
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
       mov       rax,[rcx+88]
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
       mov       rdx,2A96F800A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0746BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A96F800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L31:
       call      qword ptr [7FFAE074F480]
       int       3
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0F3D530]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE0F3F408]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE0690DE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L27
M00_L36:
       mov       r11,7FFAE0690DF8
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
       mov       r11,7FFAE0690DF8
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
       call      qword ptr [7FFAE0F3F540]
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
       call      qword ptr [7FFAE0F3F528]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AC7D20]
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
       call      qword ptr [7FFAE0F36568]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0F3DB90]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,1D4E4000A50
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
       call      qword ptr [7FFAE0F5C528]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE06B0F90
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F5C528]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE06B0F98
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFAE076F480]
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
       mov       rdx,1D4E4000A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0766BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D4E4000A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE0907720
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0E6E508]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE10240D8]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE06B0F88
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFAE06B0FA0
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
       mov       r11,7FFAE06B0FA0
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
       call      qword ptr [7FFAE10241F8]
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
       call      qword ptr [7FFAE10241E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AE7D20]
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
       call      qword ptr [7FFAE0F5C4F8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0F5DB90]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
       mov       rax,14CF2800AF8
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
       call      qword ptr [7FFAE0F6E958]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFAE0691218
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L11:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFAE0F6E958]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L13
       mov       rcx,rax
       mov       r11,7FFAE0691220
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFAE074F480]
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
       mov       rdx,14CF2800AF0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark+<>c.<IsNotEmptyWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFAE0746BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,14CF2800AF8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L31:
       xor       ebx,ebx
       jmp       near ptr M00_L22
M00_L32:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFAE0E460A0]
       int       3
M00_L33:
       mov       rcx,r13
       call      qword ptr [7FFAE10944E0]
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFAE0691210
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L35:
       call      M00_L37
       jmp       near ptr M00_L28
M00_L36:
       mov       r11,7FFAE0691228
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
       mov       r11,7FFAE0691228
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
       call      qword ptr [7FFAE1094600]
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
       call      qword ptr [7FFAE10945E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0AC7D20]
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
       call      qword ptr [7FFAE0F6E928]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].Push(System.__Canon)
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
       call      qword ptr [7FFAE0E46790]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetExtensionsBenchmark.IsNotEmpty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
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
       mov       rcx,[rbx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,2AA63800A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0EDFC18]
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
       call      qword ptr [7FFAE1034078]
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
       mov       r11,7FFAE06B0CB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F5FD08]
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
       call      qword ptr [7FFAE0F5FD08]
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
       call      qword ptr [7FFAE0F56748]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F56778]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F56550]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0F7DE68
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F567C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0D1F348]
       mov       ecx,65
       mov       rdx,7FFAE0B7EC00
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7EC00
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F5D098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F5D0B0]
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
       mov       r11,7FFAE06B0CA8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE0907720
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F5D848]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE0F5FC90]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AE5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE0907720
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F5D848]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE0F5F990]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE0F5F990]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F5F9F0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE06B0CB0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2AA63800AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F5FD20]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       call      qword ptr [7FFAE0F5C6A8]
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
       jmp       qword ptr [7FFAE0936EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
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
       call      qword ptr [7FFAE0F567A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F567A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE06B0CD0
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
       mov       rdx,7FFAE0FEEA00
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFAE0FA12B0
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFAE0FEED40
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFAE0FEEA40
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFAE0FEF3C0
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFAE0FEF3E0
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFAE0FEF540
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFAE0FEB050
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE0FEB0E8
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE06B0CD0
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
       mov       rdx,7FFAE0FEEA60
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0F566A0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFAE0F56700]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F56700]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFAE0F567A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F567A8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0FEEB48
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFAE0FEEB68
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FFAE0FECCA0
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0D16898]
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
       mov       rdx,7FFAE0FE8758
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1034108]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0F77A28]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06B0CC0
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
       mov       rdx,7FFAE0FEED68
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06B0CC8
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
       call      qword ptr [7FFAE07671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE0F5FE88]
       int       3
M05_L67:
       call      qword ptr [7FFAE093F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0D1ECE8]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B8D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE076FD38]
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
       call      qword ptr [7FFAE0F5F858]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0D16898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE0F5F888]
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
       call      qword ptr [7FFAE0C9D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F5FF00]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E6D398]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F73878
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F5FA20]
       int       3
M05_L86:
       call      qword ptr [7FFAE0F5FD20]
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
       mov       r11,7FFAE06B0CC8
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EAE27D0008
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
       call      qword ptr [7FFAE0F5F228]
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
       jmp       qword ptr [7FFAE0765C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,1D186C00A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0EBFC78]
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
       call      qword ptr [7FFAE1014090]
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
       mov       r11,7FFAE0690CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F3FD20]
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
       call      qword ptr [7FFAE0F3FD20]
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
       call      qword ptr [7FFAE0F36838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F36868]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F36640]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0F5E380
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0CFF360]
       mov       ecx,65
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A14CA0
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3D200]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3D218]
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
       mov       r11,7FFAE0690CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D860]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE0F3FCA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AC5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D860]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE0F3F9A8]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE0F3F9A8]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FA08]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE0690CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D186C00AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FD38]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       call      qword ptr [7FFAE0F3C6C0]
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
       jmp       qword ptr [7FFAE0916EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
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
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE0690CD0
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
       mov       rdx,7FFAE0FCEA38
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFAE0F841D0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFAE0FCED78
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCEA78
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCF3F8
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCF418
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFAE0FCF578
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCB1A8
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCB240
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE0690CD0
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
       mov       rdx,7FFAE0FCEA98
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0F36790]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFAE0F367F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F367F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0FCEB80
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCEBA0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FFAE0FCCD70
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0CF6898]
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
       mov       rdx,7FFAE0FC8738
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1014120]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0F57F40]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CC0
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
       mov       rdx,7FFAE0FCEDA0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CC8
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE0F3FEA0]
       int       3
M05_L67:
       call      qword ptr [7FFAE091F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0CFECE8]
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B6D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE074FD38]
       int       3
M05_L72:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
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
       call      qword ptr [7FFAE0F3F870]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0CF6898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE0F3F8A0]
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
       call      qword ptr [7FFAE0C7D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F3FF18]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E4D3B0]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA38]
       int       3
M05_L86:
       call      qword ptr [7FFAE0F3FD38]
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
       mov       r11,7FFAE0690CC8
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21205BA0008
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
       call      qword ptr [7FFAE0F3F240]
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
       jmp       qword ptr [7FFAE0745C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,1AE3E000A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0ED05D8]
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
       call      qword ptr [7FFAE1024090]
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
       mov       r11,7FFAE06A0CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F4FDE0]
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
       call      qword ptr [7FFAE0F4FDE0]
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
       call      qword ptr [7FFAE0F46838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F46868]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F46640]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0F6E390
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F468B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0D0F348]
       mov       ecx,65
       mov       rdx,7FFAE0B6EC00
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6EC00
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4D1E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4D200]
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
       mov       r11,7FFAE06A0CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE08F7720
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F4D848]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE0F4FD80]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AD5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE08F7720
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F4D848]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE0F4FA08]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE0F4FA08]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F4FA68]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE06A0CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AE3E000AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F4FD38]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       call      qword ptr [7FFAE0F4C6A8]
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
       jmp       qword ptr [7FFAE0926EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
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
       call      qword ptr [7FFAE0F46898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F46898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE06A0CC8
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
       mov       rdx,7FFAE0FDF998
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFAE0F91328
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFAE0FDFC20
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFAE0FDF9D8
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFAE10102D8
       call      qword ptr [7FFAE075F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFAE10102F8
       call      qword ptr [7FFAE075F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFAE1010458
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFAE0FDB2B8
       call      qword ptr [7FFAE075F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE0FDB350
       call      qword ptr [7FFAE075F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE06A0CC8
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
       mov       rdx,7FFAE0FDF9F8
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0F46790]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFAE0F46898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F46898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0FDFA40
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L42:
       mov       rcx,rdx
       mov       rdx,7FFAE0FDFA60
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0F467F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F467F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       mov       rdx,7FFAE0FDC6E8
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0D06898]
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
       mov       rdx,7FFAE0FD8730
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07571E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1024120]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0F67F50]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06A0CB8
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
       mov       rdx,7FFAE0FDFC48
       call      qword ptr [7FFAE075F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07571C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06A0CC0
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
       call      qword ptr [7FFAE07571E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE0F4FF30]
       int       3
M05_L67:
       call      qword ptr [7FFAE092F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0D0ECE8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B7D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE075FD38]
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
       call      qword ptr [7FFAE0F4F858]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0D06898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE0F4F888]
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
       call      qword ptr [7FFAE0C8D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F4FC90]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E5D398]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L45
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F63DA0
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F4F990]
       int       3
M05_L86:
       call      qword ptr [7FFAE0F4FD38]
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
       mov       r11,7FFAE06A0CC0
       call      qword ptr [r11]
M05_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 2817
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EEBCE80008
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
       call      qword ptr [7FFAE0F4F228]
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
       jmp       qword ptr [7FFAE0755C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,1D771800A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0EC00B8]
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
       call      qword ptr [7FFAE10140C0]
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
       mov       r11,7FFAE0690CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F3FD38]
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
       call      qword ptr [7FFAE0F3FD38]
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
       call      qword ptr [7FFAE0F36850]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F36880]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F36658]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0F5E4E8
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0CFF348]
       mov       ecx,65
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A14CA0
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3D0C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3D0E0]
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
       mov       r11,7FFAE0690CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D878]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE0F3FCC0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AC5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D878]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE0F3F9C0]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE0F3F9C0]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FA20]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE0690CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D771800AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FD50]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       call      qword ptr [7FFAE0F3C720]
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
       jmp       qword ptr [7FFAE0916EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
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
       call      qword ptr [7FFAE0F368B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE0690CC8
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
       mov       rdx,7FFAE0FCE9E8
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L21:
       mov       rdx,7FFAE0F811C8
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L22:
       mov       rdx,7FFAE0FCED28
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L23:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCEA28
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L24:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCF3A8
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L25:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCF3C8
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,r14
       mov       rdx,7FFAE0FCF528
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L27:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCB348
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCB3E0
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE0690CC8
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
       mov       rdx,7FFAE0FCEA48
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0F367A8]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFAE0F36808]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F36808]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFAE0F368B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368B0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0FCEB30
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L36
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCEB50
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rsi
       mov       rdx,7FFAE0FCD648
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE0CF6898]
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
       mov       rdx,7FFAE0FC8738
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1014150]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0F580A8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CB8
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
       mov       rdx,7FFAE0FCED50
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CC0
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE0F3FEB8]
       int       3
M05_L67:
       call      qword ptr [7FFAE091F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0CFF180]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B6D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE074FD38]
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
       call      qword ptr [7FFAE0F3F8A0]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0CF6898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE0F3F8D0]
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
       call      qword ptr [7FFAE0C7D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F3FF30]
       jmp       near ptr M05_L35
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E4D380]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L39
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F53EF8
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FC48]
       int       3
M05_L86:
       call      qword ptr [7FFAE0F3FD50]
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
       mov       r11,7FFAE0690CC0
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,217F0750008
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
       call      qword ptr [7FFAE0F3F258]
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
       jmp       qword ptr [7FFAE0745C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,25119C00A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0EBFCF8]
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
       call      qword ptr [7FFAE1014138]
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
       mov       r11,7FFAE0690CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F3FD20]
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
       call      qword ptr [7FFAE0F3FD20]
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
       call      qword ptr [7FFAE0F36838]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F36868]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F36640]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0F5E380
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0CFF348]
       mov       ecx,65
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A14CA0
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3D0C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3D0E0]
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
       mov       r11,7FFAE0690CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D878]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE0F3FCA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AC5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D878]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE0F3F798]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE0F3F798]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3F7F8]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE0690CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25119C00AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FD38]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       call      qword ptr [7FFAE0F3C6D8]
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
       jmp       qword ptr [7FFAE0916EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M03_L01:
       mov       ecx,851
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
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
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE0690CC8
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
       mov       rdx,7FFAE0FCE038
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFAE0F911D8
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFAE0FCE378
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCE078
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCE9F8
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCEA18
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFAE0FCEB78
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCC790
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCC828
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE0690CC8
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
       mov       rdx,7FFAE0FCE098
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L44
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFAE0F36790]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        near ptr M05_L45
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L47
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
       call      qword ptr [7FFAE0F367F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F367F0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L39:
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
M05_L40:
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
M05_L41:
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
       jne       short M05_L42
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L42:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L43:
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
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCE180
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCE1A0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFAE0FCBFC8
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L41
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFAE0CF6898]
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
       mov       rdx,7FFAE0FC8748
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE10141C8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0F57F40]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CB8
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
       mov       rdx,7FFAE0FCE3A0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CC0
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE0F3FEA0]
       int       3
M05_L67:
       call      qword ptr [7FFAE091F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0CFECE8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B6D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE074FD38]
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
       call      qword ptr [7FFAE0F3FBE8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0CF6898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE0F3FC18]
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
       call      qword ptr [7FFAE0C7D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F3FF18]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E4D398]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L40
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F53D90
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3FA80]
       int       3
M05_L86:
       call      qword ptr [7FFAE0F3FD38]
       mov       rsi,rax
       jmp       near ptr M05_L43
M05_L87:
       mov       rsi,rcx
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
       mov       r11,7FFAE0690CC0
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29198A20008
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
       call      qword ptr [7FFAE0F3F258]
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
       jmp       qword ptr [7FFAE0745C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,1ABC9000A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0EBFBB8]
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
       call      qword ptr [7FFAE10140C0]
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
       mov       r11,7FFAE0690CB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F3FE10]
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
       call      qword ptr [7FFAE0F3FE10]
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
       call      qword ptr [7FFAE0F36868]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F36898]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F36670]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0F5E4F8
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0CFF348]
       mov       ecx,65
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A14CA0
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B5EC00
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3D218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3D230]
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
       mov       r11,7FFAE0690CA0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D878]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE0F3FDB0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AC5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE08E7720
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F3D878]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE0F3FA50]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE0F3FA50]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FAB0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE0690CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ABC9000AD8
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE0F3FD68]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       call      qword ptr [7FFAE0F37F30]
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
       jmp       qword ptr [7FFAE0916EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
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
       call      qword ptr [7FFAE0F368C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE0690CC8
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
       mov       rdx,7FFAE0FCF390
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFAE0F6F6B8
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFAE0FCF618
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCF3D0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCFC98
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCFCB8
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFAE0FCFE18
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCC8A0
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFAE0FCC938
       call      qword ptr [7FFAE074F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE0690CC8
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
       mov       rdx,7FFAE0FCF3F0
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L44
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFAE0F367C0]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M05_L45
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L47
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
       call      qword ptr [7FFAE0F36820]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F36820]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L39:
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
M05_L40:
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
M05_L41:
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
       jne       short M05_L42
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F368C8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L42:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L43:
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
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCF438
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rdx
       mov       rdx,7FFAE0FCF458
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFAE0FCB9D8
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L41
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFAE0CF6898]
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
       mov       rdx,7FFAE0FC8720
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1014150]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0F580B8]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CB8
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
       mov       rdx,7FFAE0FCF640
       call      qword ptr [7FFAE074F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE0690CC0
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
       call      qword ptr [7FFAE07471E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE0F3FF60]
       int       3
M05_L67:
       call      qword ptr [7FFAE091F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0CFECE8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B6D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE074FD38]
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
       call      qword ptr [7FFAE0F3FBE8]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0CF6898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE0F3FC18]
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
       call      qword ptr [7FFAE0C7D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F3FCC0]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E4D380]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L40
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F53F08
       call      qword ptr [7FFAE074F210]
       mov       rcx,rax
       call      qword ptr [7FFAE0F3F9D8]
       int       3
M05_L86:
       call      qword ptr [7FFAE0F3FD68]
       mov       rsi,rax
       jmp       near ptr M05_L43
M05_L87:
       mov       rsi,rcx
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
       mov       r11,7FFAE0690CC0
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EC47FB0008
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
       call      qword ptr [7FFAE0F3F258]
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
       jmp       qword ptr [7FFAE0745C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,19236800A48
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE0F06918]
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
       call      qword ptr [7FFAE1034D68]
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
       mov       r11,7FFAE06B0EB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1034A50]
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
       call      qword ptr [7FFAE1034A50]
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
       call      qword ptr [7FFAE0F5C6D8]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F5C708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F5C4E0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE0FA86C0
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F5C750]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0D1F348]
       mov       ecx,65
       mov       rdx,7FFAE0B7EC00
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7EC00
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E6DD58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E6DD70]
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
       mov       r11,7FFAE06B0EA8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE0907720
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F5D0E0]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE10349F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AE5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE0907720
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0F5D0E0]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE1034708]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE1034708]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE1034738]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE06B0EB0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19236800B38
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE10349A8]
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
       jmp       near ptr 00007FFB403E3EE0
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
       call      qword ptr [7FFAE0E64B10]
       int       3
M02_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFAE0936EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
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
       call      qword ptr [7FFAE0F5C738]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F5C738]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
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
       mov       r11,7FFAE06B0ED0
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
       mov       rdx,7FFAE102C780
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFAE0E469F8
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFAE102CA08
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFAE102C7C0
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFAE102D088
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFAE102D0A8
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFAE102D208
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE1029D20
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFAE1029DB8
       call      qword ptr [7FFAE076F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFAE06B0ED0
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
       mov       rdx,7FFAE102C7E0
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M05_L44
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFAE0F5C630]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M05_L45
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L80
       test      edi,edi
       je        near ptr M05_L47
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
       call      qword ptr [7FFAE0F5C690]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F5C690]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L46
M05_L39:
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
M05_L40:
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
M05_L41:
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
       jne       short M05_L42
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F5C738]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F5C738]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rbx+24],1
M05_L42:
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M05_L43:
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
M05_L44:
       mov       rcx,rdx
       mov       rdx,7FFAE102C828
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L45:
       mov       rcx,rdx
       mov       rdx,7FFAE102C848
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M05_L38
M05_L46:
       mov       rcx,rsi
       mov       rdx,7FFAE1028AA0
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L39
M05_L47:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M05_L41
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFAE0D16898]
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
       mov       rdx,7FFAE0FBA738
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE1034DF8]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0FA2280]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06B0EC0
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
       mov       rdx,7FFAE102CA30
       call      qword ptr [7FFAE076F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFAE07671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06B0EC8
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
       call      qword ptr [7FFAE07671E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE1034BA0]
       int       3
M05_L67:
       call      qword ptr [7FFAE093F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0D1F180]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B8D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE076FD38]
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
       call      qword ptr [7FFAE1034840]
       int       3
M05_L76:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0D16898]
       int       3
M05_L77:
       mov       ecx,10
       call      qword ptr [7FFAE1034870]
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
       call      qword ptr [7FFAE0C9D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L79:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE10341B0]
       jmp       near ptr M05_L36
M05_L80:
       mov       ecx,40B
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M05_L81:
       call      qword ptr [7FFAE0E6F2E8]
       int       3
M05_L82:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L40
M05_L83:
       mov       ecx,847
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M05_L84:
       mov       ecx,851
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M05_L85:
       mov       ecx,873
       mov       rdx,7FFAE0F8E090
       call      qword ptr [7FFAE076F210]
       mov       rcx,rax
       call      qword ptr [7FFAE1034690]
       int       3
M05_L86:
       call      qword ptr [7FFAE10349A8]
       mov       rsi,rax
       jmp       near ptr M05_L43
M05_L87:
       mov       rsi,rcx
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
       mov       r11,7FFAE06B0EC8
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D2B5900008
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
       call      qword ptr [7FFAE0F5F888]
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
       jmp       qword ptr [7FFAE0765C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2D8]
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
       mov       r8,210AF000AF0
       mov       rbp,[r8]
       mov       r8,[rbp+8]
       cmp       qword ptr [r8+10],0
       je        near ptr M00_L31
       mov       r8,[rbp+8]
       mov       r8d,[r8+20]
       lea       ecx,[r8+rdi]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFAE1042CB8]
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
       call      qword ptr [7FFAE10B4FC0]
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
       mov       r11,7FFAE06A1058
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L20
       mov       r10,[rsp+40]
       mov       rcx,[r10+18]
       lea       r9,[rsp+60]
       mov       rdx,r13
       mov       r8,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFAE10B4CF0]
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
       call      qword ptr [7FFAE10B4CF0]
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
       call      qword ptr [7FFAE0F7E9D0]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, Node<System.__Canon>, Node<System.__Canon>, Boolean)
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
       call      qword ptr [7FFAE0F7EA00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
M00_L30:
       jmp       short M00_L32
M00_L31:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       lea       rdx,[rsp+48]
       mov       rcx,rbp
       call      qword ptr [7FFAE0F7E7D8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
       mov       rsi,rax
M00_L32:
       mov       [rsp+58],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+58]
       mov       rdx,7FFAE10007F8
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F7EA48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFAE0D0EE20]
       mov       ecx,65
       mov       rdx,7FFAE0B6EC00
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6EC00
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E47780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E47798]
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
       mov       r11,7FFAE06A1048
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,80B
       mov       rdx,7FFAE08F7720
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0E45AD0]
       int       3
M00_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAE10B4C90]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE0AD5ED8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,783
       mov       rdx,7FFAE08F7720
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFAE0E45AD0]
       int       3
M00_L39:
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFAE10B49C0]
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFAE10B49C0]
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,rbp
       call      qword ptr [7FFAE10B49F0]
       int       3
M00_L42:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFAE06A1050
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,210AF000B40
       mov       rdi,[rcx]
       jmp       near ptr M00_L06
M00_L44:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L45:
       mov       ecx,873
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M00_L46:
       mov       ecx,847
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M00_L47:
       mov       ecx,851
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M00_L48:
       mov       rcx,rbp
       call      qword ptr [7FFAE10B4C48]
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
       jmp       near ptr 00007FFB403E3EE0
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFAE0E44B28]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFAE0926EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M03_L01:
       mov       ecx,847
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
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
       call      qword ptr [7FFAE0F7EA30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F7EA30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M04_L02:
       mov       ecx,873
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
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
       call      00007FFB4036A2B0
       cmp       dword ptr [7FFB406A4A90],0
       jne       near ptr M05_L68
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
       jl        near ptr M05_L78
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
       mov       rdx,offset MT_System.Collections.Generic.GenericArraySortHelper<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M05_L72
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r8,rbx
       call      qword ptr [7FFAE09FD8E0]; System.Collections.Generic.GenericArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Span`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       jae       near ptr M05_L82
       mov       rax,[r15+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       edi,r11d
       jae       near ptr M05_L89
       mov       r10d,edi
       mov       r14,[r8+r10*8+10]
       lea       ebx,[rdi-1]
       cmp       ebx,edx
       jae       near ptr M05_L82
       cmp       ebx,r11d
       jae       near ptr M05_L89
       mov       edx,ebx
       mov       r8,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M05_L73
       test      r8,r8
       je        short M05_L19
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFAE06A1070
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L17
M05_L19:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L82
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L89
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L82
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
       mov       rdx,7FFAE10C5188
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L22:
       mov       rdx,7FFAE0E1A948
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L23:
       mov       rdx,7FFAE10C5410
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L04
M05_L24:
       mov       rcx,rdx
       mov       rdx,7FFAE10C51C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L25:
       mov       rcx,rdi
       mov       rdx,7FFAE10C5A90
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L08
M05_L26:
       mov       rcx,rdx
       mov       rdx,7FFAE10C5AB0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M05_L09
M05_L27:
       mov       rcx,r14
       mov       rdx,7FFAE10C5C10
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M05_L13
M05_L28:
       mov       rcx,rdi
       mov       rdx,7FFAE10C2728
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M05_L14
M05_L29:
       mov       rcx,rdi
       mov       rdx,7FFAE10C27C0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M05_L15
M05_L30:
       mov       rax,[r15+8]
       cmp       r13d,[rax+8]
       jae       near ptr M05_L89
       mov       edx,r13d
       mov       r8,[rax+rdx*8+10]
       mov       rdx,offset MT_System.Collections.Generic.GenericComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M05_L74
       test      r14,r14
       je        near ptr M05_L75
       test      r8,r8
       je        short M05_L32
       mov       rcx,r14
       mov       rdx,r8
       mov       r11,7FFAE06A1070
       call      qword ptr [r11]
M05_L31:
       test      eax,eax
       je        short M05_L33
M05_L32:
       lea       edx,[rsi+1]
       mov       r14d,edx
       mov       edx,[r15+10]
       cmp       edi,edx
       jae       near ptr M05_L82
       mov       r8,[r15+8]
       mov       r10,r8
       cmp       edi,[r10+8]
       jae       near ptr M05_L89
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       cmp       esi,edx
       jae       near ptr M05_L82
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
       jae       near ptr M05_L82
       mov       r8,[r15+8]
       cmp       edi,[r8+8]
       jae       near ptr M05_L89
       mov       eax,edi
       mov       r14,[r8+rax*8+10]
       lea       eax,[rdi-1]
       mov       r13d,eax
       cmp       r13d,edx
       jae       near ptr M05_L82
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       jne       near ptr M05_L30
       mov       rcx,rdx
       mov       rdx,7FFAE10C51E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L30
M05_L35:
       mov       ebx,[r15+10]
       sub       ebx,esi
       test      esi,esi
       jl        near ptr M05_L76
       test      ebx,ebx
       jl        near ptr M05_L77
       test      ebx,ebx
       jg        near ptr M05_L79
M05_L36:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M05_L42
M05_L37:
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFAE0F7E928]; System.Collections.Immutable.ImmutableExtensions.AsReadOnlyList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+90]
       test      rsi,rsi
       je        near ptr M05_L43
M05_L38:
       mov       edi,[r15+10]
       test      rbx,rbx
       je        near ptr M05_L81
       test      edi,edi
       jne       near ptr M05_L44
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M05_L39:
       mov       rcx,[rbp+10]
       cmp       r14,[rcx+8]
       je        near ptr M05_L88
       cmp       qword ptr [r14+10],0
       je        near ptr M05_L87
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M05_L86
       cmp       byte ptr [r14+24],0
       jne       short M05_L40
       mov       rcx,[r14+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F7EA30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r14+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0F7EA30]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
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
       mov       rdx,7FFAE10C5230
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M05_L37
M05_L43:
       mov       rcx,rdx
       mov       rdx,7FFAE10C5250
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
       call      qword ptr [7FFAE0F7E988]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r15,rax
       lea       r8d,[rdi+1]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9d,r14d
       call      qword ptr [7FFAE0F7E988]; System.Collections.Immutable.ImmutableSortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].NodeTreeFromList(System.Collections.Generic.IReadOnlyList`1<System.__Canon>, Int32, Int32)
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M05_L47
M05_L45:
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M05_L83
       cmp       edi,[rbx+10]
       jae       near ptr M05_L82
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       near ptr M05_L89
       mov       ecx,edi
       mov       r13,[rax+rcx*8+10]
M05_L46:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r15,r15
       je        near ptr M05_L84
       test      r14,r14
       je        near ptr M05_L85
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
       jo        near ptr M05_L90
       cmp       ecx,0FF
       ja        near ptr M05_L90
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
       mov       rdx,7FFAE10C1620
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L45
M05_L48:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFAE0D06898]
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
       mov       rdx,7FFAE0E79E58
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
       jo        near ptr M05_L90
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
       call      qword ptr [7FFAE07571E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M05_L55:
       mov       rcx,[rdi+8]
       mov       rdx,[r15+8]
       mov       r8d,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE10B5080]
       add       [r15+10],r13d
       inc       dword ptr [r15+14]
       jmp       near ptr M05_L05
M05_L56:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFAE0FFA398]
       mov       [rbp-58],rax
M05_L57:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06A1060
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
       mov       rdx,7FFAE10C5438
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
       call      qword ptr [7FFAE07571C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L57
M05_L61:
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06A1068
       call      qword ptr [r11]
       jmp       near ptr M05_L05
M05_L62:
       mov       edx,esi
       add       edx,[r15+10]
       jo        near ptr M05_L90
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
       call      qword ptr [7FFAE07571E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       jmp       near ptr M05_L07
M05_L65:
       test      r13d,r13d
       jne       short M05_L67
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L10
M05_L66:
       call      qword ptr [7FFAE10B4E40]
       int       3
M05_L67:
       call      qword ptr [7FFAE092F210]
       int       3
M05_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L11
M05_L69:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFAE0D86CA0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
M05_L70:
       call      qword ptr [7FFAE0B7D3C8]
       int       3
M05_L71:
       mov       ecx,2
       call      qword ptr [7FFAE075FD38]
       int       3
M05_L72:
       mov       [rbp-50],r14
       mov       [rbp-48],esi
       lea       rdx,[rbp-50]
       mov       r11,r12
       mov       r8,rbx
       call      qword ptr [r12]
       jmp       near ptr M05_L16
M05_L73:
       test      r8,r8
       je        near ptr M05_L17
       jmp       near ptr M05_L19
M05_L74:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M05_L31
M05_L75:
       test      r8,r8
       je        near ptr M05_L33
       jmp       near ptr M05_L32
M05_L76:
       call      qword ptr [7FFAE10B4AF8]
       int       3
M05_L77:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFAE0D06898]
       int       3
M05_L78:
       mov       ecx,10
       call      qword ptr [7FFAE0E4F930]
       int       3
M05_L79:
       sub       [r15+10],ebx
       cmp       esi,[r15+10]
       jge       short M05_L80
       mov       edx,[r15+10]
       sub       edx,esi
       mov       [rsp+20],edx
       lea       edx,[rsi+rbx]
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       mov       r9d,esi
       call      qword ptr [7FFAE0C8D878]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M05_L80:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,ebx
       call      qword ptr [7FFAE0F7FCC0]
       jmp       near ptr M05_L36
M05_L81:
       mov       ecx,40B
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M05_L82:
       call      qword ptr [7FFAE0E45C08]
       int       3
M05_L83:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M05_L46
M05_L84:
       mov       ecx,847
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M05_L85:
       mov       ecx,851
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M05_L86:
       mov       ecx,873
       mov       rdx,7FFAE0FF61E8
       call      qword ptr [7FFAE075F210]
       mov       rcx,rax
       call      qword ptr [7FFAE10B4948]
       int       3
M05_L87:
       call      qword ptr [7FFAE10B4C48]
       mov       rbx,rax
       jmp       near ptr M05_L41
M05_L88:
       mov       rbx,rcx
       jmp       near ptr M05_L41
M05_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M05_L91
       mov       rcx,[rbp-58]
       mov       r11,7FFAE06A1068
       call      qword ptr [r11]
M05_L91:
       nop
       add       rsp,28
       ret
; Total bytes of code 2838
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2512DF90008
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
       call      qword ptr [7FFAE0F7F3A8]
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
       jmp       qword ptr [7FFAE0755C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

