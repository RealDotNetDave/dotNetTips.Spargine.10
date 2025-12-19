## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4570]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5C98]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4570]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5C98]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4570]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5C98]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4570]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5C98]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFC6CECE550]
       mov       ecx,5496
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C857870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C857870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D124240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D124258]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E5068]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4570]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E5068]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4570]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C855818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C855818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,2B3CEDF0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFC6D1E6F40]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L15
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5C68]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L14
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5C68]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L14:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L21
M00_L15:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L18
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L17
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L19
M00_L16:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L20
M00_L17:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45B8]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5C68]
       jmp       short M00_L16
M00_L20:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L15
       jmp       near ptr M00_L05
M00_L21:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L23
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L13
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45B8]
       int       3
M00_L24:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5C68]
       jmp       short M00_L22
M00_L25:
       call      qword ptr [7FFC6CECE6B8]
       mov       ecx,5496
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C857870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C857870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D124390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D1243A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E50B0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E50B0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45B8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1212
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C855818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C855818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,222CCF70008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFC6D1E6F88]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F45B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1F5C68]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F45B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1F5C68]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F45B8]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFC6D1F5C68]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F45B8]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D1F5C68]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFC6CEDE6B8]
       mov       ecx,5496
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C867870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C867870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D134390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D1343A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1F50B0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F45B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1F50B0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F45B8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,20332590008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFC6D1F6F88]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5CF8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5CF8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45D0]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5CF8]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45D0]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5CF8]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFC6CECE5B0]
       mov       ecx,5496
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C857870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C857870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D124270]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D124288]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E50C8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45D0]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E50C8]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E45D0]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C855818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C855818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,28057260008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFC6D1E6FA0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EAC0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D13EAD8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EAC0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D13EAD8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EAC0]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFC6D13EAD8]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EAC0]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D13EAD8]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFC6CEB69B8]
       mov       ecx,5496
       mov       rdx,7FFC6CBE5D88
       call      qword ptr [7FFC6CAC7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CBE5D88
       call      qword ptr [7FFC6CAC7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C847870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CBE5D88
       call      qword ptr [7FFC6CAC7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C847870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6CFEC750]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6CFEC768]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D13EAF0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EAC0]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D13EAF0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EAC0]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1EA90580008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFC6D13F1F8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L15
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13D158]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D13D170]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L14
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13D158]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D13D170]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L14:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L21
M00_L15:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L18
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L17
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L19
M00_L16:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L20
M00_L17:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13D158]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FFC6D13D170]
       jmp       short M00_L16
M00_L20:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L15
       jmp       near ptr M00_L05
M00_L21:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L23
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L13
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13D158]
       int       3
M00_L24:
       mov       rcx,r15
       call      qword ptr [7FFC6D13D170]
       jmp       short M00_L22
M00_L25:
       call      qword ptr [7FFC6CEDE598]
       mov       ecx,5496
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C867870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C867870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D134288]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D1342A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D13D188]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13D158]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D13D188]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13D158]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1212
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1A2EB230008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFC6D1F7018]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D126EE0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D12F678]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D126EE0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D12F678]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFC6D126EE0]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFC6D12F678]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D126EE0]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D12F678]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFC6CEDE5B0]
       mov       ecx,5496
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C867870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C867870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D125E18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D125E30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D126EF8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D126EE0]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D126EF8]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D126EE0]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,2B6D3590008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFC6D1F76A8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016A78]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D01C300]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016A78]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D01C300]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016A78]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFC6D01C300]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016A78]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D01C300]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFC6CEBE550]
       mov       ecx,5496
       mov       rdx,7FFC6CBE5D88
       call      qword ptr [7FFC6CAC7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC6CBE5D88
       call      qword ptr [7FFC6CAC7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C847870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFC6CBE5D88
       call      qword ptr [7FFC6CAC7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6C847870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D017F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6D017F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D0175D0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016A78]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D0175D0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016A78]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,21A45FF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFC6D207B88]
       int       3
; Total bytes of code 235
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,21D62400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,747BC88A
       mov       r8d,5C7D1C43
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L07
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,4
       jb        short M00_L10
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D135410]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFC6C790CF0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C790CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,107B9C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4A0D6FAC
       mov       r8d,426937E5
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D1653F8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CCB7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFC6C7C0CF0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C7C0CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,14435000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,265D9419
       mov       r8d,22381B56
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L07
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,4
       jb        short M00_L10
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D12CE88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFC6C7A10B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C7A10C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1E8D6400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1D7969AC
       mov       r8d,1D5E53B2
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D12CF00]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFC6C7A10B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C7A10C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,20651400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C4343F78
       mov       r8d,0E46F327F
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D125410]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC77828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jae       short M00_L09
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       jmp       short M00_L10
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFC6C780CF0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C780CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,298A1400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CF2A962F
       mov       r8d,0B48CB950
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       esi,esi
M00_L07:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D1354B8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FFC6C790F30
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C790F38
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       esi,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1FD12C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,168433BA
       mov       r8d,0BE6CFC85
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       esi,esi
M00_L07:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D11EA60]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FFC6C7A1320
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C7A1328
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       esi,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1992E000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4A5A2267
       mov       r8d,742728A7
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L07
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,4
       jb        short M00_L10
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC6D1F69A0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFC6C791710
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFC6C791718
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A0],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L25
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L01
       xchg      ax,ax
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L24
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,1CFB8402AC0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rdi,4
       dec       r13d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L21
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L22:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L20
       nop       dword ptr [rax]
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L24:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L19
M00_L25:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L28
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1CFB8402AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CFB8402AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1EF2E8]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       edi,edi
       mov       r13d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFC6C7A0F98
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0FA8
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0FB0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       r14d,1
       jo        near ptr M00_L89
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L78
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFC6D1E5F38]
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L74:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L75:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B0],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L79
       mov       rcx,[rbp-0B0]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFC6D12D068]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFC6D1EF300]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC6CC978D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5380]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D12D0E0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2104D256FB8
       mov       r8,2104D256FB8
       call      qword ptr [7FFC6D124270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5380]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L94
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0FB0
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L102
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L101
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5380]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L116
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L115
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5380]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4888]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2760
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1E54A0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A0],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L19
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L01
       xchg      ax,ax
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L30
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,2B2DA800AE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rdi,4
       dec       r13d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L22
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L20
       nop       dword ptr [rax]
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L27
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L30:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2B2DA800AD8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B2DA800AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D13EF58]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       edi,edi
       mov       r13d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFC6C7A0DB0
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0DC0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       r14d,1
       jo        near ptr M00_L90
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L79
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L77
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       rax,rcx
       jg        near ptr M00_L76
       jmp       near ptr M00_L81
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFC6D13EDF0]
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L74:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B0],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B0]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L74
M00_L75:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       movsxd    rdx,ecx
       mov       rax,[rbp-88]
       cmp       rax,rdx
       mov       r8,rcx
       jle       near ptr M00_L81
M00_L76:
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFC6D135458]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFC6D13EFB8]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC6CC978D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       edi,1
       jo        near ptr M00_L90
       cmp       edi,[rbp-5C]
       jl        short M00_L82
M00_L84:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D13EE08]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFC6D1354D0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F359886FB8
       mov       r8,2F359886FB8
       call      qword ptr [7FFC6CFFC738]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D13EE08]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L91
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-3C],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L93
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-3C],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L95
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7A0DC8
       call      qword ptr [r11]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L96
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-3C],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L98
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L99
       mov       [rbp-3C],ecx
M00_L98:
       add       rsp,28
       ret
M00_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D13EE08]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L105:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L106
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-5C],ecx
M00_L106:
       add       rsp,28
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L108
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-5C],ecx
M00_L108:
       add       rsp,28
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L110
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L111
       mov       [rbp-5C],ecx
M00_L110:
       add       rsp,28
       ret
M00_L111:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L112
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L113
       mov       [rbp-5C],ecx
M00_L112:
       add       rsp,28
       ret
M00_L113:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D13EE08]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFC6D13EDD8]
       int       3
M00_L117:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L118:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L119:
       add       rsp,28
       ret
; Total bytes of code 2775
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1D5BD8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A0],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L25
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L01
       xchg      ax,ax
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L24
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,29979402AC0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rdi,4
       dec       r13d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L21
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L22:
       mov       rcx,r13
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L20
       nop       dword ptr [rax]
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L24:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L19
M00_L25:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L28
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,29979402AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C876BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29979402AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAF7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAF79A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D20E7F0]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       edi,edi
       mov       r13d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFC6C7C1110
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7C1118
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7C1120
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7C1128
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       r14d,1
       jo        near ptr M00_L89
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L67
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L67
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L66
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L78
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L63
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L64
M00_L62:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L65
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L64:
       mov       rcx,r12
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L62
M00_L65:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L66:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L61
M00_L67:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L70
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L69
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L71
M00_L68:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L72
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L71:
       mov       rcx,r13
       call      qword ptr [7FFC6D205F80]
       jmp       short M00_L68
M00_L72:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L67
       jmp       near ptr M00_L51
M00_L73:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L74:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L75:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B0],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L79
       mov       rcx,[rbp-0B0]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFC6D14CFD8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFC6D20E808]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CC15D88
       call      qword ptr [7FFC6CAF7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC6CCB78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D2053C8]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D14D050]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2DA0E6C6FB8
       mov       r8,2DA0E6C6FB8
       call      qword ptr [7FFC6D1442B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D2053C8]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L94
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7C1128
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L102
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L101
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D2053C8]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L116
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L115
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D2053C8]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D2048D0]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2760
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D2054D0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A8],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L19
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L30
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,28CED002AC0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdi,[r14+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r13,4
       mov       eax,[rbp-94]
       dec       eax
       mov       [rbp-94],eax
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L22
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
       nop       dword ptr [rax+rax]
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L27
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L30:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,28CED002AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28CED002AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1EE838]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       r13d,r13d
       mov       [rbp-94],eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFC6C7A0F90
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0F98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0FA0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0FA8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       r14d,1
       jo        near ptr M00_L89
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L78
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFC6D1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       r8,[rbp-0A0]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L74:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L75:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L79
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFC6D12D0C8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFC6D1EE850]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC6CC978D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E53F8]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D12D140]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CD81FB6FB8
       mov       r8,2CD81FB6FB8
       call      qword ptr [7FFC6D1243A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E53F8]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L94
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0FA8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L102
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L101
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E53F8]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L116
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L115
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E53F8]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4900]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2776
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFC6D1E5518]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A8],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L19
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L30
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,24C5D800AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdi,[r14+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r13,4
       mov       eax,[rbp-94]
       dec       eax
       mov       [rbp-94],eax
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L22
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
       nop       dword ptr [rax+rax]
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L27
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L30:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,24C5D800AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24C5D800AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1EE7A8]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       r13d,r13d
       mov       [rbp-94],eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFC6C7A0F90
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0F98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0FA0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0FA8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       r14d,1
       jo        near ptr M00_L89
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L78
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-90],rax
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFC6D1E5F20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       rcx,[rbp-0A0]
       add       ecx,1
       jo        near ptr M00_L79
       mov       r8,rcx
       mov       rax,[rbp-90]
M00_L74:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,edi
       mov       [rbp-88],r9
M00_L75:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L79
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFC6D12D068]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFC6D1EE7C0]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC6CC978D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5368]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D12D0E0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28CDC776FB8
       mov       r8,28CDC776FB8
       call      qword ptr [7FFC6D124258]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5368]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L94
       mov       rcx,[rbp-0B0]
       mov       r11,7FFC6C7A0FA8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L102
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L101
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5368]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L116
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L115
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1E5368]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4870]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2775
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFC6D1E5488]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A0],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L22
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       word ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L33
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,2809B802AC0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L35
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L34
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L36
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L40
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rdi,4
       dec       r13d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rdi
       mov       r11,7FFC6C7B0FD0
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L20:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7B0FD8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7B0FE0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7B0FE8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L25
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r15
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
       nop       dword ptr [rax]
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L30
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L31:
       mov       rcx,r13
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L33:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAE7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2809B802AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C866BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2809B802AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L38
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAE79A8]
       int       3
M00_L37:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1FE808]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L39:
       xor       edi,edi
       mov       r13d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       r14d,1
       jo        near ptr M00_L89
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L63
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L63
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L62
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L78
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L72
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L70
M00_L61:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L62:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       near ptr M00_L74
M00_L63:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L66
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L65
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L67
M00_L64:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L68
M00_L65:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,r13
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L64
M00_L68:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L63
       jmp       near ptr M00_L51
M00_L69:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L70:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L69
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L71:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B0],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L79
       mov       rcx,[rbp-0B0]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L71
       jmp       near ptr M00_L69
M00_L72:
       call      qword ptr [7FFC6D13D020]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L73
       call      qword ptr [7FFC6D13D548]
       mov       rbx,rax
M00_L73:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CC05D88
       call      qword ptr [7FFC6CAE7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC6CCA78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L74:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L76
       mov       rcx,r12
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L77
M00_L75:
       mov       dword ptr [rbp-64],1
       jmp       near ptr M00_L61
M00_L76:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L77:
       mov       rcx,r12
       call      qword ptr [7FFC6D13D488]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L75
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1354B8]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D13D098]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C130AF6FB8
       mov       r8,2C130AF6FB8
       call      qword ptr [7FFC6D1342E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1354B8]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L94
       mov       rcx,[rbp-0A8]
       mov       r11,7FFC6C7B0FE8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L102
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L101
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1354B8]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L116
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L115
       mov       rcx,r15
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFC6D1354B8]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1354A0]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2770
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFC6D1F55A8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-98],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,28CBA000AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFC6C7A13D0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L20:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A13D8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A13E0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A13E8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,28CBA000AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28CBA000AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1EFE70]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L88
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       r14d,r14d
       test      rsi,rsi
       je        near ptr M00_L61
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       eax,eax
       mov       [rbp-60],eax
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L48
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       mov       r15d,1
       cmp       esi,1
       jle       short M00_L58
       test      r14,r14
       je        short M00_L52
       cmp       [r14+8],esi
       jge       near ptr M00_L72
M00_L52:
       xor       eax,eax
       mov       [rbp-64],eax
       cmp       r15d,[r14+8]
       jae       short M00_L55
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L54
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-98]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L78
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L59
M00_L60:
       mov       esi,[rdi+8]
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       eax,eax
       mov       [rbp-60],eax
       cmp       r14d,[rsi+8]
       jae       short M00_L64
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L63
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r15
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L69
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L70:
       mov       rcx,r13
       call      qword ptr [7FFC6D10F990]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L72:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       short M00_L67
M00_L73:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
M00_L74:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L80
       cmp       r8d,r13d
       jae       near ptr M00_L78
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L75:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L79
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFC6D10EB80]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFC6D10FB28]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6CC978D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L88
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       esi,1
       jo        near ptr M00_L89
       cmp       esi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],rdi
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D106F40]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D10EBF8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2CD39086FB8
       mov       r8,2CD39086FB8
       call      qword ptr [7FFC6D105E78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D106F40]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L94
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A13E8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L102
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L101
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D106F40]
M00_L100:
       add       edi,1
       jo        short M00_L103
       cmp       edi,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L116
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L115
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D106F40]
M00_L114:
       add       esi,1
       jo        short M00_L117
       cmp       esi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D106F28]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2765
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFC6D1E5620]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-98],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,20EEE400B68
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFC6C7A17B0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L20:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A17B8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A17C0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A17C8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20EEE400B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20EEE400B68
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D3C4A38]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L88
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       r14d,r14d
       test      rsi,rsi
       je        near ptr M00_L63
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L63
M00_L46:
       xor       eax,eax
       mov       [rbp-60],eax
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L48
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       mov       r15d,1
       cmp       esi,1
       jle       short M00_L58
       test      r14,r14
       je        short M00_L52
       cmp       [r14+8],esi
       jge       near ptr M00_L62
M00_L52:
       xor       eax,eax
       mov       [rbp-64],eax
       cmp       r15d,[r14+8]
       jae       short M00_L55
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L54
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-98]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L78
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L59
M00_L60:
       mov       esi,[rdi+8]
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L72
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L70
M00_L61:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L62:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       near ptr M00_L74
M00_L63:
       xor       eax,eax
       mov       [rbp-60],eax
       cmp       r14d,[rsi+8]
       jae       short M00_L66
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L65
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L67
M00_L64:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L68
M00_L65:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,r15
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L64
M00_L68:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L63
       jmp       near ptr M00_L51
M00_L69:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
M00_L70:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L80
       cmp       r8d,r13d
       jae       near ptr M00_L78
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L69
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L71:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L79
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L71
       jmp       near ptr M00_L69
M00_L72:
       call      qword ptr [7FFC6D206958]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L73
       call      qword ptr [7FFC6D207120]
       mov       rbx,rax
M00_L73:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E35
       mov       rdx,7FFC6CBF5D88
       call      qword ptr [7FFC6CAD7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6CC978D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L74:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L76
       mov       rcx,r13
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L77
M00_L75:
       mov       dword ptr [rbp-64],1
       jmp       near ptr M00_L61
M00_L76:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L77:
       mov       rcx,r13
       call      qword ptr [7FFC6D01C360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L75
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L88
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       esi,1
       jo        near ptr M00_L89
       cmp       esi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],rdi
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D017618]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFC6D2069D0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24F6D2C6FB8
       mov       r8,24F6D2C6FB8
       call      qword ptr [7FFC6D01C300]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D017618]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L94
       mov       rcx,[rbp-0A0]
       mov       r11,7FFC6C7A17C8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L102
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L101
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D017618]
M00_L100:
       add       edi,1
       jo        short M00_L103
       cmp       edi,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L116
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L115
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D017618]
M00_L114:
       add       esi,1
       jo        short M00_L117
       cmp       esi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016AC0]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2775
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFC6D017738]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-68],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EB98]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D11EB38]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EB98]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D11EB38]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,24C93800AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EB98]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFC6D11EB38]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EB98]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFC6D11EB38]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,24C93800AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C836BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24C93800AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAB7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAB79A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-60],rax
       mov       [rbp-58],edx
       lea       rdx,[rbp-60]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC6D11EE80]
       mov       r13,[rbp-50]
       mov       eax,[rbp-48]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFC6C780D30
       call      qword ptr [r11]
       mov       [rbp-70],rax
M00_L39:
       mov       rcx,[rbp-70]
       mov       r11,7FFC6C780D38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-70]
       mov       r11,7FFC6C780D40
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-70]
       mov       r11,7FFC6C780D48
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-34]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D11EB68]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EB98]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-34],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L54
       mov       rcx,[rbp-70]
       mov       r11,7FFC6C780D48
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L55
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-34],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L57
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-34],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D11EB68]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-34]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EB98]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1381
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1B5860]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4678]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1C5DA0]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4678]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1C5DA0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,247DA002AC0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4678]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D1C5DA0]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4678]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFC6D1C5DA0]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,247DA002AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C836BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,247DA002AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAB7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAB79A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1CF060]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFC6C7810F8
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781100
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781108
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781110
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D1C5170]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4678]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781110
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D1C5170]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4678]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1C5278]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4618]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1C5CC8]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4618]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1C5CC8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1A99E800AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4618]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFC6D1C5CC8]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4618]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFC6D1C5CC8]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A99E800AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C836BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A99E800AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAB7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAB79A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1CE4D8]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFC6C7810F0
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7810F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781100
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781108
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D1C5110]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4618]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781108
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D1C5110]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4618]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1C5218]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4678]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5D28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4678]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5D28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1556A000AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4678]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5D28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4678]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5D28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1556A000AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1556A000AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFC6CAD7DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFC6CAD79A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1EE538]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFC6C7A0F70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7A0F78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7A0F80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7A0F88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D1E5170]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4678]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7A0F88
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D1E5170]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4678]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFC6D1E5290]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D165680]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D165698]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D165680]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D165698]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1CC3E400AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFC6C7C0D70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7C0D78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7C0D80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7C0D88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D165680]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFC6D165698]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D165680]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFC6D165698]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAF7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1CC3E400AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C876BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CC3E400AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAF79A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D16F258]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D165710]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D165680]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C7C0D88
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D165710]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D165680]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D16F288]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D10D320]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D10D338]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D10D320]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D10D338]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,24E33802AC0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFC6C780FB0
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C780FB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C780FC0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C780FC8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D10D320]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFC6D10D338]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D10D320]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFC6D10D338]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAB7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,24E33802AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C836BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24E33802AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAB79A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1CE568]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D10D3B0]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D10D320]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C780FC8
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D10D3B0]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D10D320]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1C5338]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D0E63B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D0EEBB0]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D0E63B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D0EEBB0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1E490C00AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFC6C781328
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781330
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781338
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781340
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D0E63B8]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFC6D0EEBB0]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D0E63B8]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFC6D0EEBB0]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAB7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E490C00AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C836BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E490C00AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAB79A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D1CF7F8]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D0E63D0]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D0E63B8]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C781340
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D0E63D0]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D0E63B8]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D1C4CF0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016B08]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D124150]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016B08]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D124150]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,22A1F800B78
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFC6C791770
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C791778
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C791780
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C791788
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016B08]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFC6D124150]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016B08]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFC6D124150]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFC6CAC7DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22A1F800B70
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFC6C846BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22A1F800B78
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFC6CAC79A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC6D3B4720]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D017648]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016B08]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFC6C791788
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFC6D017648]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFC6D016B08]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFC6D017750]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D44C8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1D5B78]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D44C8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1D5B78]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D44C8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFC6D1D5B78]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D44C8]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D1D5B78]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1D4FC0]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D44C8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1D4FC0]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D44C8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1F5BA8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1F5BA8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FFC6D1F5BA8]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FFC6D1F5BA8]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1F4FF0]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1F4FF0]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4510]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1D5C38]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L27
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4510]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1D5C38]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L27
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L33
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L26
       cmp       dword ptr [rax+rcx*4+10],0
       jne       near ptr M00_L28
       add       ecx,1
       jo        near ptr M00_L27
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4510]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFC6D1D5C38]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L27
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4510]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D1D5C38]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L27
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L31
M00_L29:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L37
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L35
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L34
M00_L30:
       add       esi,1
       jo        short M00_L38
       cmp       esi,[rbp-2C]
       jl        short M00_L29
M00_L31:
       xor       edi,edi
M00_L32:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L33:
       call      M00_L47
       jmp       short M00_L36
M00_L34:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1D5008]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4510]
       int       3
M00_L36:
       mov       edi,1
       jmp       short M00_L32
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L43
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-2C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L45
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-2C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L47:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L53
M00_L48:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L51
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L50
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1D5008]
M00_L49:
       add       esi,1
       jo        short M00_L52
       cmp       esi,[rbp-2C]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4510]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L53:
       add       rsp,28
       ret
; Total bytes of code 916
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4540]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5C68]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L27
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4540]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5C68]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L27
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L33
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L26
       cmp       dword ptr [rax+rcx*4+10],0
       jne       near ptr M00_L28
       add       ecx,1
       jo        near ptr M00_L27
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4540]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFC6D1E5C68]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L27
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4540]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D1E5C68]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L27
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L31
M00_L29:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L37
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L35
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L34
M00_L30:
       add       esi,1
       jo        short M00_L38
       cmp       esi,[rbp-2C]
       jl        short M00_L29
M00_L31:
       xor       edi,edi
M00_L32:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L33:
       call      M00_L47
       jmp       short M00_L36
M00_L34:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E5038]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4540]
       int       3
M00_L36:
       mov       edi,1
       jmp       short M00_L32
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L43
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-2C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L45
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-2C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L47:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L53
M00_L48:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L51
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L50
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1E5038]
M00_L49:
       add       esi,1
       jo        short M00_L52
       cmp       esi,[rbp-2C]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4540]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L53:
       add       rsp,28
       ret
; Total bytes of code 916
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4570]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFC6D1F5C20]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4570]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFC6D1F5C20]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4570]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFC6D1F5C20]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4570]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFC6D1F5C20]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1F5068]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4570]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFC6D1F5068]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4570]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EC88]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFC6D11ECA0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EC88]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFC6D11ECA0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EC88]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFC6D11ECA0]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EC88]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFC6D11ECA0]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFC6D11ECE8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EC88]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFC6D11ECE8]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFC6D11EC88]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D117168]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFC6D11F8A0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D117168]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFC6D11F8A0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D117168]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFC6D11F8A0]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D117168]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFC6D11F8A0]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFC6D117180]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFC6D117168]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFC6D117180]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFC6D117168]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036AF0]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFC6D03C300]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036AF0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFC6D03C300]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036AF0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFC6D03C300]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036AF0]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFC6D03C300]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FFCCC436030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFC6D037630]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036AF0]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFC6D037630]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036AF0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,207F7C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,978BA952
       mov       r11d,5ABB9A76
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4570]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D11D8C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7910C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8457D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D11D038]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7910B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1D5068]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1D5068]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1D4570]
       int       3
; Total bytes of code 1060
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFC6D21B2B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFC6D21B2B0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D11F438]
       int       3
M02_L01:
       mov       rcx,7FFC6D21B2B4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1D6538]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,16044400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0D1B12303
       mov       r11d,783570CF
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4558]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1C5C08]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7810C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8357D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D10CED0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC77828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7810B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1C5050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1C5050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4558]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D20B460
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D20B458
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D10F468]
       int       3
M01_L01:
       mov       rcx,7FFC6D20B45C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1C6538]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2D229800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,937E0676
       mov       r11d,8DA238A3
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4558]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1E5C80]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7A10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8557D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D12CE58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7A10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1E5050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1E5050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4558]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D22A3F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D22A3F0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D12F420]
       int       3
M01_L01:
       mov       rcx,7FFC6D22A3F4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1E6538]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,20B00000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,62D6DD6A
       mov       r11d,8322DDFB
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4558]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1E5C80]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7A10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8557D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D12D020]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7A10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1E5050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1E5050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4558]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D22B298
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D22B290
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D12F420]
       int       3
M01_L01:
       mov       rcx,7FFC6D22B294
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1E6538]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,27074800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0A8CFC523
       mov       r11d,60B6E5D9
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4558]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D10F378]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7810C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8357D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D10CF18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC77828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7810B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1C5050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1C5050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4558]
       int       3
; Total bytes of code 1060
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFC6D20BD10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFC6D20BD08
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D10F420]
       int       3
M02_L01:
       mov       rcx,7FFC6D20BD0C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1C65B0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,189F3400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0E991F1B3
       mov       r11d,8CE53924
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1154A0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D11D830]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7910C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8457D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D11CF90]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7910B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1154B8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1154B8]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1154A0]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFC6D21BD48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFC6D21BD40
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D11F4B0]
       int       3
M02_L01:
       mov       rcx,7FFC6D21BD44
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1D65F8]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,130FE800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0CB58D5E9
       mov       r11d,56ADDD62
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1071E0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1D5D58]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C791358
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8457D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D10ECE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C791350
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1071F8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1071F8]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1071E0]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D2382D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D2382D0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D01D9F8]
       int       3
M01_L01:
       mov       rcx,7FFC6D2382D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1D6C88]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1BD5E400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0DBD79C8
       mov       r11d,7A21A4AF
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6CFFF0F0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6CFFF060]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C791680
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8457D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D2156F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC87828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C791678
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6CFFF078]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6CFFF078]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFC6CFFF0F0]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D244EA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D244E98
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6CFF4DF8]
       int       3
M01_L01:
       mov       rcx,7FFC6D244E9C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D2166D0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2175CC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0F096DFE3
       mov       r11d,898F7E16
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4528]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D12D788]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7A10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8557D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D12CF00]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7A10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1E5020]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1E5020]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1E4528]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFC6D22B280
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFC6D22B278
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D12F3F0]
       int       3
M02_L01:
       mov       rcx,7FFC6D22B27C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1E64F0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,19179C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0BD90359F
       mov       r11d,0FC2F47FC
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D13D758]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7B10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8657D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D13CEB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CCA7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7B10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1F4FF0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1F4FF0]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F44F8]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFC6D23B288
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFC6D23B280
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D13F3C0]
       int       3
M02_L01:
       mov       rcx,7FFC6D23B284
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1F64C0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1F7F1400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0A8AAE785
       mov       r11d,5F883FA0
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4540]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D10F2B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7810C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8357D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D10D020]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC77828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7810B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1C5038]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1C5038]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1C4540]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFC6D20B2B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFC6D20B2B0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D10F408]
       int       3
M02_L01:
       mov       rcx,7FFC6D20B2B4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1C6508]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,28DDBC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,57FCAA8E
       mov       r11d,0D03E148B
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4528]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1F5BD8]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7B10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8657D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D13CF00]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CCA7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7B10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1F5020]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1F5020]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1F4528]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D23A6D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D23A6C8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D13F3F0]
       int       3
M01_L01:
       mov       rcx,7FFC6D23A6CC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1F6508]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,17CE1000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,6DC80696
       mov       r11d,84201345
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D15EA18]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D155C50]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7B0CF8
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8657D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D1553C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CCA7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7B0CF0
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D15EA30]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D15EA30]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D15EA18]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FFCB80A3D78]
       int       3
M02_L01:
       call      qword ptr [7FFCB80A3D80]
       int       3
; Total bytes of code 45
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,231C1C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,6F852AF0
       mov       r11d,72BB6877
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1254B8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1E5C20]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7A10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8557D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D12CFA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC97828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7A10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1254D0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1254D0]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1254B8]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D22BD58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D22BD50
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D12F480]
       int       3
M01_L01:
       mov       rcx,7FFC6D22BD54
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1E65E0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2A3A9400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,67CA426F
       mov       r11d,3CD6AF57
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1271B0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D1F5980]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7B1358
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFC6C8657D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D12EBC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CCA7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7B1350
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1271C8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D1271C8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D1271B0]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFC6D259000
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFC6D258FF8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D03D9F8]
       int       3
M01_L01:
       mov       rcx,7FFC6D258FFC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC6D1F6CA0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1C6B5800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,736B6A9B
       mov       r11d,49044355
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFCCC379E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036B38]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6D03C3C0]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFC6C7B1708
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6D2B71B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CCA7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFC6C7B1700
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D037678]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFCCC436030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFC6D037678]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFC6D036B38]
       int       3
; Total bytes of code 1050
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FFC6D0355A8]
       int       3
M01_L01:
       call      qword ptr [7FFC6D15E6A0]
       int       3
; Total bytes of code 45
```

